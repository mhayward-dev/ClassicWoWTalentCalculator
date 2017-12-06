
function warcraftClassVm(warcraftClassSpecificationVm) {

    function WarcraftClass(wc) {
        this.id = wc.id;
        this.className = wc.className;
        this.iconFilePath = wc.iconFilePath;
        this.specifications = wc.specifications ? wc.specifications.map(warcraftClassSpecificationVm.build) : [];
        this.isSelected = false;
    }

    WarcraftClass.build = function (data) {
        return new WarcraftClass(data);
    }

    return WarcraftClass;
}

function warcraftClassSpecificationVm(talentVm) {

    function WarcraftClassSpecification(wcs, className) {
        this.id = wcs.id;
        this.specName = wcs.specificationName;
        this.index = wcs.specificationIndex;
        this.bgImageFilePath = wcs.bgImageFilePath;
        this.talentRows = wcs.talentRows.length > 0 ? wcs.talentRows.map(talents => talents.map(talentVm.build, {
            spec: wcs
        })) : [];
    }

    WarcraftClassSpecification.build = function (data) {
        return new WarcraftClassSpecification(data);
    }

    return WarcraftClassSpecification;
}

function talentVm(talentRankVm) {

    function Talent(t, spec) {
        this.id = t.id;
        this.talentName = t.talentName;
        this.specName = spec.specificationName;
        this.specIndex = spec.specificationIndex;
        this.colIndex = t.columnIndex;
        this.rowIndex = t.rowIndex;
        this.iconFilePath = t.iconFilePath;
        this.talentRanks = t.talentRanks.map(talentRankVm.build);
        this.selectedRankNo = 0;
        this.isActive = t.rowIndex === 0;
    }

    Talent.build = function (data) {
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

    TalentRank.build = function (data) {
        return new TalentRank(data);
    }

    return TalentRank;
}

function talentReqVm() {
    this.reqArray =  [
        { rowIndex: 1, requiredNo: 5 },
        { rowIndex: 2, requiredNo: 10 },
        { rowIndex: 3, requiredNo: 15 },
        { rowIndex: 4, requiredNo: 20 },
        { rowIndex: 5, requiredNo: 25 },
        { rowIndex: 6, requiredNo: 30 }
    ];

    return this;
}

function inspectedTalentVm(talentReqVm) {

    function InspectedTalent(t, selectedTalents) {
        var currentRank = t.selectedRankNo > 0 ? _.find(t.talentRanks, { 'rankNo': t.selectedRankNo }) : null;
        var nextRank = t.selectedRankNo < t.talentRanks.length ? _.find(t.talentRanks, { 'rankNo': t.selectedRankNo + 1 }) : null;

        this.id = t.id;
        this.name = t.talentName;
        this.selectedRankNo = t.selectedRankNo;
        this.totalRankNo = t.talentRanks.length;
        this.isMaxRank = t.selectedRankNo === t.talentRanks.length;
        this.selectedRankText = getCurrentRankText(t);
        this.nextRankText = getNextRankText(t);
        this.instructionText = getInstructionText(t);
        this.requirementsText = '';
        this.isLearnable = true;
        this.isUnlearnable = t.selectedRankNo > 0;

        checkIsLearnable(this, t, selectedTalents);
    }

    function getCurrentRankText(t) {
        if (t.selectedRankNo > 0) {
            return _.find(t.talentRanks, { 'rankNo': t.selectedRankNo }).rankDescription;
        }

        return t.talentRanks[0].rankDescription;
    }

    function getNextRankText(t) {
        if (t.selectedRankNo < t.talentRanks.length) {
            return _.find(t.talentRanks, { 'rankNo': t.selectedRankNo + 1 }).rankDescription;
        }

        return "";
    }

    function checkIsLearnable(it, t, selectedTalents) {
        var isLearnable = true;

        angular.forEach(talentReqVm.reqArray, function (req) {
            if (t.rowIndex === req.rowIndex && selectedTalents.length < req.requiredNo) {
                it.requirementsText = sprintf('Requires %s points in %s', req.requiredNo, t.specName);
                it.isSelectable = false;
                isLearnable = false;
                return;
            }
        });

        // TODO - Look for a relationship with TalentRequirements

        if (isLearnable) {
            it.requirementsText = '';
            it.isSelectable = true;
        }
    }

    function getInstructionText(t) {
        if (t.isActive && t.selectedRankNo === 0) {
            return 'Click to learn'
        }

        if (t.isActive && t.selectedRankNo === t.talentRanks.length) {
            return 'Right click to unlearn'
        }

        return '';
    }

    InspectedTalent.updateRankNo = function (it, t) {
        it.selectedRankNo = t.selectedRankNo;
        it.selectedRankText = getCurrentRankText(t);
        it.nextRankText = getNextRankText(t);
        it.instructionText = getInstructionText(t);
        it.isMaxRank = t.selectedRankNo === t.talentRanks.length;
    }

    InspectedTalent.build = function (data, selectedTalents) {
        return new InspectedTalent(data, selectedTalents);
    }

    return InspectedTalent;
}
