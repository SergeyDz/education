(function(){

    var appServices = angular.module('appServices',
        ['ngResource']
    );

    appServices.factory('User', ['$resource',
        function($resource){
            return $resource('https://api.github.com/users/:userName', {}, {
                get: {method:'GET', params:{userName:'SergeyDz'}, isArray:false}
            });
        }]);

})();