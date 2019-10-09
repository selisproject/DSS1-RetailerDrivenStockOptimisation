// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.BoTesting.Tests.Common;
using DSS1_RetailerDriverStockOptimisation.DAL;

namespace DSS1_RetailerDriverStockOptimisation.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for OrderForecastTest and is intended
    ///to contain all OrderForecastTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("OrderForecast Repository Tests")]
    [Category("OrderForecast Repository Tests")]
    internal class OrderForecastTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `OrderForecast`")]
        [Order(0)]
        public void OrderForecast_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _orderproposal_orderforecastdetails_orderforecast = new DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails
            {
                ReplenishmentCycle = 8070,
                AutomatedForecast = 3282,
                Quantity = 2222222222.22222M,
                RoundQuantity = 3538,
                OrderInventoryDays = 2222222222.22222M,
                RecommendedOrderDate = now,
                SalesForecastDate = now,
                SupplierCanDeliver = true,
                SupplierMaxQuantity = 2222222222.22222M,
                SupplierCoverageDays = 3462,
                ItemCoverageDays = 8750,
                InitialStockLevel = 1660,
                SupplierAvailableQuantity = 3781,
                SupplierSharesStock = true,
                CreatedOn = now,
                Status = "OrderForecastDetails_Status",
            };
            var _orderproposal_orderforecastdetails_orderforecast2 = new DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails
            {
                ReplenishmentCycle = 2590,
                AutomatedForecast = 8073,
                Quantity = 2222222222.22222M,
                RoundQuantity = 7556,
                OrderInventoryDays = 2222222222.22222M,
                RecommendedOrderDate = now,
                SalesForecastDate = now,
                SupplierCanDeliver = true,
                SupplierMaxQuantity = 2222222222.22222M,
                SupplierCoverageDays = 3548,
                ItemCoverageDays = 9880,
                InitialStockLevel = 5100,
                SupplierAvailableQuantity = 8731,
                SupplierSharesStock = true,
                CreatedOn = now,
                Status = "OrderForecastDetails_Status",
            };
            var _orderproposal_salesforecast_orderforecasts = new DSS1_RetailerDriverStockOptimisation.BO.SalesForecast
            {
                ImportId = 7819,
                ImportDate = now,
            };
            var _orderproposal_supplierparameters_orderforecast = new DSS1_RetailerDriverStockOptimisation.BO.SupplierParameter
            {
                CoverageDays = 4599,
                SupplierCanDeliverWholeForecast = true,
                SupplierComments = "SupplierParameter_SupplierComments",
                HasReplied = true,
                SharesExcessStock = true,
            };
            var _orderproposal_supplierparameters_orderforecast2 = new DSS1_RetailerDriverStockOptimisation.BO.SupplierParameter
            {
                CoverageDays = 9091,
                SupplierCanDeliverWholeForecast = true,
                SupplierComments = "SupplierParameter_SupplierComments",
                HasReplied = true,
                SharesExcessStock = true,
            };
            var _orderproposal_itemparameters_orderforecast = new DSS1_RetailerDriverStockOptimisation.BO.ItemParameter
            {
                CoverageDays = 7970,
                SupplierCanDeliver = true,
                SupplierQuantity = 8144,
                SupplierComments = "ItemParameter_SupplierComments",
            };
            var _orderproposal_itemparameters_orderforecast2 = new DSS1_RetailerDriverStockOptimisation.BO.ItemParameter
            {
                CoverageDays = 8048,
                SupplierCanDeliver = true,
                SupplierQuantity = 4874,
                SupplierComments = "ItemParameter_SupplierComments",
            };
            new PersistenceSpecification<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>(Session)
            .CheckProperty(p => p.ImportId, 2549)
            .CheckProperty(p => p.Status, "OrderForecast_Status")
            .CheckProperty(p => p.CreatedBy, "OrderForecast_CreatedBy")
            .CheckProperty(p => p.CreatedOn, now)
            .CheckProperty(p => p.StartDate, now)
            .CheckProperty(p => p.EndDate, now)
            .CheckProperty(p => p.State, "OrderForecast_State")
            .CheckBag(p => p.OrderForecastDetails, (new List<DSS1_RetailerDriverStockOptimisation.BO.OrderForecastDetails>
            {
                _orderproposal_orderforecastdetails_orderforecast,
                _orderproposal_orderforecastdetails_orderforecast2
            }))
            .CheckReference(p => p.SalesForecast, _orderproposal_salesforecast_orderforecasts)
            .CheckBag(p => p.SupplierParameters, (new List<DSS1_RetailerDriverStockOptimisation.BO.SupplierParameter>
            {
                _orderproposal_supplierparameters_orderforecast,
                _orderproposal_supplierparameters_orderforecast2
            }))
            .CheckBag(p => p.ItemParameters, (new List<DSS1_RetailerDriverStockOptimisation.BO.ItemParameter>
            {
                _orderproposal_itemparameters_orderforecast,
                _orderproposal_itemparameters_orderforecast2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `OrderForecast`")]
        [Order(1)]
        public void OrderForecast_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.OrderForecast>(
                              a => true
                              && (a.ImportId + 123 > 0)
                              && (a.Status != string.Empty && a.Status != null)
                              && (a.CreatedBy != string.Empty && a.CreatedBy != null)
                              && a.CreatedOn.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.StartDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.EndDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.State != string.Empty && a.State != null)
                              && a.OrderForecastDetails.Any()
                              && a.SalesForecast != null
                              && a.SupplierParameters.Any()
                              && a.ItemParameters.Any()
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}