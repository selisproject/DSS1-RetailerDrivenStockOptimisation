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
    ///This is a test class for AuditLogEntryTypeTest and is intended
    ///to contain all AuditLogEntryTypeTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("AuditLogEntryType Repository Tests")]
    [Category("AuditLogEntryType Repository Tests")]
    internal class AuditLogEntryTypeTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `AuditLogEntryType`")]
        [Order(0)]
        public void AuditLogEntryType_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType>(Session)
            .CheckProperty(p => p.Code, "AuditLogEntryType_Code")
            .CheckProperty(p => p.Name, "AuditLogEntryType_Name")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `AuditLogEntryType`")]
        [Order(1)]
        public void AuditLogEntryType_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType>(
                              a => true
                              && (a.Code != string.Empty && a.Code != null)
                              && (a.Name != string.Empty && a.Name != null)
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