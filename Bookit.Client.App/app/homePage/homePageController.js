(function() {
    'use strict';
    angular
        .module('bookit')
        .controller('HomePageController',
            ['homePageResource', homePageController]);

    function homePageController(homePageResource) {
        var vm = this;

        homePageResource.query(function (data) {

        });
    }
}());