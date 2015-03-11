"use strict";

angular.module("clientFeedbackApp").service("clientDataService", ["$http", function ($http) {


    return {
        getClients: function () {
            var clients;

            $http.get("/api/client").then(
                function (result) {
                    //$scope.myWord = angular.copy(result.data);
                    clients = angular.copy(result.data);
                },
                function() {
                    //error
                });

            return clients;
            //return [
            //    {
            //        "name": "Client 1",
            //        "pocName": "POC 1",
            //        "projectName": "Project A",
            //        "quarter": "Q4",
            //        "date": "12/1/2014",
            //        "grade": "A",
            //        "feedback": "Everything is awesome.  Everything is cool when you're part of a team.",
            //        "isInEditMode": false
            //    },
            //    {
            //        "name": "Client 2",
            //        "pocName": "POC 2",
            //        "projectName": "Project B",
            //        "quarter": "Q1",
            //        "date": "1/15/2015",
            //        "grade": "B",
            //        "feedback": "Someone stole my red stapler!",
            //        "isInEditMode": false
            //    }
            //];
        },
        addClient: function (newClient, clients) {
            //var client = {
            //    name: newClient.name,
            //    projectName: newClient.projectName,
            //    pocName: newClient.pocName,
            //    quarter: newClient.quarter,
            //    date: newClient.date,
            //    grade: newClient.grade,
            //    feedback: newClient.feedback
            //}

            //clients.push(client);
            //return clients;
        }
    }
}]);
