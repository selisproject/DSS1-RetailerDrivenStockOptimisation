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
    ///This is a test class for BaseUnitTest and is intended
    ///to contain all BaseUnitTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("BaseUnit Repository Tests")]
    [Category("BaseUnit Repository Tests")]
    internal class BaseUnitTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `BaseUnit`")]
        [Order(0)]
        public void BaseUnit_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _hierarchy_subcategory_baseunits = new DSS1_RetailerDriverStockOptimisation.BO.SubCategory
            {
                Number = 2132,
                Description = "SubCategory_Description",
            };
            new PersistenceSpecification<DSS1_RetailerDriverStockOptimisation.BO.BaseUnit>(Session)
            .CheckProperty(p => p.Number, 6297)
            .CheckProperty(p => p.Description, "BaseUnit_Description")
            .CheckReference(p => p.SubCategory, _hierarchy_subcategory_baseunits)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `BaseUnit`")]
        [Order(1)]
        public void BaseUnit_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS1_RetailerDriverStockOptimisation.BO.BaseUnit> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.BaseUnit>(
                              a => true
                              && (a.Number + 123 > 0)
                              && (a.Description != string.Empty && a.Description != null)
                              && a.SubCategory != null
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