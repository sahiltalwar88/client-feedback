"use strict";

angular.module("clientFeedbackApp").service("clientDataService", ["$http", function ($http) {

    var getClients = function() {
        var clients = [];

        $http.get("client/get").
            success(function(data) {
                angular.copy(data, clients);
            }).
            error(function() {
                //error
                console.log("get clients error");
        });

        return clients;
    };

    var addClient = function (newClient, clients) {
        var addedClient = {};
        var myClients = clients;

        $http.post("client/add", newClient).
            success(function(data) {
                addedClient = angular.copy(data);
                myClients.push(addedClient);
            }).
            error(function() {
                //error
                console.log("add client error");
            });

        return myClients;
    };

    var deleteClient = function (clientToBeDeleted, clients) {
        var myClients = clients;
        var deletedClient = clientToBeDeleted;

        $http.post("/api/client/delete/" + deletedClient.Id).
            success(function(data) {
                myClients = data;
            }).
            error(function() {
                //error
                console.log("delete client error");
            });

        return myClients;
    };

    var editClient = function(clientToBeEdited, clients) {
        var editedClient = clientToBeEdited;
        var myClients = clients;

        $http.post("/api/client/edit", editedClient)
            .success(function(data) {
                myClients = data;
            })
            .error(function() {

            });

        return myClients;
    };

    return {
        getClients: getClients,
        addClient: addClient,
        deleteClient: deleteClient,
        editClient: editClient
    }
}]);
