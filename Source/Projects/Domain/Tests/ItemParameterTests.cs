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
    ///This is a test class for ItemParameterTest and is intended
    ///to contain all ItemParameterTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ItemParameter Repository Tests")]
    [Category("ItemParameter Repository Tests")]
    internal class ItemParameterTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ItemParameter`")]
        [Order(0)]
        public void ItemParameter_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _orderproposal_item_itemcriterion = new DSS1_RetailerDriverStockOptimisation.BO.Item
            {
                SKU = "38fd002c-87a3-45be-8fe4-9a8f480d7295Item_SKU",
                Description = "Item_Description",
                UPC = "Item_UPC",
                AvgDailyDemand = 222222.22M,
                PalletSize = 2226,
                SupplierPackSize = 4979,
                InnerPackSize = 6924,
                PalletType = "Item_PalletType",
                PalTI = 5123,
                PalHI = 5807,
                UOM = "Item_UOM",
            };
            new PersistenceSpecification<DSS1_RetailerDriverStockOptimisation.BO.ItemParameter>(Session)
            .CheckProperty(p => p.CoverageDays, 5525)
            .CheckProperty(p => p.SupplierCanDeliver, true)
            .CheckProperty(p => p.SupplierQuantity, 2429)
            .CheckProperty(p => p.SupplierComments, "ItemParameter_SupplierComments")
            .CheckReference(p => p.Item, _orderproposal_item_itemcriterion)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ItemParameter`")]
        [Order(1)]
        public void ItemParameter_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS1_RetailerDriverStockOptimisation.BO.ItemParameter> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.ItemParameter>(
                              a => true
                              && (a.CoverageDays + 123 > 0)
                              && !a.SupplierCanDeliver
                              && (a.SupplierQuantity + 123 > 0)
                              && (a.SupplierComments != string.Empty && a.SupplierComments != null)
                              && a.Item != null
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