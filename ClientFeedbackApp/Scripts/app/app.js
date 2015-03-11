"use strict";

angular
    .module("clientFeedbackApp", ["ngRoute"])
    .config(function ($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "Scripts/app/components/clients.view/viewClients.view.html",
                controller: "clientController"
            })
            .when("/viewClients", {
                templateUrl: "Scripts/app/components/clients.view/viewClients.view.html",
                controller: "clientController"
            })
            .otherwise({
                redirectTo: "/viewClients"
            });
    });