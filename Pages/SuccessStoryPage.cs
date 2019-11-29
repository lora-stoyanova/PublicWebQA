using ProgressQATask_v1.BaseUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Pages
{
    class SuccessStoryPage
    {
        public static void NavigateTo()
        {
            string page = "customers/doctor-shterev-hospital";
            BasePage.GoToPage(BasePage.URL + page);
        }
    }
}
