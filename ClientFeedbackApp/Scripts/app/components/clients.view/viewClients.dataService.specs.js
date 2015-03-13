"use strict";

describe("clientDataService", function () {
    var $scope, $controller, clientDataService;

    beforeEach(module("clientFeedbackApp"));

    beforeEach(inject(function (_$controller_, _$rootScope_, _clientDataService_) {
        $scope = _$rootScope_.$new();
        $controller = _$controller_("clientController", { $scope: $scope });
        clientDataService = _clientDataService_;
    }));

    it("should be defined ", function () {
        //Arrange

        //Act
        var actual = clientDataService;

        //Assert
        expect(actual).toBeDefined();
    });

    describe("get clients", function () {
        it("should be defined", function () {
            //Arrange

            //Act
            var actual = clientDataService.getClients();

            //Assert
            expect(actual).toBeDefined();
        });
    });

    describe("add a client", function () {
        it("should be defined", function () {
            //Arrange
            var newClient = {};
            var clients = [];

            //Act
            var actual = clientDataService.addClient(newClient, clients);

            //Assert
            expect(actual).toBeDefined();
        });
    });
});