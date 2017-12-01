
app.controller('talentController', function ($scope, talentFactory, warcraftClassVm, warcraftClassSpecificationVm) {
    $scope.classes = [];
    $scope.selectedClassId = 0;
    $scope.selectedClass = null;

    $scope.fetchClasses = function () {
        talentFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data.map(warcraftClassVm.build);
                //$scope.fetchSpecifications($scope.classes[0].id);
                $scope.fetchSpecifications(7);

            }, function (error) {
                console.log(error);
            });
    }

    $scope.fetchSpecifications = function (id) {
        talentFactory.getSpecifications(id)
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
        var talent = _.find(talents, { 'colIndex' : index });
        return talent ? talent : null;
    }

    $scope.showTalentInfoDialog = function (event, talentId) {
        console.log("Id is: " + talentId);
    }

    $scope.fetchClasses();
});
