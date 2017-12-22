function rowAllocationArray() {
    return [
        { rowIndex: 0, requiredNo: 0 },
        { rowIndex: 1, requiredNo: 5 },
        { rowIndex: 2, requiredNo: 10 },
        { rowIndex: 3, requiredNo: 15 },
        { rowIndex: 4, requiredNo: 20 },
        { rowIndex: 5, requiredNo: 25 },
        { rowIndex: 6, requiredNo: 30 }
    ];
}

function warcraftClassVm(warcraftClassSpecificationVm) {

    function WarcraftClass(wc) {
        this.id = wc.id;
        this.className = wc.className;
        this.iconFilePath = wc.iconFilePath;
        this.specifications = wc.specifications ? wc.specifications.map(warcraftClassSpecificationVm.build) : [];
        this.isSelected = false;
    }

    WarcraftClass.build = function(data) {
        return new WarcraftClass(data);
    }

    return WarcraftClass;
}

function warcraftClassSpecificationVm(talentVm) {

    function WarcraftClassSpecification(wcs, className) {
        this.id = wcs.id;
        this.specName = wcs.specificationName;
        this.index = wcs.specificationIndex;
        this.backgroundImage = wcs.backgroundImage;
        this.specificationIcon = wcs.specificationIcon;
        this.talentRows = wcs.talentRows.length > 0 ? wcs.talentRows.map(talents => talents.map(talentVm.build, {
            spec: wcs
        })) : [];
        this.talentsWithRequirements = wcs.talentsWithRequirements;
    }

    WarcraftClassSpecification.build = function(data) {
        return new WarcraftClassSpecification(data);
    }

    return WarcraftClassSpecification;
}

function talentVm(talentRankVm, reqTalentVm) {

    function Talent(t, spec) {
        this.id = t.id;
        this.talentName = t.talentName;
        this.specName = spec.specificationName;
        this.specIndex = spec.specificationIndex;
        this.colIndex = t.columnIndex;
        this.rowIndex = t.rowIndex;
        this.iconFilePath = t.iconFilePath;
        this.talentRanks = t.talentRanks.map(talentRankVm.build);
        this.requiredTalent = t.requiredTalent !== null ? reqTalentVm.build(t.requiredTalent) : null;
        this.selectedRankNo = 0;
        this.isActive = t.rowIndex === 0 && t.requiredTalent === null;
    }

    Talent.build = function(data) {
        return new Talent(data, this.spec);
    }

    return Talent;
}

function talentRankVm() {

    function TalentRank(tr) {
        this.id = tr.id;
        this.rankDescription = tr.rankDescription;
        this.rankNo = tr.rankNo;
    }

    TalentRank.build = function(data) {
        return new TalentRank(data);
    }

    return TalentRank;
}

function reqTalentVm() {

    function RequiredTalent(req) {
        this.id = req.id;
        this.colIndex = req.columnIndex;
        this.rowIndex = req.rowIndex;
        this.requiredTalentMessage = req.requiredTalentMessage;
        this.arrowDirection = req.arrowDirection;
    }

    RequiredTalent.build = function (data) {
        return new RequiredTalent(data);
    }

    return RequiredTalent;
}

function inspectedTalentVm(reqTalentVm, rowAllocationArray) {

    function InspectedTalent(t, selectedTalents, totalPointsPerSpec) {
        var currentRank = t.selectedRankNo > 0 ? _.find(t.talentRanks, { 'rankNo': t.selectedRankNo }) : null;
        var nextRank = t.selectedRankNo < t.talentRanks.length ? _.find(t.talentRanks, { 'rankNo': t.selectedRankNo + 1 }) : null;

        this.id = t.id;
        this.name = t.talentName;
        this.selectedRankNo = t.selectedRankNo;
        this.totalRankNo = t.talentRanks.length;
        this.requirementsText = '';

        this.updateRankNo(t, selectedTalents, totalPointsPerSpec)
    }

    InspectedTalent.prototype.getCurrentRankText = function(t) {
        if (t.selectedRankNo > 0) {
            return _.find(t.talentRanks, { 'rankNo': t.selectedRankNo }).rankDescription;
        }

        return t.talentRanks[0].rankDescription;
    }

    InspectedTalent.prototype.getNextRankText = function(t) {
        if (t.selectedRankNo < t.talentRanks.length) {
            return _.find(t.talentRanks, { 'rankNo': t.selectedRankNo + 1 }).rankDescription;
        }

        return "";
    }

    InspectedTalent.prototype.validateRequirements = function(t, selectedTalents, totalPointsInSpec) {
        var hasReqs = true;
        var inspecTalent = this;

        if (t.requiredTalent !== null) {
            var requiredTalent = _.find(selectedTalents, { 'id': t.requiredTalent.id });
            hasReqs = requiredTalent && requiredTalent.selectedRankNo === requiredTalent.talentRanks.length;

            inspecTalent.requirementsText = !hasReqs ? t.requiredTalent.requiredTalentMessage + '<br />' : '';
        }

        angular.forEach(rowAllocationArray, function(req) {
            if (t.rowIndex === req.rowIndex && totalPointsInSpec < req.requiredNo) {
                inspecTalent.requirementsText += sprintf('Requires %s points in %s', req.requiredNo, t.specName);
                hasReqs = false;
                return;
            }
        });

        return hasReqs;
    }

    InspectedTalent.prototype.canBeUnlearned = function (t, selectedTalents, totalPointsInSpec) {
        // 1. Has a RankNo greater than 0
        if (t.selectedRankNo === 0)
            return false;

        // 2. Does not have a selected Talent on a higher row that requires X points.
        var topTalent = _.maxBy(selectedTalents, function (t) { return t.rowIndex; });
        var requiredPointsForTopTalent = totalPointsInSpec - topTalent.selectedRankNo;
        var requirements = _.find(rowAllocationArray, { 'rowIndex': topTalent.rowIndex });

        if (requirements.requiredNo === requiredPointsForTopTalent && topTalent.rowIndex !== t.rowIndex)
            return false;

        // 3. The Talent is not part of a Talent Requirement where the next talent has points allocated.
        var hasRequisiteTalent = false;

        angular.forEach(selectedTalents, function (st) {
            var rt = st.requiredTalent;

            if (rt !== null && rt.id === t.id) {
                hasRequisiteTalent = true;
                return;
            }
        });

        if (hasRequisiteTalent)
            return false;

        return true;
    }

    InspectedTalent.prototype.getInstructionText = function(t) {
        if (t.isActive && t.selectedRankNo === 0) {
            return 'Click to learn'
        }

        if (this.isUnlearnable && t.isActive && t.selectedRankNo === t.talentRanks.length) {
            return 'Right click to unlearn'
        }

        return '';
    }

    InspectedTalent.prototype.updateRankNo = function(t, selectedTalents, totalPointsInSpec) {
        this.selectedRankNo = t.selectedRankNo;
        this.selectedRankText = this.getCurrentRankText(t);
        this.nextRankText = this.getNextRankText(t);
        this.isMaxRank = t.selectedRankNo === t.talentRanks.length;
        this.isLearnable = this.validateRequirements(t, selectedTalents, totalPointsInSpec);
        this.isUnlearnable = this.canBeUnlearned(t, selectedTalents, totalPointsInSpec);
        this.instructionText = this.getInstructionText(t);
    }

    InspectedTalent.build = function(data, selectedTalents, totalPointsInSpec) {
        return new InspectedTalent(data, selectedTalents, totalPointsInSpec);
    }

    return InspectedTalent;
}
