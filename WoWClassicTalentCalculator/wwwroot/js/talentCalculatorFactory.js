
app.factory('talentCalculatorFactory', ['$http', function ($http) {
    var talentFactory = {};

    talentFactory.getClasses = function () {
        return $http.get('/api/Classes');
    };

    talentFactory.getSpecifications = function (className) {
        return $http.get('/api/Classes/' + className);
    }

    return talentFactory;
}]);