using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNgage.Utility
{
    public class Constants : Common.Constants
    {
        #region[Test Plans]

        // eNgage Home Screen Test plan 
        public static string TP_243105 = "TP_243105";
        //Engage Speed Tests
        public static string TP_243876 = "TP_243876";
        // History Page 
        public static string TP_159979 = "TP_159979";
        // Admin Page 
        public static string TP_243163 = "TP_243163";
        // Search Page 
        public static string TP_160101 = "TP_160101";
        //Preferences
        public static string TP_243159 = "TP_243159";
        //Profile
        public static string TP_244114 = "TP_244114";
        //Prompts
        public static string TP_242772 = "TP_242772";
        public static string TP_160103 = "TP_160103";
        public static string TP_207825 = "TP_207825";
        public static string TP_243161 = "TP_243161";

        #endregion[Test Plans]
        #region[Test Cases]

        // eNgage Home Screen 
        #region[TP_243105]
        // ALL tab
        public static string TC_243109 = "TC_243109";
        //Members list
        public static string TC_243110 = "TC_243110";
        //VIP list
        public static string TC_243112 = "TC_243112";
        //Arrivals list
        public static string TC_243113 = "TC_243113";
        //Departures list
        public static string TC_243114 = "TC_243114";
        // In House list
        public static string TC_243118 = "TC_243118";
        // Count match
        public static string TC_243608 = "TC_243608";
        //Home to all tabs navigation
        public static string TC_244589 = "TC_244589";
        //change hotel dropdown
        public static string TC_243120 = "TC_243120";

        #endregion[TP_243105]

        #region[TP_243876]
        //Click on multiple search results from Home tab
        public static string TC_251550 = "TC_251550";
        //Search last names
        public static string TC_243948 = "TC_243948";
        //Search Reservation IDs
        public static string TC_243878 = "TC_243878";
        //Search Email searches
        public static string TC_243949 = "TC_243949";
        //Verify Icon & text are displayed
        public static string TC_243996 = "TC_243996";
        //Check landing page 
        public static string TC_160133 = "TC_160133";
        //Search By network,brand,hotel
        public static string TC_243411 = "TC_243411";
        #endregion[TP_243876]

        #region[TP_159979]
        //Check History load
        public static string TC_244590 = "TC_244590";
        #endregion[TP_159979]

        #region[TP_243163]
        //Check Admin load
        public static string TC_243294 = "TC_243294";
        //Check Reporting load
        public static string TC_243417 = "TC_243417";
        #endregion[TP_243163]

        #region[TP_160101]
        //Search Page
        public static string TC_160143 = "TC_160143";
        public static string TC_160144 = "TC_160144";
        public static string TC_160147 = "TC_160147";
        public static string TC_160146 = "TC_160146";
        public static string TC_160149 = "TC_160149";
        public static string TC_243421 = "TC_243421";
        public static string TC_243423 = "TC_243423";
        public static string TC_160193 = "TC_160193";
        public static string TC_160134 = "TC_160134";

        #endregion[TP_160101]

        #region[TP_243159]
        //Add preferences
        public static string TC_243197 = "TC_243197";
        #endregion[TP_243159]

        #region[TP_244114]
        //Add preferences
        public static string TC_244127 = "TC_244127";
        #endregion[TP_244114]

        #region[TP_242772]
        //Prompts Page
        public static string TC_243245 = "TC_243245";
        public static string TC_242789 = "TC_242789";
        public static string TC_243242 = "TC_243242";
        public static string TC_242805 = "TC_242805";
        public static string TC_242784 = "TC_242784";
        public static string TC_242812 = "TC_242812";
        public static string TC_242816 = "TC_242816";

        #endregion[TP_242772]

        #region[TP_160103]
        public static string TC_160960 = "TC_160960";
        public static string TC_160961 = "TC_160961";
        public static string TC_160962 = "TC_160962";
        #endregion[TP_160103]

        #region[TP_243161]
        public static string TC_243419 = "TC_243419";
        #endregion[TP_243161]


        #region[TP_207825]
        public static string TC_207827 = "TC_207827";
        public static string TC_207829 = "TC_207829";
        #endregion[TP_207825]



        #endregion[Test Cases]

        #region[ObjectRepository UI Module Names]
        public static string ModuleCommon = "Common";
        public static string Login = "Login";
        public static string SignUp = "SignUp";
        public static string Profile = "Profile";
        public static string Home = "Home";
        public static string Summary = "Summary";
        public static string Prompts = "Prompts";
        public static string Search = "Search";
        public static string History = "History";
        public static string Admin = "Admin";
        public static string Reporting = "Reporting";
        public static string Preferences = "Preferences";
        #endregion[ObjectRepository UI Module Names]
    }
}
