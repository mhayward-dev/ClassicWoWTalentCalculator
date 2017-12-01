
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

function warcraftClassSpecificationVm(talentRowVm) {

    function WarcraftClassSpecification(wcs, className) {
        this.id = wcs.id;
        this.specName = wcs.specificationName;
        this.index = wcs.specificationIndex;
        this.bgImageFilePath = wcs.bgImageFilePath;
        this.talentRows = wcs.talentRows.length > 0 ? wcs.talentRows.map(talents => talents.map(talentRowVm.build)) : [];
    }

    WarcraftClassSpecification.build = function (data) {
        return new WarcraftClassSpecification(data);
    }

    return WarcraftClassSpecification;
}

function talentRowVm() {

    function Talent(t) {
        this.id = t.id;
        this.talentName = t.talentName;
        this.colIndex = t.columnIndex;
        this.rowIndex = t.rowIndex;
        this.iconFilePath = t.iconFilePath;
        this.talentRanks = t.talentRanks;
    }

    Talent.build = function (data) {
        return new Talent(data);
    }

    return Talent;
}
