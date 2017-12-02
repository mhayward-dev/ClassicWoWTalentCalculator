
app.controller('talentCalculatorController', function ($scope, talentCalculatorFactory, warcraftClassVm, inspectedTalentVm) {
    $scope.classes = [];
    $scope.selectedClassId = 0;
    $scope.selectedClass = null;
    $scope.isInspectingTalent = false;
    $scope.inspectedTalent = null;
    $scope.talentInfoPos = {
        top: 0,
        left: 0
    };

    $scope.fetchClasses = function () {
        talentCalculatorFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data.map(warcraftClassVm.build);
                //$scope.fetchSpecifications($scope.classes[0].id);
                $scope.fetchSpecifications(7);

            }, function (error) {
                console.log(error);
            });
    }

    $scope.fetchSpecifications = function (id) {
        talentCalculatorFactory.getSpecifications(id)
            .then(function (response) {
                if ($scope.selectedClassId > 0) {
                    $scope.getClassById($scope.selectedClassId).isSelected = false;
                }

                $scope.getClassById(id).isSelected = true;
                $scope.selectedClassId = id;

                $scope.selectedClass = warcraftClassVm.build(response.data);

            }, function (error) {
                console.log(error);
            });
    }

    $scope.getClassById = function (id) {
        var selectedClass = _.find($scope.classes, { 'id': id });
        if (selectedClass) return selectedClass;

        return null;
    }

    $scope.getTalentByColIndex = function (index, talents) {
        var talent = _.find(talents, { 'colIndex': index });
        return talent ? talent : null;
    }

    $scope.showTalentInfo = function (event, rowIndex, colIndex) {
        console.log("entering...");
        var spec = $scope.selectedClass.specifications[0];
        var rowForTalents = spec.talentRows[rowIndex];
        var talent = $scope.getTalentByColIndex(colIndex, rowForTalents);

        $scope.inspectedTalent = inspectedTalentVm.build(talent);
        $scope.isInspectingTalent = true;

        var position = event.target.getBoundingClientRect();
        $scope.talentInfoPos.top = (position.top - 100) + "px";
        $scope.talentInfoPos.left = (position.left + 50) + "px";
    }

    $scope.hideTalentInfo = function () {
        console.log("leaving...");
        $scope.isInspectingTalent = false;
    }

    $scope.fetchClasses();
});
