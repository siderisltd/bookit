(function () {
    'use strict';

    var authService = function authService($http, $q, $cookies, identity, baseUrl) {
        var TOKEN_KEY = 'authentication'; // cookie key

        var register = function register(user) {
            var defered = $q.defer();
            debugger;

            $http.post(baseUrl + 'api/account/register', user)
                .then(function() {
                    defered.resolve(true);
                    //here you can login the registered user right after registration
                }, function (error) {
                    defered.reject(error);
                });

            return defered.promise;
        }

        var login = function login(user) {
            var deferred = $q.defer();
            debugger;
            var data = "grant_type=password&username=" + (user.username || '') + '&password=' + (user.password || '');

            $http.post(baseUrl + 'Token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                .success(function (response) {
                    var tokenValue = response.access_token;

                    var expireDay = new Date();
                    expireDay.setHours(expireDay.getHours() + 100);

                    $cookies.put(TOKEN_KEY, tokenValue, { expires: expireDay });

                    $http.defaults.headers.common.Authorization = 'Bearer ' + tokenValue;

                    getIdentity().then(function () {
                        deferred.resolve(response);
                    });
                })
                .error(function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        };

        var getIdentity = function () {
            var deferred = $q.defer();

            $http.get(baseUrl + 'api/account/identity')
                .success(function (identityResponse) {
                    identity.setUser(identityResponse);
                    deferred.resolve(identityResponse);
                });

            return deferred.promise;
        };

        return {
            register: register,
            login: login,
            getIdentity: getIdentity,
            isAuthenticated: function () {
                return !!$cookies.get(TOKEN_KEY);
            },
            logout: function () {
                $cookies.remove(TOKEN_KEY);
                $http.defaults.headers.common.Authorization = null;
                identity.removeUser();
            },
        };
    };

    angular
        .module('bookitApp.services')
        .factory('auth', ['$http', '$q', '$cookies', 'identity', 'baseUrl', authService]);
}());