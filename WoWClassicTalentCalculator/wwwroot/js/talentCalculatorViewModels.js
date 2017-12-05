
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

function inspectedTalentVm() {

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
        // TODO - Look for a relationship with TalentRequirements
        if (t.rowIndex === 1 && selectedTalents.length < 5) {
            it.requirementsText = 'Requires 5 points in ' + t.specName;
            it.isSelectable = false;
            return;
        }

        if (t.rowIndex === 2 && selectedTalents.length < 10) {
            it.requirementsText = 'Requires 10 points in ' + t.specName;
            it.isSelectable = false;
            return;
        }

        if (t.rowIndex === 3 && selectedTalents.length < 15) {
            it.requirementsText = 'Requires 15 points in ' + t.specName;
            it.isSelectable = false;
            return;
        }

        if (t.rowIndex === 4 && selectedTalents.length < 20) {
            it.requirementsText = 'Requires 20 points in ' + t.specName;
            it.isSelectable = false;
            return;
        }

        if (t.rowIndex === 5 && selectedTalents.length < 25) {
            it.requirementsText = 'Requires 25 points in ' + t.specName;
            it.isSelectable = false;
            return;
        }

        if (t.rowIndex === 6 && selectedTalents.length < 30) {
            it.requirementsText = 'Requires 30 points in ' + t.specName;
            it.isSelectable = false;
            return;
        }

        it.requirementsText = '';
        it.isSelectable = true;
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
