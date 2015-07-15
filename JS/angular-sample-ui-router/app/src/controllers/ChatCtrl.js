(function() {
    var moduleControllers = angular.module('ChatCtrl', ['appServices']);

    moduleControllers.controller('ChatCtrl', ['$scope', '$stateParams', 'Chat',
        function($scope, $stateParams, Chat) {
            $scope.message = 'Hello world';
        }
    ]);

})();
