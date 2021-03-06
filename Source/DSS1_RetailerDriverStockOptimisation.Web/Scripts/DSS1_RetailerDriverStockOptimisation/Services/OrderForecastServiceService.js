// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var Services;
    (function (Services) {
        /**
         * Client for 'OrderForecastService' Service
         */
        var OrderForecastServiceServiceClient = /** @class */ (function () {
            function OrderForecastServiceServiceClient() {
            }
            /**
            *
            */
            OrderForecastServiceServiceClient.CalculateForSKU = function (sku) {
                var _data = { params: { sku: sku } };
                return axios.get(window._context.siteRoot + OrderForecastServiceServiceClient.baseUrl + "calculate", _data);
            };
            /**
             * Base url for 'OrderForecastService' Service
             */
            OrderForecastServiceServiceClient.baseUrl = "/api/OrderForecastService/";
            return OrderForecastServiceServiceClient;
        }());
        Services.OrderForecastServiceServiceClient = OrderForecastServiceServiceClient;
    })(Services = DSS1_RetailerDriverStockOptimisation.Services || (DSS1_RetailerDriverStockOptimisation.Services = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));
// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}
window.$api.OrderForecastService = DSS1_RetailerDriverStockOptimisation.Services.OrderForecastServiceServiceClient;
