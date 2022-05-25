using System.ComponentModel;

namespace CHC_Unified_Profile.Utility
{
    public class Constants : Common.Constants
    {
        public static string Admin = "Admin";        

        public enum clientEnv
        {
            [Description("CHCAutoQA")]
            CHCAutoQA,
            [Description("CHC_UP_AutoQA")]
            CHC_UP_AutoQA,
            [Description("CHCAutoDEV")]
            CHCAutoDev,            
        }        

        #region[Test Plans]

        public static string TP_356196 = "TP_356196"; 
        
        public static string TP_356194 = "TP_356194";

        public static string TP_358861 = "TP_358861";       

        public static string TP_369438 = "TP_369438";

        #endregion

        #region[Test Cases] 

        public static string TC_340278 = "TC_340278";
        public static string TC_340284 = "TC_340284";
        public static string TC_340283 = "TC_340283";
        public static string TC_340280 = "TC_340280";        
        public static string TC_340281 = "TC_340281";

        public static string TC_340291 = "TC_340291";
        public static string TC_340276 = "TC_340276";

        //public static string TC_332243 = "TC_332243";
        public static string TC_326178 = "TC_326178";

        public static string TC_312067 = "TC_312067";
        public static string TC_312069 = "TC_312069";
        public static string TC_312070 = "TC_312070";

        public static string TC_332462 = "TC_332462";

        //public static string TC_340291 = "TC_340291";
        //public static string TC_340276 = "TC_340276";

        #endregion

        #region[CommonData] 

        public static string FrontEndEmail = "hreddy@cendyn.com";//testuser10@cendyn17.com"; // hreddy@cendyn.com"
        public static string FrontEndEmail_Test = "testlogin3@cendyn17.com";
        //#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public static string CommonPassword = "Cendyn@123"; //Cendyn@123-Cendyn123$
        public static string CommonPassword_Test = "Cendyn4321$";
        //#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        public static string FrontEndEmail_Unlock = "testlogin@cendyn17.com";        
        //#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public static string CommonPassword_Unlock = "Cendyn12345";

        #endregion[CommonData]
    }
}
