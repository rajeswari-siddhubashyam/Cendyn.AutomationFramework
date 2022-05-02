using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Unified_Profile.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        public static void TP_356196()
        {
            switch (TestCaseId)
            {
                case "TC_340276":
                    TC_340276();
                    break;
                case "TC_340278":
                    TC_340278();
                    break;
                case "TC_340284":
                    TC_340284();
                    break;
                case "TC_340283":
                    TC_340283();
                    break;
                case "TC_340280":
                    TC_340280();
                    break;
                case "TC_340291":
                    TC_340291();
                    break;
                case "TC_340281":
                    TC_340281();
                    break;
            }
        }
    }
}
