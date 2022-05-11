using System.ComponentModel;

namespace CMS.Utility
{
    public class Constants : Common.Constants
    {
        public enum clientEnv
        {
            [Description("CMSQA")]
            CMSQA,
            [Description("CMSDEV")]
            CMSDEV,
        }

        public static string Admin = "Admin";

        public static string TP_000000 = "TP_000000";
        public static string TC_000001 = "TC_000001";


        #region[CommonData]
        public static string FrontEndEmail = "AdminQA@cendyn17.com";
        public static string CommonPassword = "Admin1234$";
        public static string CatchAllEmail = "catchall@cendyn17.com";
        public static string CatchAllPassword = "AutoCendyn1234$";
        #endregion[CommonData]
    }
}
