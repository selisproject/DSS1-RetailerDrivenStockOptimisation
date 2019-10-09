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
    ///This is a test class for ApplicationThemeTest and is intended
    ///to contain all ApplicationThemeTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationTheme Repository Tests")]
    [Category("ApplicationTheme Repository Tests")]
    internal class ApplicationThemeTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationTheme`")]
        [Order(0)]
        public void ApplicationTheme_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme>(Session)
            .CheckProperty(p => p.Name, "ApplicationTheme_Name")
            .CheckProperty(p => p.Description, "ApplicationTheme_Description")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationTheme`")]
        [Order(1)]
        public void ApplicationTheme_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme>(
                              a => true
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Description != string.Empty && a.Description != null)
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