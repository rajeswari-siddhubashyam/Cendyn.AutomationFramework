using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Config.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        public static void TP_000000()
        {
            switch (TestCaseId)
            {
                case "TC_000000":
                    TC_000000();
                    break;
            }
        }
        public static void TP_323199()
        {
            switch (TestCaseId)
            {
                case "TC_353241":
                    TC_353241();
                    break;
                case "TC_326759":
                    TC_326759();
                    break;
                case "TC_309597":
                    TC_309597();
                    break;
                case "TC_309602":
                    TC_309602();
                    break;
            }
        }
        public static void TP_349769()
        {
            switch (TestCaseId)
            {
                case "TC_314185":
                    TC_314185();
                    break;
                case "TC_314190":
                    TC_314190();
                    break;
                case "TC_314192":
                    TC_314192();
                    break;
            }
        }
        
    }
}
