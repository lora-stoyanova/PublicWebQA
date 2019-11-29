using NUnit.Framework;
using ProgressQATask_v1.BaseUtils;
using ProgressQATask_v1.Navigation;


namespace ProgressQATask_v1.Tests
{
    class NavigationTest
    {
        [SetUp]
        public void setUp()
        {
            BasePage.StartBrowser();
        }

        [Test]
        [Property("Navigation Tests (Services)", 1)]
        public void NavigationTestsScenario()
        {
            BasePage.Driver.Navigate().GoToUrl(BasePage.URL);
            NavigationBase.HoverServicesMenu();
            NavigationBase.SelectConsulting();
            Common.AssertDocumentStateComplete();
            Common.VerifyURLTextContainsSrt("consulting");
            Common.AssertPageHeaderTextIsDisplayed("Services");
            Common.AssertPageFooterIsDisplayed("Copyright © 2019 Progress Software Corporation and/or its subsidiaries or affiliates.\r\nAll Rights Reserved.");
        }

        [TearDown]
        public void TestCleanUp()
        {
            BasePage.StopBrowser();
        }

    }
}
