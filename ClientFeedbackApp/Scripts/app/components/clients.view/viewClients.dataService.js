"use strict";

angular.module("clientFeedbackApp").service("clientDataService", ["$http", function ($http) {

    var getClients = function() {
        var clients = [];

        $http.get("/api/client").
            success(function(data) {
                //clients = angular.copy(result.data);
                angular.copy(data, clients);
            }).
            error(function() {
                //error
                console.log("get clientts error");
        });

        return clients;
    };

    var addClient = function (newClient, clients) {
        var addedClient = {};
        var myClients = clients;

        $http.post("/api/client", newClient).//then(
            success(function(data) {
                addedClient = angular.copy(data);
                myClients.push(addedClient);
                //$window.location
            }).
            error(function() {
                //error
                console.log("add clients error");
            });

        return myClients;
    };

    var deleteClient = function (clientToBeDeleted, clients) {


        //var numToDelete = 1;
        //$scope.clients.splice(index, numToDelete);
    }

    return {
        getClients: getClients,
        addClient: addClient
    }
}]);
