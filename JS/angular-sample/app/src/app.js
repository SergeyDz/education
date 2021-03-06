(function() {
    angular.module('sampleApp',
        [
            'ngResource',
            'ngRoute',
            'moduleControllers',
            'appServices',
            'ui.bootstrap'
        ]
    )
        .config(['$routeProvider', '$parseProvider', function($routeProvider, $parseProvider){
            $routeProvider.
                when('/user/:user', {
                    templateUrl: 'views/user.html',
                    controller: 'UserController'
                }).
                when('/user/:user/repository', {
                    templateUrl: 'views/repository.html',
                    controller: 'RepositoryController'
                }).
                otherwise({
                    redirectTo: '/user/SergeyDz'
                });

            //this line allow to use promises as ng-optionn attribute. Sine 1.2 this feature was disabled. This line enable it.
            $parseProvider.unwrapPromises(true);

        }]);
})();
