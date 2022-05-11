using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using SqlWarehouse;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp
    {
        public static string profileID;

        public static void AssignProfileID()
        {
            profileID = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "ProfileID");
        }

        #region[TP_160101]
        public static void TP_160101()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_160134":
                    TC_160134();
                    break;
                case "TC_160143":
                    TC_160143();
                    break;
                case "TC_160144":
                    TC_160144();
                    break;
                case "TC_160146":
                    TC_160146();
                    break;
                case "TC_160147":
                    TC_160147();
                    break;
                case "TC_160149":
                    TC_160149();
                    break;
                case "TC_243421":
                    TC_243421();
                    break;
                case "TC_243423":
                    TC_243423();
                    break;
                case "TC_160193":
                    TC_160193();
                    break;
                case "TC_243411":
                    TC_243411();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_160101]

        #region[TP_159979]
        public static void TP_159979()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_244590":
                    TC_244590();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_159979]
        
        #region[TP_243159]
        public static void TP_243159()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_243197":
                    TC_243197();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_243159]

        #region[TP_243163]
        public static void TP_243163()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_243294":
                    TC_243294();
                    break;
                case "TC_243417":
                    TC_243417();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_243163]

        #region[TP_242772]
        public static void TP_242772()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_242784":
                    TC_242784();
                    break;
                case "TC_242805":
                    TC_242805();
                    break;
                case "TC_242789":
                    TC_242789();
                    break;
                case "TC_242812":
                    TC_242812();
                    break;
                case "TC_243245":
                    TC_243245();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_242772]

        #region[TP_243105]
        public static void TP_243105()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_243109":
                    TC_243109();
                    break;
                case "TC_243110":
                    TC_243110();
                    break;
                case "TC_243112":
                    TC_243112();
                    break;
                case "TC_243113":
                    TC_243113();
                    break;
                case "TC_243114":
                    TC_243114();
                    break;
                case "TC_243118":
                    TC_243118();
                    break;
                case "TC_243120":
                    TC_243120();
                    break;
                case "TC_243608":
                    TC_243608();
                    break;
                case "TC_160133":
                    TC_160133();
                    break;
                case "TC_243996":
                    TC_243996();
                    break;
                case "TC_244589":
                    TC_244589();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_243105]

        #region[TP_243876]
        public static void TP_243876()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_243878":
                    TC_243878();
                    break;
                case "TC_243948":
                    TC_243948();
                    break;
                case "TC_243949":
                    TC_243949();
                    break;
                case "TC_251550":
                    TC_251550();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_243876]

        #region[TP_244114]
        public static void TP_244114()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_244127":
                    TC_244127();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_244114]

        #region[TP_160103]
        public static void TP_160103()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_160960":
                    TC_160960();
                    break;
                case "TC_160961":
                    TC_160961();
                    break;
                case "TC_160962":
                    TC_160962();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_160103]

        #region[TP_207825]
        public static void TP_207825()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_207827":
                    TC_207827();
                    break;
                case "TC_207829":
                    TC_207829();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_207825]

        #region[TP_243161]
        public static void TP_243161()
        {
            AssignProfileID();
            switch (TestCaseId)
            {
                case "TC_243419":
                    TC_243419();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_243161]


    }
}
