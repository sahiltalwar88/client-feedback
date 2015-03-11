"use strict";

angular.module("clientFeedbackApp").controller("clientController", ["$scope", "clientDataService", function ($scope, clientDataService) {

    $scope.clients = clientDataService.getClients();
    $scope.newClient = {};

    //TODO: put guts in data service 
    $scope.deleteClient = function (index) {
        //var numToDelete = 1;
        //$scope.clients.splice(index, numToDelete);
    }

    $scope.addClient = function () {
        //$scope.clients = clientDataService.addClient($scope.newClient, $scope.clients);
        //$scope.newClient = {};
    }

    $scope.setIsInEditMode = function (client, editMode) {
        client.isInEditMode = editMode;
    }
}]);
