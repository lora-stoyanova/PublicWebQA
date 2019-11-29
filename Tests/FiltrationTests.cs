using NUnit.Framework;
using ProgressQATask_v1.BaseUtils;
using ProgressQATask_v1.Filtration;
using ProgressQATask_v1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Tests
{
    class FiltrationTests
    {
        [SetUp]
        public void setUp()
        {
            BasePage.StartBrowser();
        }

        [Test]
        [Property("Filtration Tests (Customers Page)", 1)]
        public void FiltrationTestsScenario()
        {
            CustomersPage.NavigateTo();
            Common.AssertDocumentStateComplete();
            Common.VerifyURLTextContainsSrt("customers");
            Common.AssertPageHeaderTextIsDisplayed("Customers");
            Common.AssertPageFooterIsDisplayed("Copyright © 2019 Progress Software Corporation and/or its subsidiaries or affiliates.\r\nAll Rights Reserved.");

            FiltrationAsserts.AssertFilterIsDisplayed();
            FiltrationAsserts.AssertFilterCriteriaArePresented("INDUSTRY", "PRODUCT", "SOLUTION");
            FiltrationBase.ClickOnSelectIndustry();
            FiltrationBase.SelectIndustry("Education");
            FiltrationAsserts.AssertThatSelectedOptionIsMarked("Education");
            FiltrationAsserts.AssertThatDisplayedResultsAreBasedOnSelectedIndustry("Education");
        }

        [TearDown]
        public void TestCleanUp()
        {
            BasePage.StopBrowser();
        }


    }
}
