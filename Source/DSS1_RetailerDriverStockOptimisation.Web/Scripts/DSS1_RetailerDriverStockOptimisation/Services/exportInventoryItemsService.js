// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'exportInventoryItems' Service
         */
        var exportInventoryItemsServiceClient = /** @class */ (function () {
            function exportInventoryItemsServiceClient() {
            }
            /**
            *
            */
            exportInventoryItemsServiceClient.Export = function () {
                var _data = { params: {} };
                return axios.get(window._context.siteRoot + exportInventoryItemsServiceClient.baseUrl + "Export", _data);
            };
            /**
             * Base url for 'exportInventoryItems' Service
             */
            exportInventoryItemsServiceClient.baseUrl = "/api/exportInventoryItems/";
            return exportInventoryItemsServiceClient;
        }());
        Services.exportInventoryItemsServiceClient = exportInventoryItemsServiceClient;
    })(Services = DSS1_RetailerDriverStockOptimisation.Services || (DSS1_RetailerDriverStockOptimisation.Services = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.exportInventoryItems = DSS1_RetailerDriverStockOptimisation.Services.exportInventoryItemsServiceClient;
