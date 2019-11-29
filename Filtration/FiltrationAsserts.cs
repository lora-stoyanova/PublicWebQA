using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Filtration
{
    class FiltrationAsserts
    {
        internal static void AssertFilterIsDisplayed()
        {
            Assert.IsTrue(FiltrationMap.FilterContainer.Displayed);
        }

        internal static void AssertFilterCriteriaArePresented(string industry, string product, string solution)
        {
            Assert.IsTrue(FiltrationMap.FilterIndustryHeader.Text.Contains(industry), "Industry selection option header is not presented.");
            Assert.IsTrue(FiltrationMap.FilterProductHeader.Text.Contains(product), "Product selection option header is not presented.");
            Assert.IsTrue(FiltrationMap.FilterSolutionHeader.Text.Contains(solution), "Solution selection option header is not presented.");
        }


        // validation can be extender further for pages
        internal static void AssertThatDisplayedResultsAreBasedOnSelectedIndustry(string selectedIndustry)
        {
           IList<IWebElement> industryGridTags = BasePage.Driver.FindElements(By.XPath("//div[@class = 'Customers-Grid Customers-Grid--filtered']//h6"));
           for (int i = 0; i < industryGridTags.Count; i++)
            {
                Assert.True(industryGridTags[i].Text == selectedIndustry.ToUpper(), "Filter results are not correctly. Selected Industry: " + selectedIndustry + "; Displayed tag: " + industryGridTags[i].Text);
            }
        }

        internal static void AssertThatSelectedOptionIsMarked(string selectedIndustry)
        {
            Assert.True(FiltrationMap.OptionTag.Text == selectedIndustry, "Wrong tag is dispalyed.");
            Assert.True(FiltrationMap.OptionTag.Displayed, "Selected Industry is not marked as tag.");
        }
    }
}
