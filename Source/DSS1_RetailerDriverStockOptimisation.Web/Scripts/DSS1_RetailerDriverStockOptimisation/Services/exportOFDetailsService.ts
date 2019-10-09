// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS1_RetailerDriverStockOptimisation.Services {
/**
 * Client for 'exportOFDetails' Service
 */
export class exportOFDetailsServiceClient {

    /**
     * Base url for 'exportOFDetails' Service
     */
    static baseUrl = "/api/exportOFDetails/";

    /**
    *
    */
    public static ExportOFDetails(): Axios.IPromise<Axios.AxiosXHR<any>> {
        const _data = { params: {  } };
        return axios.get(window._context.siteRoot + exportOFDetailsServiceClient.baseUrl + "Export",_data);
    }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.exportOFDetails = DSS1_RetailerDriverStockOptimisation.Services.exportOFDetailsServiceClient;