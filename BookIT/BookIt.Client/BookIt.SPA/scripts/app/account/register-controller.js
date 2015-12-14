(function () {
    "use strict";

    function RegisterController(auth, $location) {
        var vm = this;


        vm.register = function registerUser(user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                    .then(function() {
                        console.log('registered!');
                        $location.path('/account/login');
                    }, function(err) {
                        console.log(err);
                    });
            }
        }
    }

    angular.module('bookitApp.controllers')
        .controller('RegisterController', ['auth', '$location', RegisterController]);
}());