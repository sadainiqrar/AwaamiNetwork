var controllerId = 'paymentController';

angular.module('DigitalMarket').controller(controllerId,
    ['$scope', '$state', '$rootScope', '$cookies', 'paymentFactory', '$mdDialog','$mdToast', paymentController]);

function paymentController($scope, $state, $rootScope, $cookies, paymentFactory, $mdDialog, $mdToast) {
    $rootScope.globals = $cookies.getObject('globals') || {};

    $scope.userdata = $rootScope.globals.currentUser;
    $scope.username = $scope.userdata.fullname;
    $scope.id = $scope.userdata.email;
    $scope.ga_id = $scope.userdata.currentSite.ga_id;



    $scope.payment = [];

    paymentFactory.get_pending_payments().then(
        // callback function for successful http request
        function success(response) {
            $scope.payment = response.data;


        },
        // callback function for error in http request
        function error(response) {
            // log errors
        }
    );
    $scope.clearPayment = function (ev) {

        var invoice = this.h.invoice_id;
        $mdDialog.show({
            locals: { data: "Invoice #" + invoice },
            controller: confirmDialogController,
            templateUrl: 'confirmmessage.tmpl.html',
            parent: angular.element(document.body),
            targetEvent: ev,
            clickOutsideToClose: true
        })
            .then(function (answer) {
                if (answer === "Submited") {
                    paymentFactory.clear_payment(invoice).then(
                        // callback function for successful http request
                        function success(response) {
                            $mdToast.show(
                                $mdToast.simple()
                                    .textContent('Payment Cleared')
                                    .action('CLOSE')
                                    .position('bottom left')
                                    .theme('success-toast')
                                    .hideDelay(3000)
                            );
                            paymentFactory.get_pending_payments().then(
                                // callback function for successful http request
                                function success(response) {
                                    $scope.payment = response.data;


                                },
                                // callback function for error in http request
                                function error(response) {
                                    // log errors
                                }
                            );


                        },
                        // callback function for error in http request
                        function error(response) {
                            // log errors
                        }
                    );
                }
            }, function () {

            });




        
    }





    function confirmDialogController($scope, $mdDialog, data) {
        $scope.Response = data;
        $scope.answer = function () {
            $mdDialog.hide("Submited");
        };
        $scope.cancel = function () {
            $mdDialog.cancel();
        };

    }

   


}

angular.module('DigitalMarket').filter('dateFilter', function () {
    return function (items, fromDate, toDate) {
        var filtered = [];
        var from_date = Date.parse(fromDate);
        var to_date = Date.parse(toDate);
        // If time is with the range
        angular.forEach(items, function (value, key) {
            if (Date.parse(value.payment_date) >= from_date && Date.parse(value.payment_date) <= to_date) {
                filtered.push(value);
            }
        });
        return filtered;
    };
});