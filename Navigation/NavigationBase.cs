using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Navigation
{
    class NavigationBase
    {
        internal static void HoverServicesMenu()
        {
            Actions action = new Actions(BasePage.Driver);
            action.MoveToElement(NavigationMap.ServicesMainMenu).Build().Perform();
        }

        internal static void SelectConsulting()
        {
            NavigationMap.ConsultingSubServicesMainMenu.Click();
        }
    }
}
