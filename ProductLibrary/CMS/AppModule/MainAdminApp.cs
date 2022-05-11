using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        public static void TP_000000()
        {
            switch (TestCaseId)
            {
                case "TC_000001":
                    TC_000001();
                    break;
            }
        }
    }
}
