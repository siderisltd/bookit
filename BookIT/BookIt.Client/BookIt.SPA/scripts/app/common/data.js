(function () {
    'use strict';

    function data($http, $q, notifier, baseUrl) {

        function getErrorMessage(response) {

            var error = response.data.modelState;

            if (error && error[Object.keys(error)[0]][0]) {
                error = error[Object.keys(error)[0]][0];
            }
            else {
                error = response.data.message;
            }

            return error;
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