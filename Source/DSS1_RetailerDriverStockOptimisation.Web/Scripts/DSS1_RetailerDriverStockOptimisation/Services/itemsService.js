// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'items' Service
         */
        var itemsServiceClient = /** @class */ (function () {
            function itemsServiceClient() {
            }
            /**
            * Import Items
            */
            itemsServiceClient.Import = function (items) {
                var _data = items;
                return axios.post(window._context.siteRoot + itemsServiceClient.baseUrl + "import", _data);
            };
            /**
             * Base url for 'items' Service
             */
            itemsServiceClient.baseUrl = "/api/items/";
            return itemsServiceClient;
        }());
        Services.itemsServiceClient = itemsServiceClient;
    })(Services = DSS1_RetailerDriverStockOptimisation.Services || (DSS1_RetailerDriverStockOptimisation.Services = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.items = DSS1_RetailerDriverStockOptimisation.Services.itemsServiceClient;
