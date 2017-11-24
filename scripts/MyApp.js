var app = angular.module('MyApp', []);
app.controller('menuController', ['$scope', '$http', function ($scope, $http) {
    $scope.SiteMenu = [];    
    $http.get('http://localhost:59609/api/menu/GetMainMenu').then(function (data) {
        console.log()
        $scope.SiteMenu = data.data.Data;
    }, function (error) {
        alert('Error');
    })
    $scope.status = {
        isopen: false
    };

    $scope.toggled = function (open) {
        $log.log('Dropdown is now: ', open);
    };

    $scope.toggleDropdown = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();
        $scope.status.isopen = !$scope.status.isopen;
    };
}])