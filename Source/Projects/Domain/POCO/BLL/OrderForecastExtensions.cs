
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DSS1_RetailerDriverStockOptimisation.DAL;

namespace DSS1_RetailerDriverStockOptimisation.BO
{
	/// <summary>
	/// The OrderForecast extensions
	/// </summary>
	public static class OrderForecastExtensions
	{
        public static DSS1_RetailerDriverStockOptimisation.BO.OrderForecast CopyOrderForecastToNew(this BO.OrderForecast @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("OrderForecast", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CopyOrderForecastToNew")) {
DSS1_RetailerDriverStockOptimisation.BO.OrderForecast orderF = @this?.Copy(false, null,  true);
orderF.CreatedBy = zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentUserName();orderF.CreatedOn = DateTime.UtcNow;orderF.Status = "New";orderF.State = "Recalculated";orderF.SalesForecast = @this?.SalesForecast;return orderF;
}
}



        
	}
}