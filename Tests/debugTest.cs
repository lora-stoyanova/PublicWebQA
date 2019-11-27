using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ProgressQATask_v1
{
    [TestClass]
    public class debugTest
    {
        [SetUp]
        public void setUp()
        {
            BaseUtils.Driver.StartBrowser();
        }

        [Test]

        public void CustomersTest() {
            BaseUtils.Driver.GoToPage(BaseUtils.PagesLinks.CustomersPage);
            BaseUtils.CommonFunctions.URLText();
            BaseUtils.CommonFunctions.GetDocumentState();
            Pages.CustomersPageAsserts.VerifyURLText("customers");
            Pages.CustomersPageAsserts.DocState("ready");
        }

        [TearDown]

        public void TestCleanUp() {
            BaseUtils.Driver.StopBrowser();
        }
    }
}
