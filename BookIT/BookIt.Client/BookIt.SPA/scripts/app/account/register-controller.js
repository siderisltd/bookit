(function () {
    "use strict";

    function RegisterController(auth, $location, notifier) {
        var vm = this;


        vm.register = function registerUser(user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                    .then(function() {
                        notifier.success('User registered!');
                        $location.path('/account/login');
                    }, function(err) {
                        notifier.error(err);
                    });
            }
        }
    }


    angular.module('bookitApp.controllers')
        .controller('RegisterController', ['auth', '$location', 'notifier', RegisterController]);
}());

