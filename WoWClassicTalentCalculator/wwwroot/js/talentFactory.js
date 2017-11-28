
app.factory('talentFactory', ['$http', function ($http) {
    var talentFactory = {};

    talentFactory.getClasses = function () {
        return $http.get('/api/Classes');
    };

    talentFactory.getSpecifications = function (id) {
        return $http.get('/api/Classes/' + id)
    }

    return talentFactory;
}]);