
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
        this.talentRows = wcs.talentRows.length > 0 ? wcs.talentRows.map(talents => talents.map(talentVm.build)) : [];
    }

    WarcraftClassSpecification.build = function (data) {
        return new WarcraftClassSpecification(data);
    }

    return WarcraftClassSpecification;
}

function talentVm(talentRankVm) {

    function Talent(t) {
        this.id = t.id;
        this.talentName = t.talentName;
        this.colIndex = t.columnIndex;
        this.rowIndex = t.rowIndex;
        this.iconFilePath = t.iconFilePath;
        this.talentRanks = t.talentRanks.map(talentRankVm.build);
        this.selectedRankNo = 0;
    }

    Talent.build = function (data) {
        return new Talent(data);
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

    function InspectedTalent(t) {
        var currentRank = t.selectedRankNo > 0 ? _.find(t.talentRanks, { 'rankNo': t.selectedRankNo }) : null;
        var nextRank = t.selectedRankNo < t.talentRanks.length ? _.find(t.talentRanks, { 'rankNo': t.selectedRankNo + 1 }) : null;

        this.id = t.id;
        this.name = t.talentName;
        this.currentRankNo = t.selectedRankNo;
        this.totalRankNo = t.talentRanks.length;
        this.isMaxRank = t.selectedRankNo === t.talentRanks.length;
        this.description = getCurrentRankText(t);
        this.nextRankText = getNextRankText(t);
        this.requirementText = "";
        this.instructionText = getRankInstruction(t);
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

    function getRankInstruction(t) {
        if (t.selectedRankNo === 0) {
            return 'Click to learn'
        }

        if (t.selectedRankNo === t.talentRanks.length) {
            return 'Right click to unlearn'
        }

        return '';
    }

    InspectedTalent.UpdateRankNo = function (newRankNo) {
        this.currentRankNo = newRankNo;
        this.rankText = getCurrentRankText(t);
        this.nextRankText = getNextRankText(t);
        this.isMaxRank = t.selectedRankNo === t.talentRanks.length;
    }

    InspectedTalent.build = function (data) {
        return new InspectedTalent(data);
    }

    return InspectedTalent;
}
