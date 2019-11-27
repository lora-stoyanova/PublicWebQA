using OpenQA.Selenium;
using ProgressQATask_v1.BaseUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Pages
{
    class CustomersPage : Driver
    {

        public IWebElement PageTitle
        {
            get
            {
                return Driver.Browser.FindElement(By.TagName("title")); 
            }
        }



    }
}
