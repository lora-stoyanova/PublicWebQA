using NUnit.Framework;
using ProgressQATask_v1.BaseUtils;
using ProgressQATask_v1.Pages;


namespace ProgressQATask_v1.Tests
{
    class SuccessStoryPageTest
    {
        [SetUp]
        public void setUp()
        {
            BasePage.StartBrowser();
        }

        [Test]
        [Property("Success Story Page Tests", 1)]
        public void SuccessStoryPageScenario()
        {
            SuccessStoryPage.NavigateTo();
            Common.AssertDocumentStateComplete();
            Common.VerifyURLTextContainsSrt("doctor-shterev-hospital");
            SuccessStoryPageAsserts.VeryfyStoryStructure("Challenge", "Solution", "Result");
        }

        [TearDown]
        public void TestCleanUp()
        {
            BasePage.StopBrowser();
        }
    }
}
