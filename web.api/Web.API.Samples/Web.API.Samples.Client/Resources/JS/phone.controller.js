var phoneApp = angular.module('phoneApp', []);

var phoneListController = phoneApp.controller("PhoneListConroller",
    function($scope) {
        $scope.phones = [
            { 'name': 'Nokia', 'snippet': 'Finnish oldest mobile company' },
            { 'name': 'Apple', 'snippet': 'USA quality' },
            { 'name': 'Motorolla', 'snippet': 'USA first mobiles' },
            { 'name': 'HTC', 'snippet': 'Malaysya' },
        ];

        $scope.orderProp = 'name';
        $scope.query = 'Apple';
    }
);