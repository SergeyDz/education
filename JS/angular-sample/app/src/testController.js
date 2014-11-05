(function() {
    var moduleControllers = angular.module('moduleControllers', []);

    moduleControllers.controller('UserController', ['$scope', '$routeParams',
        function($scope, $routeParams) {
            console.log('user data requested');
        }]);

    moduleControllers.controller('RepositoryController', ['$scope', '$routeParams',
        function($scope, $routeParams) {
            console.log('phone selected');
        }]);

})();

