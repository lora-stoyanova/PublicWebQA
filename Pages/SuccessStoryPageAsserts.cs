using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProgressQATask_v1.BaseUtils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Pages
{
    class SuccessStoryPageAsserts
    {

        internal static void VeryfyStoryStructure(string expectedTextIntro, string expectedTextMain, string expectedTextEnd)
        {
            IWebElement content = SuccessStoryPageMap.GetGeneralContent;
            IList<IWebElement> headers = BasePage.Driver.FindElements(By.XPath("//div[contains(@class, '-pt2')]//h4"));


            for (int i = 0; i < headers.Count; i++)
            {
                if (i == 0) { 
                    Assert.IsTrue(headers[i].Text.Contains(expectedTextIntro), "Story Structure is not as expected: Challenge"); 
                }

                if (i == 1)
                {
                    Assert.IsTrue(headers[i].Text.Contains(expectedTextMain), "Story Structure is not as expected: Solution");
                }

                if (i == 2)
                {
                    Assert.IsTrue(headers[i].Text.Contains(expectedTextEnd), "Story Structure is not as expected: Result");
                }
            }

            Assert.IsTrue(headers.Count == 3, "Story structure is not as expected. ");
        }
    }
}
