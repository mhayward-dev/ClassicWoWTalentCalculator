
app.controller('talentCalculatorController', function ($scope, $timeout, talentCalculatorFactory, warcraftClassVm, inspectedTalentVm) {
    $scope.classes = [];
    $scope.selectedClassId = 0;
    $scope.selectedClass = null;
    $scope.isInspectingTalent = false;
    $scope.inspectedTalent = null;
    $scope.talentInfoStyle = {
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
        var spec = $scope.selectedClass.specifications[0];
        var rowForTalents = spec.talentRows[rowIndex];
        var talent = $scope.getTalentByColIndex(colIndex, rowForTalents);

        $scope.inspectedTalent = inspectedTalentVm.build(talent);
        $scope.isInspectingTalent = true;

        $timeout(function () {
            var iconPos = event.target.getBoundingClientRect();
            var tooltipHeight = angular.element('#talent-tooltip').height();
            var yBuffer = iconPos.top - tooltipHeight - 5;

            $scope.talentInfoStyle.top = yBuffer + "px";
            $scope.talentInfoStyle.left = (iconPos.left + 45) + "px";
        }, 20);
    }

    $scope.hideTalentInfo = function () {
        $scope.isInspectingTalent = false;
    }

    $scope.fetchClasses();
});
