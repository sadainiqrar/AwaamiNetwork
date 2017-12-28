var serviceId = 'singleArticleFactory';

angular.module('DigitalMarket').factory(serviceId,
    ['$http','apiUrl', singleArticleFactory]);

function singleArticleFactory($http, apiUrl) {

    function getArticle(_serial) {
        return $http.get(apiUrl + 'api/user/article/' + _serial);
    }

    
    function getUsers() {
        return $http.get(apiUrl + 'api/admin/pendingusers');
    }

    function verifyUser(_uid) {
        var data = {uid: _uid}
        return $http.post(apiUrl + 'api/admin/updateuser', data);
    }
    

    var service = {
        getArticle: getArticle,
        getUsers: getUsers,
        verifyUser: verifyUser


    };

    return service;
}

