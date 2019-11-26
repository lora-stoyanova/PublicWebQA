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
            BrowserUtils.Driver.StartBrowser();
        }

        [TestMethod]

        public void CustomersTest() {
            BrowserUtils.Driver.GoToPage(BrowserUtils.PagesNames.CustomersPage);
        }

        [TestCleanup]

        public void TestCleanUp() {
            BrowserUtils.Driver.StopBrowser();
        }
    }
}
