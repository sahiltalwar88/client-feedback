"use strict";

describe("clientController", function () {
    var $scope, $controller;

    beforeEach(module("clientFeedbackApp"));

    beforeEach(inject(function (_$controller_, _$rootScope_) {
        $scope = _$rootScope_.$new();
        $controller = _$controller_("clientController", { $scope: $scope });
    }));

    it("should be defined", function () {
        //Arrange

        //Act
        var actual = $controller;

        //Assert
        expect(actual).toBeDefined();
    });

    describe("clients", function () {
        it("should be defined", function () {
            //Arrange

            //Act
            var actual = $scope.clients;

            //Assert
            expect(actual).toBeDefined();
        });
    });

    describe("new client", function () {
        it("should be defined", function () {
            //Arrange

            //Act
            var actual = $scope.newClient;

            //Assert
            expect(actual).toBeDefined();
        });
    });

    describe("delete a client", function () {
        it("should be defined", function () {
            //Arrange

            //Act
            var actual = $scope.deleteClient;

            //Assert
            expect(actual).toBeDefined();
            //});
        });

        it("should remove a client from clients", function () {
            //Arrange
            var expected = $scope.clients.length - 1;

            //Act
            $scope.deleteClient(0);
            var actual = $scope.clients.length;

            //Assert
            expect(actual).toBe(expected);
        });
    });

    describe("add a client", function () {
        it("should be defined", function () {
            //Arrange

            //Act
            var actual = $scope.addClient;

            //Assert
            expect(actual).toBeDefined();
            //});
        });

        it("should add a client to clients", function () {
            //Arrange
            var expected = $scope.clients.length + 1;

            //Act
            $scope.newClient = {
                "name": "Test Client",
                "pocName": "Test POC",
                "projectName": "Test Project",
                "quarter": "Q4",
                "date": "12/1/2014",
                "grade": "A",
                "feedback": "Good job.",
                "isInEditMode": false
            };

            $scope.addClient();
            var actual = $scope.clients.length;

            //Assert
            expect(actual).toBe(expected);

        });
    });

    describe("set edit mode", function () {
        it("should be defined", function () {
            //Arrange

            //Act
            var actual = $scope.setIsInEditMode;

            //Assert
            expect(actual).toBeDefined();
            //});
        });

        it("should set isInEditMode", function () {
            //Arrange
            var client = {
                "name": "Test Client",
                "pocName": "Test POC",
                "projectName": "Test Project",
                "quarter": "Q4",
                "date": "12/1/2014",
                "grade": "A",
                "feedback": "Good job.",
                "isInEditMode": false
            };

            var expected = true;

            //Act
            $scope.setIsInEditMode(client, true);
            var actual = client.isInEditMode;

            //Assert
            expect(actual).toEqual(expected);
            //});
        });
    });
});