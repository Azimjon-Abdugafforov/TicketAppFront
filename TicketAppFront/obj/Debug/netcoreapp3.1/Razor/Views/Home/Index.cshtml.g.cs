#pragma checksum "C:\Users\acer\source\repos\TicketAppFront\TicketAppFront\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b4d36e3ad9938fb98b47238c50553315073834b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\acer\source\repos\TicketAppFront\TicketAppFront\Views\_ViewImports.cshtml"
using TicketAppFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\source\repos\TicketAppFront\TicketAppFront\Views\_ViewImports.cshtml"
using TicketAppFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4d36e3ad9938fb98b47238c50553315073834b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0942997bdff9cf8b37f31995ab6fb3a817fc9990", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\acer\source\repos\TicketAppFront\TicketAppFront\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div ng-app=""WorkshopSPA"">
    <div ng-view></div>
</div>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular-route.min.js""></script>
<script type=""text/javascript"">
        // Creating a Module to use within index page
    var baseURL = 'https://localhost:44303/api/'
        angular
            .module('WorkshopSPA', ['ngRoute'])
            .config(function ($routeProvider) {
                $routeProvider
                    .when('/',
                        {
                            templateUrl: 'pages/index.html',
                            controller: 'IndexController'
                        })
                    .when('/create',
                        {
                            templateUrl: 'pages/create.html',
                            controller: 'CreateController'
                        })
            ");
            WriteLiteral(@"        .when('/details/:orderId',
                       {
                            templateUrl: 'pages/details.html',
                            controller: 'DetailsController'
                        })

                    .when('/edit/:orderId',
                        {
                            templateUrl: 'pages/edit.html',
                            controller: 'EditDeleteController'
                        })
                    .otherwise({
                        redirectTo: '/'
                    });

            })
            .controller('IndexController', ['$scope', '$http', function ($scope, $http)
            {
                var config = {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                };
                $scope.orders = [];
                $http.get('https://localhost:44303/api/tickets', config)
                    .then(function (res) {

                        $scope.order");
            WriteLiteral(@"s = res.data;
                    })
            }])
            .controller('CreateController', ['$scope', '$http','$location', function ($scope, $http, $location)
            {
                $scope.ticket =
                    {
                        ID : 0,
                        title: '',
                        actors: null,
                        description : '',
                        createdAt : '',
                        updatedAt :'',
                        status: ''
                    };
                $scope.AddTicket = function()
                {
                    $http.post('https://localhost:44303/api/tickets/', $scope.ticket)
                        .then(function (res)
                        {
                            $location.path('/')
                        });
                }

            }])
            .controller('DetailsController', ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams)
            {
              ");
            WriteLiteral(@"  $scope.details = [];

                $http.get('https://localhost:44303/api/tickets/' + $routeParams.orderId)
                    .then(function (res)
                    {
                        $scope.details = res.data;
                    });

            }])
            .controller('EditDeleteController', ['$scope', '$http','$location', '$routeParams', function ($scope, $http, $location, $routeParams)
            {
                $scope.edit = [];

                $http.get('https://localhost:44303/api/tickets/' + $routeParams.orderId)
                    .then(function (res)
                    {
                        $scope.edit = res.data;
                    });

                $scope.Edit = function () {
                    $http.put('https://localhost:44303/api/tickets/' + $routeParams.orderId, $scope.edit)
                        .then(function (res) {
                            $location.path('/');
                        });
                };
                $s");
            WriteLiteral(@"cope.Delete = function () {
                    $http.delete('https://localhost:44303/api/tickets/' + $routeParams.orderId, $scope.edit)
                        .then(function (res) {
                            $location.path('/');
                        });
                };

            }]);
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
