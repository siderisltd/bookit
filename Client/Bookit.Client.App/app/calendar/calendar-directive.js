(function () {
    'use strict';

    var calendar = function calendar() {
        return {
            restrict: 'A',
            templateUrl: '/app/calndar/calendar-directice.html',
            scope: {

            }
        }
    };

    angular
        .module('bookit.directives')
        .directive('calendar', [calendar]);
}());