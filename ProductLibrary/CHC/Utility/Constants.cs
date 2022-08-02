using System.ComponentModel;

namespace CHC.Utility
{
    public class Constants : Common.Constants
    {
        public enum clientEnv
        {
            [Description("CHCAutoQA")]
            CHCAutoQA,
            [Description("CHCAutoDemo")]
            CHCAutoDemo,
            [Description("CHCAutoDEV")]
            CHCAutoDev,
        }
        public static string Admin = "Admin";

        #region[Test Plans]
        public static string TP_339264 = "TP_339264";
        public static string TP_344217 = "TP_344217";
        public static string TP_345743 = "TP_345743";
        public static string TP_345770 = "TP_345770";
        public static string TP_348876 = "TP_348876";
        public static string TP_352298 = "TP_352298";
        //public static string TP_296600 = "TP_296600";

        #endregion

        #region[Test Cases]
        public static string TC_339266 = "TC_339266";
        public static string TC_339267 = "TC_339267";
        public static string TC_339268 = "TC_339268";
        public static string TC_339269 = "TC_339269";
        public static string TC_339271 = "TC_339271";
        public static string TC_339272 = "TC_339272";
        public static string TC_341590 = "TC_341590";
        public static string TC_341591 = "TC_341591";
        public static string TC_341592 = "TC_341592";
        public static string TC_326065 = "TC_326065";

        

        public static string TC_344019 = "TC_344019";
        public static string TC_344018 = "TC_344018";
        public static string TC_344020 = "TC_344020";
        public static string TC_344024 = "TC_344024";
        public static string TC_343794 = "TC_343794";

        public static string TC_345744 = "TC_345744";
        public static string TC_345746 = "TC_345746";
        public static string TC_345747 = "TC_345747";
        public static string TC_345748 = "TC_345748";
        public static string TC_345749 = "TC_345749";
        public static string TC_348626 = "TC_348626";
        public static string TC_348628 = "TC_348628";

        public static string TC_345772 = "TC_345772";
        //public static string TC_293202 = "TC_293202";

        public static string TC_348879 = "TC_348879";
        public static string TC_311420 = "TC_311420";
        public static string TC_311423 = "TC_311423";
        public static string TC_348878 = "TC_348878";
        public static string TC_348880 = "TC_348880";
        public static string TC_348881 = "TC_348881";
        public static string TC_348882 = "TC_348882";
        public static string TC_348885 = "TC_348885";
        public static string TC_348886 = "TC_348886";
        public static string TC_348887 = "TC_348887";
        public static string TC_348888 = "TC_348888";
        public static string TC_348889 = "TC_348889";
        public static string TC_348890 = "TC_348890";

        public static string TC_314420 = "TC_314420";
        public static string TC_314421 = "TC_314421";
        public static string TC_314422 = "TC_314422";
        public static string TC_314423 = "TC_314423";
        public static string TC_314424 = "TC_314424";
        public static string TC_314425 = "TC_314425";
        public static string TC_314426 = "TC_314426";
        public static string TC_314427 = "TC_314427";
        public static string TC_314430 = "TC_314430";
        public static string TC_329642 = "TC_329642";
        //public static string TC_326065 = "TC_326065";
        
        #endregion

        #region[CommonData]
        public static string FrontEndEmail = "hreddy@cendyn.com";
        public static string FrontEndEmail_Demo = "chc_demo@cendyn.com";
        public static string FrontEndEmail_Test = "testlogin3@cendyn17.com";
        //#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public static string CommonPassword = "Cendyn@123";
        public static string CommonPassword_Demo = "@Sc@A6Ffs#mrY#eX";
        public static string CommonPassword_Test = "Cendyn123$";
        //#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        #endregion[CommonData]
    }
}
