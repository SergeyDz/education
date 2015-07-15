(function() {
    var moduleControllers = angular.module('UserCtrl', ['appServices']);

    moduleControllers.controller('UserCtrl', ['$scope', '$stateParams', 'User',
        function($scope, $stateParams, User) {
            $scope.user = User.get({
                user: $stateParams.user
            }, function(data) {
                $scope.user = data;
            });


            
        }
    ]);
})();
