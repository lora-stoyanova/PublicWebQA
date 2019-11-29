using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProgressQATask_v1.BaseUtils;
using ProgressQATask_v1.Pages;

namespace ProgressQATask_v1
{
    [TestClass]
    public class CustomersPageTest
    {
        [SetUp]
        public void setUp()
        {
            BasePage.StartBrowser();
        }

        [Test]
        [Property("Customers Page Tests", 1)]
        public void CustomersPageTestScenario() {
            CustomersPage.NavigateTo();
            Common.AssertDocumentStateComplete();
            Common.VerifyURLTextContainsSrt("customers");
            Common .AssertPageHeaderTextIsDisplayed("Customers");
            Common.AssertPageFooterIsDisplayed("Copyright © 2019 Progress Software Corporation and/or its subsidiaries or affiliates.\r\nAll Rights Reserved."); 
        }

        [TearDown]
        public void TestCleanUp()
        {
            BasePage.StopBrowser();
        }
    }
}
