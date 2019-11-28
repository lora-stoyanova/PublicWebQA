using NUnit.Framework;
using ProgressQATask_v1.BaseUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgressQATask_v1.Pages
{
    class CustomersPageAsserts

    {
        public static void VerifyURLTextContainsSrt(string text)
        {
            string txt = Common.URLText();
            Assert.IsTrue(txt.Contains(text));
        }

        public static void AssertPageHeaderIsDisplayed(string ExpectedHeaderText)
        { string ActualHaderText = CustomerPageMap.Header.Text;
            Assert.AreEqual(ExpectedHeaderText, ActualHaderText, "Header of Customers page is not displayed properly. Expected: " + ExpectedHeaderText + "Actual: " + ActualHaderText);
        }


        public static void AssertPageFooterIsDisplayed(string ExpectedHeaderText)
        {
            string ActualHaderText = CustomerPageMap.Footer.Text.Trim();
            Assert.AreEqual(ExpectedHeaderText, ActualHaderText, "Footer of Customers page is not displayed properly. \n Expected: " + ExpectedHeaderText + " \n Actual: " + ActualHaderText);
        }
    }
}
