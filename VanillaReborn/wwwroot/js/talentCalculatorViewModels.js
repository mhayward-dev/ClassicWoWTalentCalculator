
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
    }

    WarcraftClassSpecification.build = function(data) {
        return new WarcraftClassSpecification(data);
    }

    return WarcraftClassSpecification;
}

function talentVm(talentRankVm, talentReqVm) {

    function Talent(t, spec) {
        this.id = t.id;
        this.talentName = t.talentName;
        this.specName = spec.specificationName;
        this.specIndex = spec.specificationIndex;
        this.colIndex = t.columnIndex;
        this.rowIndex = t.rowIndex;
        this.iconFilePath = t.iconFilePath;
        this.talentRanks = t.talentRanks.map(talentRankVm.build);
        this.talentRequirement = t.talentRequirement !== null ? talentReqVm.build(t.talentRequirement) : null;
        this.selectedRankNo = 0;
        this.isActive = t.rowIndex === 0;
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

function talentReqVm() {

    function TalentRequirement(req) {
        this.id = req.id;
        this.talentId = req.talentId;
        this.requiredTalentId = req.requiredTalentId;
        this.endColIndex = req.requiredTalentColumnIndex;
        this.endRowIndex = req.requiredTalentRowIndex;
        this.requiredTalentMessage = req.requiredTalentMessage;
    }

    TalentRequirement.build = function(data) {
        return new TalentRequirement(data);
    }

    return TalentRequirement;
}

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

function inspectedTalentVm(talentReqVm, rowAllocationArray) {

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

        if (t.talentRequirement !== null) {
            var requiredTalent = _.find(selectedTalents, { 'id': t.talentRequirement.requiredTalentId });
            hasReqs = requiredTalent !== null || requiredTalent.selectedRankNo === requiredTalent.talentRanks.length;

            inspecTalent.requirementsText = !hasReqs ? t.talentRequirement.requiredTalentMessage + '<br />' : '';
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

    InspectedTalent.prototype.canBeUnlearned = function(t, selectedTalents) {
        if (t.selectedRankNo === 0)
            return false;

        var maxRow = Math.max.apply(Math, selectedTalents.map(function(t) { return t.rowIndex; }))
        if (t.rowIndex !== maxRow)
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
        this.isUnlearnable = this.canBeUnlearned(t, selectedTalents);
        this.instructionText = this.getInstructionText(t);
    }

    InspectedTalent.build = function(data, selectedTalents, totalPointsInSpec) {
        return new InspectedTalent(data, selectedTalents, totalPointsInSpec);
    }

    return InspectedTalent;
}
