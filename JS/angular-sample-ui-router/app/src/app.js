(function(app) {
    angular.module('sampleApp', [
            'ngResource',
            'ngRoute',
            'ui.router',
            'UserCtrl',
            'RepositoryCtrl',
            'ChatCtrl',
            'ui.bootstrap'
        ])
        .config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/user/SergeyDz');

            $stateProvider
                .state('area', {
                    url: '/:area/:user',
                    templateUrl: 'views/user.html',
                    controller: 'UserCtrl'
                })
                .state('area.repos', {
                    parent: 'area',
                    url: '/repos',
                    templateUrl: 'views/repository.html',
                    controller: 'RepositoryCtrl'
                })
                .state('area.chat', {
                    parent: 'area',
                    url: '/chat',
                    templateUrl: 'views/chat.html',
                    controller: 'ChatCtrl'
                })
                ;

        }]);
})(SD.App);
