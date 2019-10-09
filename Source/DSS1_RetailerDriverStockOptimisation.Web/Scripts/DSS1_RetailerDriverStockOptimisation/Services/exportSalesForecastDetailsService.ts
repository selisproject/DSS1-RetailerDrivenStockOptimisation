// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS1_RetailerDriverStockOptimisation.Services {
/**
 * Client for 'exportSalesForecastDetails' Service
 */
export class exportSalesForecastDetailsServiceClient {

    /**
     * Base url for 'exportSalesForecastDetails' Service
     */
    static baseUrl = "/api/exportSalesForecastDetails/";

    /**
    *
    */
    public static ExportSalesForecastDetails(): Axios.IPromise<Axios.AxiosXHR<any>> {
        const _data = { params: {  } };
        return axios.get(window._context.siteRoot + exportSalesForecastDetailsServiceClient.baseUrl + "Export",_data);
    }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.exportSalesForecastDetails = DSS1_RetailerDriverStockOptimisation.Services.exportSalesForecastDetailsServiceClient;