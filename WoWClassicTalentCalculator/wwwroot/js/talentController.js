
app.controller('talentController', ['$scope', 'talentFactory', function ($scope, talentFactory) {
    $scope.isLoading = true;
    $scope.classes = [];

    $scope.getClasses = function () {
        talentFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data
            }, function (error) {
                console.log(error);
            });
    }

    $scope.getIconFileName = function (className) {
        return "images/class-icons/" + className.toLowerCase() + "-class-icon.png";
    }

    $scope.getClasses();
}]);
