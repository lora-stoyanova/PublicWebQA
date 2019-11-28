using OpenQA.Selenium;
using ProgressQATask_v1.BaseUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Pages
{
    class CustomersPage : BasePage
    {
        public static void NavigateTo()
        {
            string page = "customers"; 
            BasePage.GoToPage(BasePage.URL + page);
        }

        public static IWebElement PageTitle
        {
            get
            {
                return BasePage.Driver.FindElement(By.TagName("title")); 
            }
        }
    }
}
