using OpenQA.Selenium;
using ProgressQATask_v1.BaseUtils;

namespace ProgressQATask_v1.Pages
{
    class CustomerPageMap
    {
        public static IWebElement Header
        {
            get
            {
                return BasePage.Driver.FindElement(By.ClassName("PRGS-Nav-title"));
            }
        }

        public static IWebElement Footer
        {
            get
            {
                return BasePage.Driver.FindElement(By.ClassName("PRGS-Footer-copyright"));
            }
        }
    }
}
