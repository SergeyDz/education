(function() {
    var moduleControllers = angular.module('RepositoryCtrl', ['appServices']);

    moduleControllers.controller('RepositoryCtrl', ['$scope', '$stateParams', 'Repositories',
        function($scope, $stateParams, Repositories) {
            $scope.repos = Repositories.get({
                user: $stateParams.user
            }, function(data) {
                $scope.repos = data;
            });
        }
    ]);

})();
