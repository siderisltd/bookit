(function () {
    "use strict";


    var config = function config($routeProvider, $locationProvider, $httpProvider) {
        $locationProvider.html5Mode(true);

        $routeProvider
            .when('/', {
                templateUrl: '/app/homePage/homePageView.html'
            });

        $httpProvider.interceptors.push('httpResponseInterceptor');
    };

    angular.module('bookit.data', []);
    angular.module('bookit.services', []);
    angular.module('bookit.controllers', ['bookit.data', 'bookit.services']);
    angular.module('bookit.directives', []);

    var app = angular.module("bookit", ["common.services"]);

    angular.module('bookit', ['ngRoute', 'ngAnimate', 'angular-loading-bar', 'bookit.controllers', 'bookit.directives'])
        .config(['$routeProvider', '$locationProvider', '$httpProvider', config])
        .value('jQuery', jQuery)
        .value('toastr', toastr)
        .constant('appSettings', {
            serverPath: 'http://localhost:2428/api/'
        });
}());