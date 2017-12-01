
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
        this.rankNo = t.selectedRankNo;
        this.totalRanks = t.talentRanks.length;
        this.rankText = currentRank ? currentRank.rankDescription : t.talentRanks[0].rankDescription;
        this.nextRankText = nextRank ? nextRank.rankDescription : null;
        this.isMaxed = t.selectedRankNo === t.talentRanks.length;
    }

    InspectedTalent.build = function (data) {
        return new InspectedTalent(data);
    }

    return InspectedTalent;
}
