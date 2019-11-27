using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQATask_v1.Pages
{
    class CustomersPageAsserts

    {
        public static void VerifyURLText(string customers) {
            string txt = BaseUtils.CommonFunctions.URLText();
            Assert.IsTrue(txt.Contains(customers));
        }

        public static void DocState(string state)
        {
            string txt = BaseUtils.CommonFunctions.GetDocumentState(); 
            Assert.IsTrue(txt.Contains(state));
        }


    }
}
