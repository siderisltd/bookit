(function () {
    "use strict";

    function LoginController(auth, $location) {
        var vm = this;

        vm.login = function (user, loginForm) {
            debugger;
            if (loginForm.$valid) {
                auth.login(user)
                    .then(function() {
                        //TODO: save the last url and reroute to it when user logs in
                        console.log('Loged in');
                        $location.path('/');
                    });
            }
        }
    }

    angular.module('bookitApp.controllers')
        .controller('LoginController', ['auth', '$location', LoginController]);
}());