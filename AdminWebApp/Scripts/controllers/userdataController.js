


var controllerId = 'userdataController';

angular.module('DigitalMarket').controller(controllerId,
    ['$scope', '$state', '$rootScope', '$cookies', 'singleArticleFactory', '$mdDialog', '$mdToast', userdataController]);

function userdataController($scope, $state, $rootScope, $cookies, singleArticleFactory, $mdDialog, $mdToast) {
    $rootScope.globals = $cookies.getObject('globals') || {};

    $scope.userdata = $rootScope.globals.currentUser;
    $scope.username = $scope.userdata.fullname;
    $scope.id = $scope.userdata.email;
    $scope.ga_id = $scope.userdata.currentSite.ga_id;



    $scope.users = [];

    singleArticleFactory.getUsers().then(
        // callback function for successful http request
        function success(response) {
            $scope.users = response.data;


        },
        // callback function for error in http request
        function error(response) {
            // log errors
        }
    );
    $scope.verifyUsers = function (ev) {

        var user = this.user;
        $mdDialog.show({
            locals: { data: "Verify User:" + user.fullname },
            controller: confirmDialogController,
            templateUrl: 'confirmmessage.tmpl.html',
            parent: angular.element(document.body),
            targetEvent: ev,
            clickOutsideToClose: true
        })
            .then(function (answer) {
                if (answer === "Submited") {
                    singleArticleFactory.verifyUser(user.uid).then(
                        // callback function for successful http request
                        function success(response) {
                            $mdToast.show(
                                $mdToast.simple()
                                    .textContent('User Verified')
                                    .action('CLOSE')
                                    .position('bottom left')
                                    .theme('success-toast')
                                    .hideDelay(3000)
                            );
                            singleArticleFactory.getUsers().then(
                                // callback function for successful http request
                                function success(response) {
                                    $scope.users = response.data;


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
