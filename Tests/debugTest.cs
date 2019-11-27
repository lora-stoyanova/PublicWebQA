using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgressQATask_v1
{
    [TestClass]
    public class debugTest
    {
        [TestInitialize]
        public void setUp()
        {
            BaseUtils.Driver.StartBrowser();
        }

        [TestMethod]

        public void CustomersTest() {
            BaseUtils.Driver.GoToPage(BaseUtils.PagesLinks.CustomersPage);
            BaseUtils.CommonFunctions.URLText();
            BaseUtils.CommonFunctions.GetDocumentState();
        }

        [TestCleanup]

        public void TestCleanUp() {
            BaseUtils.Driver.StopBrowser();
        }
    }
}
