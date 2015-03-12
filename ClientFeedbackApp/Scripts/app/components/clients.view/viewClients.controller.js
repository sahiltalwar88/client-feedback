"use strict";

angular.module("clientFeedbackApp").controller("clientController", ["$scope", "clientDataService", function ($scope, clientDataService) {

    $scope.clients = clientDataService.getClients();
    $scope.newClient = {};

    $scope.deleteClient = function (client) {
        $scope.clients = clientDataService.deleteClient(client, $scope.clients);
    }

    $scope.addClient = function () {
        $scope.clients = clientDataService.addClient($scope.newClient, $scope.clients);
        $scope.newClient = {};
    }

    $scope.setIsInEditMode = function (client, editMode) {
        client.isInEditMode = editMode;

        if (!editMode) {
            $scope.clients = clientDataService.editClient(client, $scope.clients);
        }
    }
}]);
