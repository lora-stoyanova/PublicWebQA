using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Filtration
{
    class FiltrationBase
    {
         internal static void ClickOnSelectIndustry()
        {
            IWebElement btn  = BasePage.DriverWait.Until(e => e.FindElement(By.XPath("//span[@id = 'GeneralContent_C092']//div[contains(@class, 'Dropdown Dropdown')]")));

            IJavaScriptExecutor js = (IJavaScriptExecutor)BasePage.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", btn);
            Thread.Sleep(500);
            btn.Click();
        }

        internal static void SelectIndustry(string selectedIndustry)
        {
            IList<IWebElement> listOptions = BasePage.Driver.FindElements(By.XPath("//span[@id = 'GeneralContent_C092']//div[contains(@class, 'Dropdown-view Dropdown')]//ul[@class = 'dropdownItems']//li"));
            //Random rnd = new Random();
            //int option = rnd.Next(1, (listOptions.Count)+1);
            
           // here could be done validation based on random number and respectively check for another fields. 


            for (int i = 0; i < listOptions.Count; i++) {
                if (listOptions[i].Text == selectedIndustry) 
                {
                    listOptions[i].Click();
                    break;
                }
            }
        }
    }
}
