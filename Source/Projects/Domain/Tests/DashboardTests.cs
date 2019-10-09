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
    ///This is a test class for DashboardTest and is intended
    ///to contain all DashboardTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Dashboard Repository Tests")]
    [Category("Dashboard Repository Tests")]
    internal class DashboardTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Dashboard`")]
        [Order(0)]
        public void Dashboard_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _dashboard_statistics_dashboard = new DSS1_RetailerDriverStockOptimisation.BO.Statistics
            {
                TotalUnits = 1881,
                Description = "Statistics_Description",
                Result = 3198,
                LeadTime = 3582,
                WeekDay = "Statistics_WeekDay",
                StockOnHandDate = now,
                StockOnHand = 4753,
                OrderQuantity = 5288,
                SalesQuantity = 650,
                QuantitySalesForecast = 1008,
                StockOnHandDateFormatted = "Statistics_StockOnHandDateFormatted",
                SupplierStock = 564,
                QuantitySum = 9823,
                SalesForecastDate = now,
                SalesForecastDateFormatted = "Statistics_SalesForecastDateFormatted",
                Threshold = 222222.22M,
                OrderDate = now,
                OrderDateFormatted = "Statistics_OrderDateFormatted",
                RealOrderQuantity = 8378,
            };
            var _dashboard_statistics_dashboard2 = new DSS1_RetailerDriverStockOptimisation.BO.Statistics
            {
                TotalUnits = 9042,
                Description = "Statistics_Description",
                Result = 2278,
                LeadTime = 7431,
                WeekDay = "Statistics_WeekDay",
                StockOnHandDate = now,
                StockOnHand = 9448,
                OrderQuantity = 6436,
                SalesQuantity = 2625,
                QuantitySalesForecast = 3851,
                StockOnHandDateFormatted = "Statistics_StockOnHandDateFormatted",
                SupplierStock = 9942,
                QuantitySum = 5630,
                SalesForecastDate = now,
                SalesForecastDateFormatted = "Statistics_SalesForecastDateFormatted",
                Threshold = 222222.22M,
                OrderDate = now,
                OrderDateFormatted = "Statistics_OrderDateFormatted",
                RealOrderQuantity = 6323,
            };
            new PersistenceSpecification<DSS1_RetailerDriverStockOptimisation.BO.Dashboard>(Session)
            .CheckBag(p => p.Statistics, (new List<DSS1_RetailerDriverStockOptimisation.BO.Statistics>
            {
                _dashboard_statistics_dashboard,
                _dashboard_statistics_dashboard2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Dashboard`")]
        [Order(1)]
        public void Dashboard_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS1_RetailerDriverStockOptimisation.BO.Dashboard> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Dashboard>(
                              a => true
                              && a.Statistics.Any()
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