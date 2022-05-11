using System.ComponentModel;

namespace TestData
{
    public class Enums
    {
        public enum ClientName
        {
            [Description("HotelOrigami")]
            HotelOrigami,
            [Description("eMenus")]
            eMenus,
            [Description("ALL")]
            All,
            [Description("CendynAdmin")]
            CendynAdmin,
            [Description("RevIntel")]
            RevIntel,
            [Description("ePlanner")]
            ePlanner,
            [Description("eMenusLite")]
            eMenusLite,
            [Description("HotelOrigami_Production")]
            HotelOrigami_Production,
            [Description("AMR_Agent")]
            AMR_Agent,
            [Description("AMR_Agent_Production")]
            AMR_Agent_Production,
            [Description("MarketingAutoQA")]
            MarketingAutoQA,
            [Description("CHC_UP_AutoQA")]
            CHC_UP_AutoQA,
            [Description("MarketingAutoDEV")]
            MarketingAutoDEV,
            [Description("CMSQA")]
            CMSQA,
            [Description("CMSDEV")]
            CMSDEV,
            [Description("CHC_ConfigQA")]
            CHC_ConfigQA,
            [Description("CHC_ConfigDEV")]
            CHC_ConfigDEV
        }

        public enum TestDataType
        {
            [Description("FrontEnd")]
            FrontEnd,
            [Description("PropertyAdmin")]
            PropertyAdmin,
            [Description("CendynAdmin")]
            CendynAdmin,
            [Description("ProductionDefect")]
            ProductionDefect,
            [Description("Controller")]
            Controller,
            [Description("Admin")]
            Admin,
            [Description("ALL")]
            All,
            [Description("Kiosk")]
            Kiosk,
            [Description("RevIntel")]
            RevIntel,
            [Description("MarketingAuto")]
            MarketingAuto,
            [Description("CMS")]
            CMS,
            [Description("CHC_Config")]
            CHC_Config,
            
            [Description("CHCUPAuto")]
            CHCUPAuto
        }
        public enum CaseType
        {
            [Description("TestCase")]
            TestCase,
            [Description("Defect")]
            Defect,
            [Description("NA")]
            NA
        }

    }
}
