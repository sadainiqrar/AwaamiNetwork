
var controllerId = 'invoicesController';

angular.module('DigitalMarket').controller(controllerId,
    ['$scope', '$state', '$rootScope', '$cookies', 'paymentFactory', '$mdDialog', '$mdToast', invoicesController]);

function invoicesController($scope, $state, $rootScope, $cookies, paymentFactory, $mdDialog, $mdToast) {
    $rootScope.globals = $cookies.getObject('globals') || {};

    $scope.userdata = $rootScope.globals.currentUser;
    $scope.username = $scope.userdata.fullname;
    $scope.id = $scope.userdata.email;
    $scope.ga_id = $scope.userdata.currentSite.ga_id;



    $scope.payment = [];

    paymentFactory.get_cleared_payments().then(
        // callback function for successful http request
        function success(response) {
            $scope.payment = response.data;


        },
        // callback function for error in http request
        function error(response) {
            // log errors
        }
    );




}

