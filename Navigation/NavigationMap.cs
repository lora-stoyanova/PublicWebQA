using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProgressQATask_v1.Navigation
{
    class NavigationMap
    {
        public static IWebElement ServicesMainMenu
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//div[@id = 'js-drawer']//div[@class = 'PRGS-Bar-nav']//a[text()='Services']"));
            }
        }

        public static IWebElement ConsultingSubServicesMainMenu
        {
            get
            {
                return BasePage.Driver.FindElement(By.XPath("//a[text() = 'Consulting']"));
            }
        }

    }
}
