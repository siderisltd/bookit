//application start point
(function () {
    "use strict";


    function config($routeProvider, $locationProvider) {

        var CONTROLLER_VIEW_MODEL_NAME = 'vm';

        //$locationProvider.html5Mode(true);
        debugger;
        $routeProvider
            .when('/', {
                templateUrl: 'partials/home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/info/about-us', {
                templateUrl: 'partials/info/about-us.html',
                controller: 'AboutUsController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/info/our-mission', {
                templateUrl: 'partials/info/our-mission.html',
                controller: 'OurMissionController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/info/community', {
                templateUrl: 'partials/info/community.html',
                controller: 'CommunityController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/info/covered-area', {
                templateUrl: 'partials/info/covered-area.html',
                controller: 'CoveredAreaController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/account/login', {
                templateUrl: 'partials/account/login.html',
                controller: 'LoginController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/account/register', {
                templateUrl: 'partials/account/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .otherwise({ templateUrl: 'partials/error/not-found.html' });
    }


    function run(auth, $cookies, $http) {

        //if someone throw not authorized to redirect to home
        //($rootScope, $location, auth, notifier)

        //$rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
        //    if (rejection === 'not authorized') {
        //        notifier.warning('Please log into your account first!');
        //        $location.path('/');
        //        angular
        //            .element('#open-login-btn')
        //            .trigger('click');

        //        angular.element('#login-modal')
        //            .attr('data-previous-route', previous.$$route.originalPath)
        //            .attr('data-current-route', current.$$route.originalPath);
        //    }
        //});

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity()
                .then(function (identity) {
            });
        }
    };


    angular.module('bookitApp.services', []);
    angular.module('bookitApp.controllers', ['bookitApp.services']);

    angular
        .module('bookitApp', ['ngRoute', 'ngCookies', 'bookitApp.controllers'])
        .config(['$routeProvider', config])
        .run(['auth', '$cookies', '$http', run])
        .constant('baseUrl', 'http://localhost:1715/');

}());