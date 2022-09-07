using System.ComponentModel;

namespace CHC_Config.Utility
{
    public class Constants : Common.Constants
    {
        public enum clientEnv
        {
            [Description("CHC_ConfigQA")]
            CHC_ConfigQA,
            [Description("CHC_ConfigDEV")]
            CHC_ConfigDEV
         /*   [Description("CHC_ConfigDEMO")]
            CHC_ConfigDEMO*/
        }
        #region ObjectRepository UI Module Names
        public static string Admin = "Admin";
        public static string OrgIndex = "OrgIndex";
        public static string PropertyDashboard = "PropertyDashboard";
        public static string Create = "Create";
        public static string CreateUser = "CreateUser";
        #endregion ObjectRepository UI Module Names

        #region[Test Plans]
        public static string TP_323199 = "TP_323199";
        public static string TP_349769 = "TP_349769";
        public static string TP_000000 = "TP_000000";
        public static string TP_349772 = "TP_349772";
        public static string TP_349775 = "TP_349775";

        public static string TP_422702 = "TP_422702";

        public static string TP_401440 = "TP_401440";
        #endregion

        #region[Test Cases]
        public static string TC_309589 = "TC_309589";
        public static string TC_326759 = "TC_326759";
        public static string TC_309597 = "TC_309597";
        public static string TC_309602 = "TC_309602";
        public static string TC_353241 = "TC_353241";

        public static string TC_000000 = "TC_000000";

        public static string TC_314165 = "TC_314165";
        public static string TC_314185 = "TC_314185";
        public static string TC_314186 = "TC_314186";
        public static string TC_314187 = "TC_314187";
        public static string TC_314163 = "TC_314163";
        public static string TC_314190 = "TC_314190";
        public static string TC_314192 = "TC_314192";

        public static string TC_314590 = "TC_314590";
        public static string TC_314618 = "TC_314618";
        public static string TC_314610 = "TC_314610";
        public static string TC_349764 = "TC_349764";

        public static string TC_314581 = "TC_314581";
        public static string TC_314570 = "TC_314570";
        public static string TC_314204 = "TC_314204";
        public static string TC_349765 = "TC_349765";

        public static string TC_335464 = "TC_335464";
        public static string TC_335441 = "TC_335441";
        public static string TC_335444 = "TC_335444";

        public static string TC_334574 = "TC_334574";
        public static string TC_334582 = "TC_334582";
        public static string TC_334583 = "TC_334583";
        public static string TC_334597 = "TC_334597";
        public static string TC_334598 = "TC_334598";
        public static string TC_380075 = "TC_380075";
        public static string TC_380077 = "TC_380077";

        public static string TC_372371 = "TC_372371";
        public static string TC_422391 = "TC_422391";

        public static string TC_326760 = "TC_326760";
        public static string TC_326761 = "TC_326761";
        #endregion

        #region[CommonData]
        public static string FrontEndEmail = "testuser10@cendyn17.com";
        //public static string FrontEndEmail_Test = "testlogin3@cendyn17.com";
      
        //#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public static string CommonPassword = "Cendyn321#";
       
        public static string CommonPassword_Test = "Cendyn4321$";
        //#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        #endregion[CommonData]
    }
}
