// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

#if NETFRAMEWORK
using Owin;

namespace DSS1_RetailerDriverStockOptimisation.Security.Owin
{
    public static class BasicAuthnMiddlewareExtensions
    {
        public static IAppBuilder UseBasicAuthentication(this IAppBuilder app, string realm, BasicAuthenticationMiddleware.CredentialValidationFunction  validationFunction)
        {
            var options = new BasicAuthenticationOptions(realm, validationFunction);
            return app.UseBasicAuthentication(options);
        }

        public static IAppBuilder UseBasicAuthentication(this IAppBuilder app, BasicAuthenticationOptions options)
        {
            return app.Use<BasicAuthenticationMiddleware>(options);
        }
    }
}
#else
#endif