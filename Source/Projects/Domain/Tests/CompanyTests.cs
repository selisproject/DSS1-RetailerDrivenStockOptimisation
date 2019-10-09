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
    ///This is a test class for CompanyTest and is intended
    ///to contain all CompanyTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Company Repository Tests")]
    [Category("Company Repository Tests")]
    internal class CompanyTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Company`")]
        [Order(0)]
        public void Company_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _company_contacts_company = new DSS1_RetailerDriverStockOptimisation.BO.Contact
            {
                Id = 8261,
                UserName = "1f3136b7-05f2-448f-a8b9-a5171aa41a58Contact_UserName",
                PasswordHash = "Contact_PasswordHash",
                SecurityStamp = "Contact_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 6676,
                Name = "Contact_Name",
                Email = "Contact_Email",
                PhoneNumber = "Contact_PhoneNumber",
                LockoutEndDate = now,
            };
            var _company_contacts_company2 = new DSS1_RetailerDriverStockOptimisation.BO.Contact
            {
                Id = 7461,
                UserName = "1111",
                PasswordHash = "Contact_PasswordHash",
                SecurityStamp = "Contact_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 297,
                Name = "Contact_Name",
                Email = "Contact_Email",
                PhoneNumber = "Contact_PhoneNumber",
                LockoutEndDate = now,
            };
            new PersistenceSpecification<DSS1_RetailerDriverStockOptimisation.BO.Company>(Session)
            .CheckProperty(p => p.Code, "Company_Code")
            .CheckProperty(p => p.Name, "Company_Name")
            .CheckBag(p => p.Contacts, (new List<DSS1_RetailerDriverStockOptimisation.BO.Contact>
            {
                _company_contacts_company,
                _company_contacts_company2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Company`")]
        [Order(1)]
        public void Company_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS1_RetailerDriverStockOptimisation.BO.Company> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Company>(
                              a => true
                              && (a.Code != string.Empty && a.Code != null)
                              && (a.Name != string.Empty && a.Name != null)
                              && a.Contacts.Any()
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