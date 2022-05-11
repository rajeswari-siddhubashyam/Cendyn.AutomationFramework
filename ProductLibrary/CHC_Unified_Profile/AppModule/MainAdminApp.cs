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
                case "TC_340281":
                    TC_340281();
                    break;
            }
        }

        public static void TP_358861()
        {
            switch (TestCaseId)
            {
                case "TC_312067":
                    TC_312067();
                    break;
                case "TC_312069":
                    TC_312069();
                    break;
                case "TC_312070":
                    TC_312070();
                    break;
            }
        }

        public static void TP_356194()
        {
            switch (TestCaseId)
            {
                case "TC_326178":
                    TC_326178();
                    break;
            }
        }

        public static void TP_369438()
        {
            switch (TestCaseId)
            {
                case "TC_332462":
                    TC_332462();
                    break;
            }
        }

    }
    
}
