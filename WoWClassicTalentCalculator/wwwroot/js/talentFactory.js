
app.factory('talentFactory', ['$http', function ($http) {
    var talentFactory = {};

    talentFactory.getClasses = function () {
        return $http.get('/api/Classes');
    };

    return talentFactory;
}]);