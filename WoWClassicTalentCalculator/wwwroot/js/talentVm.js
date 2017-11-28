
function warcraftClassVm(warcraftClassSpecificationVm) {

    function WarcraftClass(wc) {
        this.id = wc.id;
        this.className = wc.className;
        this.iconSrc = "images/class-icons/" + wc.className.toLowerCase() + "-class-icon.png";
        this.specifications = wc.specifications ? wc.specifications.map(warcraftClassSpecificationVm.build) : [];
        this.isSelected = false;
    }

    WarcraftClass.build = function (data) {
        return new WarcraftClass(data);
    }

    return WarcraftClass;
}

function warcraftClassSpecificationVm() {

    function WarcraftClassSpecification(wcs) {
        this.id = wcs.id;
        this.specName = wcs.specificationName;
        this.index = wcs.index;
    }

    WarcraftClassSpecification.build = function (data) {
        return new WarcraftClassSpecification(data);
    }

    return WarcraftClassSpecification;
}
