(function () {
    angular
        .module('bookit')
        .controller('CategoriesController', ['categoriesResource', categoriesController]);

    function categoriesController(categoriesResource) {
        var vm = this;

        categoriesResource.query(function (data) {
            vm.categories = data;
        });
    }
}())