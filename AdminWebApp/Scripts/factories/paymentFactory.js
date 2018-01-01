var serviceId = 'paymentFactory';

angular.module('DigitalMarket').factory(serviceId,
    ['$http','apiUrl', paymentFactory]);

function paymentFactory($http, apiUrl) {

    function get_pending_payments() {
   
        return $http.get(apiUrl + 'api/admin/pendingpayments');
    }

    function get_cleared_payments() {

        return $http.get(apiUrl + 'api/admin/clearedpayments');
    }

    
    function clear_payment(_invoice) {
        var data = { invoice_id: _invoice};
        return $http.put(apiUrl + 'api/admin/payment/clear', data);

    }
    function make_notification(_uid, _msg) {
        var data = { uid: _uid, message: _msg, category: 'payment' };
        return $http.put(apiUrl + 'api/admin/push/notification', data);

    }


    var service = {
        get_pending_payments: get_pending_payments,
        get_cleared_payments: get_cleared_payments,
        clear_payment: clear_payment,
        make_notification: make_notification
    };

    return service;
}