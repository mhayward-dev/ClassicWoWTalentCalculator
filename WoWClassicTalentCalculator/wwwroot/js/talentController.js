
app.controller('talentController', function ($scope, talentFactory, warcraftClassVm, warcraftClassSpecificationVm) {
    $scope.isLoading = true;
    $scope.classes = [];
    $scope.selectedClassId = 0;
    $scope.selectedClass = [];

    $scope.fetchClasses = function () {
        talentFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data.map(warcraftClassVm.build);

            }, function (error) {
                console.log(error);
            });
    }

    $scope.fetchSpecifications = function (id) {
        talentFactory.getSpecifications(id)
            .then(function (response) {
                if ($scope.selectedClassId > 0) {
                    $scope.getClass($scope.selectedClassId).isSelected = false;
                }

                $scope.selectedClassId = id;
                $scope.getClass(id).isSelected = true;
                $scope.selectedClass = warcraftClassVm.build(response.data);

            }, function (error) {
                console.log(error);
            });
    }

    $scope.getClass = function (id) {
        var selectedClass = _.find($scope.classes, { 'id': id });
        if (selectedClass) return selectedClass;

        return null;
    }

    $scope.fetchClasses();
    $scope.fetchSpecifications(1);
});
