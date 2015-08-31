(function(){

    var appServices = angular.module('appServices',
        ['ngResource']
    );

    appServices.factory('User', ['$resource',
        function($resource){
            return $resource('https://api.github.com/users/:user', {}, {
                get: {method:'GET', isArray:false}
            });
        }]);

    appServices.factory('Repositories', ['$resource',
        function($resource){
            return $resource('https://api.github.com/users/:user/repos', {}, {
                get: {method:'GET', isArray:true}
            });
        }]);

})();