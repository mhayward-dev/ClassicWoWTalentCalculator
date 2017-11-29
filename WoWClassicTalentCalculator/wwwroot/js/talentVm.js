
function warcraftClassVm(warcraftClassSpecificationVm) {

    function WarcraftClass(wc) {
        this.id = wc.id;
        this.className = wc.className;
        this.iconSrc = "images/class-icons/" + wc.className.toLowerCase() + "-class-icon.png";
        this.specifications = wc.specifications ?
            wc.specifications.map(warcraftClassSpecificationVm.build, { className: wc.className }) : [];
        this.isSelected = false;
    }

    WarcraftClass.build = function (data) {
        return new WarcraftClass(data);
    }

    return WarcraftClass;
}

function warcraftClassSpecificationVm() {

    function WarcraftClassSpecification(wcs, className) {
        this.id = wcs.id;
        this.specName = wcs.specificationName;
        this.index = wcs.specificationIndex;
        this.bgImage = "images/specification-backgrounds/" +
                       _.kebabCase(className + "-" + wcs.specificationName) + "-bg.jpg";
    }

    WarcraftClassSpecification.build = function (data) {
        return new WarcraftClassSpecification(data, this.className);
    }

    return WarcraftClassSpecification;
}
