(function() {
    var moduleControllers = angular.module('moduleControllers', ['appServices']);

    moduleControllers.controller('UserController', ['$scope', '$routeParams', 'User',
        function($scope, $routeParams, User) {
            $scope.user = User.get({user: $routeParams.user}, function(data) {
                $scope.user = data;
            });
        }]);

    moduleControllers.controller('RepositoryController', ['$scope', '$routeParams',
        function($scope, $routeParams) {
            console.log('phone selected');
        }]);

})();

