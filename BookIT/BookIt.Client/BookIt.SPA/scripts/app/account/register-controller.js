(function () {
    "use strict";

    function RegisterController(auth, $location, $timeout, notifier) {
        var vm = this,
            numberOfFields = $('.forms li').length,
            updateValue = 100 / numberOfFields;

        vm.status = "Completed profile status";

        
        vm.changeInput = function () {
            var totalUpdate = 0;
            $(".forms input, .forms option:selected").each(function () {
                if (this.value !== "") {
                    //for select -> Default value is not count-able
                    var isOptionElement = $(this).is("option");

                    if (isOptionElement && ((this.value !== 'Default') && this.value !== '? undefined:undefined ?')) {
                        totalUpdate += updateValue;
                    } else if (!isOptionElement) {
                        totalUpdate += updateValue;
                    } 
                } 
            });
            vm.progress = totalUpdate;
        };


        vm.registerUser = function registerUser(user, registerUserForm) {
            if (registerUserForm.$valid) {
                auth.register(user)
                    .then(function() {
                        notifier.success('User registered!');
                        $location.path('/account/login');
                    }, function(err) {
                        notifier.error('Internal user registration problem');
                    });
            }
        }

        vm.registerCompany = function registerCompany(user, registerCompanyForm) {
            if (registerCompanyForm.$valid) {
                auth.register(user)
                    .then(function() {
                        notifier.success('Company registered!');
                        $location.path('/account/login');
                    }, function(err) {
                        notifier.error('Internal company registration problem');
                        $location.path('/account/login');
                    });
            }
        
        }
    }


    angular.module('bookitApp.controllers')
        .controller('RegisterController', ['auth', '$location', '$timeout', 'notifier', RegisterController]);
}());

