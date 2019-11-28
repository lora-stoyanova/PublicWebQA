using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProgressQATask_v1.BaseUtils;
using ProgressQATask_v1.Pages;

namespace ProgressQATask_v1
{
    [TestClass]
    public class debugTest
    {
        [SetUp]
        public void setUp()
        {
            BasePage.StartBrowser();
        }

        [Test]

        public void CustomersPageTest() {
            CustomersPage.NavigateTo();
            Common.AssertDocumentStateComplete();
            CustomersPageAsserts.VerifyURLTextContainsSrt("customers");
            CustomersPageAsserts.AssertPageHeaderIsDisplayed("Customers");
            CustomersPageAsserts.AssertPageFooterIsDisplayed("Copyright © 2019 Progress Software Corporation and/or its subsidiaries or affiliates."); 


        }

       // [TearDown]

        //public void TestCleanUp() {
        //    BasePage.StopBrowser();
       // }
    }
}
