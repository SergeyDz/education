(function(app) {
    angular.module('sampleApp', [
            'ngResource',
            'ngRoute',
            'ui.router',
            'UserCtrl',
            'RepositoryCtrl',
            'ui.bootstrap'
        ])
        .config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/user/SergeyDz');

            $stateProvider
                .state('user', {
                    url: '/user/:user',
                    templateUrl: 'views/user.html',
                    controller: 'UserCtrl'
                })
                .state('user.repository', {
                    parent: 'user',
                    url: '/repository',
                    templateUrl: 'views/repository.html',
                    controller: 'RepositoryCtrl'
                });

        }]);
})(SD.App);
