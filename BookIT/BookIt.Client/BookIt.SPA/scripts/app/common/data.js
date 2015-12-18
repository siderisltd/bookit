(function () {
    'use strict';

    function data($http, $q, notifier, baseUrl) {

        function getErrorMessage(response) {
            return response.data.error_description;
        }

        function get(url, queryParams) {
            var defered = $q.defer();

            $http.get(baseUrl + url, { params: queryParams })
                .then(function (response) {
                    defered.resolve(response.data);
                }, function (error) {
                    error = getErrorMessage(error);
                    notifier.error(error);
                    defered.reject(error);
                });

            return defered.promise;
        }

        function post(url, postData, headers) {
            var defered = $q.defer();
            debugger;
            $http.post(baseUrl + url, postData, { headers: headers })
                .then(function (response) {
                    defered.resolve(response.data);
                }, function (error) {
                    error = getErrorMessage(error);
                    notifier.error(error);
                    defered.reject(error);
                });

            return defered.promise;
        }

        return {
            get: get,
            post: post
        };
    }

    angular.module('bookitApp.services')
        .factory('data', ['$http', '$q', 'notifier', 'baseUrl', data]);
}());