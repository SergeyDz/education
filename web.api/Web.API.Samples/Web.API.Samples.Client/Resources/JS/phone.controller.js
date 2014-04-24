var phoneApp = angular.module('phoneApp', []);

var phoneListController = phoneApp.controller("PhoneListConroller",
    function($scope) {
        $scope.phones = [{ 'name': 'Nokia', 'snippet': 'old' }];
    }
);