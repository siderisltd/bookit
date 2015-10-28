(function() {
    'use strict';

    angular
        .module('common.services')
        .factory('categoriesResource', ['$resource', 'appSettings', categoriesResource]);
    
    function categoriesResource($resource, appSettings) {
        return $resource(appSettings.serverPath + '/api/Categories/');
    }
}());