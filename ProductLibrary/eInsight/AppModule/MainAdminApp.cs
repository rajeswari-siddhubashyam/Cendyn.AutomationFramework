using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using SqlWarehouse;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp
    {
        public static string audienceName = "";
        public static string getPageTitle = "";
        static string CompanyName = "";
        static string clientName = "";
        static string companyNameByTestCase = "";
        static string clientNameByTestCase = "";

        public static void AssignCompany()
        {
            if (testCategory == "QA")
            {
                CompanyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
                clientName = SqlWarehouseQuery.ReturnCompanyName("", "clientName", TestPlanId);
                companyNameByTestCase = SqlWarehouseQuery.ReturnCompanyNameByTestCase(TestCaseId, "CompanyName");
                clientNameByTestCase = SqlWarehouseQuery.ReturnCompanyNameByTestCase(TestCaseId, "clientName");
            }
            else if (testCategory == "EU01_PostDeployment")
            {
                CompanyName = "Jumeirah";
                clientName = "Jumeirah";
                companyNameByTestCase = "Jumeirah Nanjing OXI";
                clientNameByTestCase = "Jumeirah Nanjing OXI";
            }
            else
            {
                CompanyName = "Hotel Origami";
                clientName = "Hotel Origami";
                companyNameByTestCase = "Hotel Origami";
                clientNameByTestCase = "Hotel Origami";
            }

        }

        #region[AudienceBuilder]
        #region[TP_240125]
        public static void TP_240125()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_240127":
                    TC_240127();
                    break;
                case "TC_240128":
                    TC_240128();
                    break;
                case "TC_240129":
                    TC_240129();
                    break;
                case "TC_240133":
                    TC_240133();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_240125]

        #region[TP_240298]
        public static void TP_240298()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_238728":
                    TC_238728();
                    break;
                case "TC_238731":
                    TC_238731();
                    break;
                case "TC_238732":
                    TC_238732();
                    break;
                case "TC_239044":
                    TC_239044();
                    break;
                case "TC_239045":
                    TC_239045();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_240298]

        #region[TP_240302]
        public static void TP_240302()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_261225":
                    TC_261225();
                    break;
                case "TC_261830":
                    TC_261830();
                    break;
                case "TC_261833":
                    TC_261833();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_240302]

        #region[TP_240303]
        public static void TP_240303()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_240334":
                    TC_240334();
                    break;
                case "TC_240335":
                    TC_240335();
                    break;
                case "TC_240336":
                    TC_240336();
                    break;
                case "TC_240337":
                    TC_240337();
                    break;
                case "TC_240897":
                    TC_240897();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_240303]

        #region[TP_242047]
        public static void TP_242047()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_240153":
                    TC_240153();
                    break;
                case "TC_240154":
                    TC_240154();
                    break;
                case "TC_240155":
                    TC_240155();
                    break;
                case "TC_240156":
                    TC_240156();
                    break;
                case "TC_240157":
                    TC_240157();
                    break;
                case "TC_240144":
                    TC_240144();
                    break;
                case "TC_240145":
                    TC_240145();
                    break;
                case "TC_240146":
                    TC_240146();
                    break;
                case "TC_240847":
                    TC_240847();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_242047]

        #region[TP_247216]
        public static void TP_247216()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_245853":
                    TC_245853();
                    break;
                case "TC_245854":
                    TC_245854();
                    break;
                case "TC_245855":
                    TC_245855();
                    break;
                case "TC_245857":
                    TC_245857();
                    break;
                case "TC_245858":
                    TC_245858();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_247216]

        #region[TP_250054]
        public static void TP_250054()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_238356":
                    TC_238356();
                    break;
                case "TC_238749":
                    TC_238749();
                    break;
                case "TC_240347":
                    TC_240347();
                    break;
                case "TC_240407":
                    TC_240407();
                    break;
                case "TC_240408":
                    TC_240408();
                    break;
                case "TC_240431":
                    TC_240431();
                    break;
                case "TC_240432":
                    TC_240432();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_250054]

        #region[TP_251284]
        #endregion[TP_251284]

        #region[TP_262077]
        public static void TP_262077()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_262084":
                    TC_262084();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_262077]

        #region[TP_261306]
        public static void TP_261306()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_261051":
                    TC_261051();
                    break;
                case "TC_261310":
                    TC_261310();
                    break;
                case "TC_261312":
                    TC_261312();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_261306]

        #region[TP_243513]
        public static void TP_243513()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_243266":
                    TC_243266();
                    break;
                case "TC_243267":
                    TC_243267();
                    break;
                case "TC_243269":
                    TC_243269();
                    break;
                case "TC_243270":
                    TC_243270();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_243513]

        #region[TP_261351]
        public static void TP_261351()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_261391":
                    TC_261391();
                    break;
                case "TC_261396":
                    TC_261396();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_261351]

        #region[TP_242029]
        public static void TP_242029()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_237158":
                    TC_237158();
                    break;
                case "TC_237159":
                    TC_237159();
                    break;
                case "TC_237161":
                    TC_237161();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_242029]

        #region[TP_261803]
        public static void TP_261803()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_261806":
                    TC_261806();
                    break;
                case "TC_262015":
                    TC_262015();
                    break;
                case "TC_262347":
                    TC_262347();
                    break;
                case "TC_274525":
                    TC_274525();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_261803]

        #region[TP_261792]
        public static void TP_261792()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_261082":
                    TC_261082();
                    break;
                case "TC_262287":
                    TC_262287();
                    break;
                case "TC_262285":
                    TC_262285();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_261792]

        #region[TP_247212]
        public static void TP_247212()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_244751":
                    TC_244751();
                    break;
                case "TC_244111":
                    TC_244111();
                    break;
                case "TC_243186":
                    TC_243186();
                    break;
                case "TC_243192":
                    TC_243192();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_247212]


        #endregion[AudienceBuilder]

        #region[Home]
        #region[TP_97045]
        public static void TP_97045()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                #region[MarketingTab]
                case "TC_85789":
                    TC_85789();
                    break;
                case "TC_129807":
                    TC_129807();
                    break;
                case "TC_251644":
                    TC_251644();
                    break;
                case "TC_251645":
                    TC_251645();
                    break;
                case "TC_251646":
                    TC_251646();
                    break;
                case "TC_251699":
                    TC_251699();
                    break;
                #endregion[MarketingTab]
                #region[TransactionalTab]
                case "TC_98348":
                    TC_98348();
                    break;
                case "TC_98234":
                    TC_98234();
                    break;
                case "TC_98111":
                    TC_98111();
                    break;
                case "TC_130057":
                    TC_130057();
                    break;
                case "TC_251656":
                    TC_251656();
                    break;
                case "TC_251924":
                    TC_251924();
                    break;
                #endregion[TransactionalTab]
                #region[TriggerTab]
                case "TC_251662":
                    TC_251662();
                    break;
                case "TC_251664":
                    TC_251664();
                    break;
                case "TC_251666":
                    TC_251666();
                    break;
                case "TC_251667":
                    TC_251667();
                    break;
                case "TC_251668":
                    TC_251668();
                    break;
                case "TC_251700":
                    TC_251700();
                    break;
                #endregion[TriggerTab]
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_97045]

        #endregion[Home]

        #region[Login]
        #region[TP_215017]
        public static void TP_215017()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_215019":
                    TC_215019();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_215017]
        #endregion[Login]

        #region[ManageCampaign]

        #region[SendCampaign]
        #region[TP_124907]
        public static void TP_124907()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_102002":
                    TC_102002();
                    break;
                case "TC_73959":
                    TC_73959();
                    break;
                case "TC_131671":
                    TC_131671();
                    break;
                case "TC_124537":
                    TC_124537();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_124907]

        #endregion[SendCampaign]

        #region[CASLNotification]
        #region[TP_128226]
        public static void TP_128226()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_128429":
                    TC_128429();
                    break;
                case "TC_128430":
                    TC_128430();
                    break;
                case "TC_128432":
                    TC_128432();
                    break;
                case "TC_257224":
                    TC_257224();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_128226]

        #endregion[CASLNotification]

        #region[SubjestLine]
        #region[TP_174295]
        public static void TP_174295()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_174296":
                    TC_174296();
                    break;
                case "TC_174312":
                    TC_174312();
                    break;
                case "TC_174320":
                    TC_174320();
                    break;
                case "TC_174328":
                    TC_174328();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_174295]

        #endregion[SubjestLine]

        #region[CreateCampaign]
        #region[TP_197270]
        public static void TP_197270()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_508833":
                    TC_508833();
                    break;
                case "TC_508834":
                    TC_508834();
                    break;
                case "TC_508836":
                    TC_508836();
                    break;
                case "TC_128427":
                    TC_128427();
                    break;
                case "TC_197271":
                    TC_197271();
                    break;
                case "TC_197272":
                    TC_197272();
                    break;
                case "TC_197274":
                    TC_197274();
                    break;
                case "TC_197275":
                    TC_197275();
                    break;
                case "TC_197276":
                    TC_197276();
                    break;
                case "TC_198274":
                    TC_198274();
                    break;
                case "TC_198275":
                    TC_198275();
                    break;
                case "TC_198276":
                    TC_198276();
                    break;
                case "TC_198277":
                    TC_198277();
                    break;
                case "TC_198278":
                    TC_198278();
                    break;
                case "TC_198279":
                    TC_198279();
                    break;
                case "TC_198280":
                    TC_198280();
                    break;
                case "TC_236460":
                    //TC_236460();
                    break;
                case "TC_255907":
                    TC_255907();
                    break;
                case "TC_236459":
                    TC_236459();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_197270]

        #endregion[CreateCampaign]

        #region[FromName]
        #region[TP_259526]
        public static void TP_259526()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_258999":
                    TC_258999();
                    break;
                case "TC_258998":
                    TC_258998();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_259526]
        #endregion[FromName]

        #region[CriteriaSeedList]
        #region[TP_89853]
        public static void TP_89853()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_89856":
                    TC_89856();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_89853]
        #endregion[CriteriaSeedList]

        #region[DynamicContent]
        #region[PlainText]
        #region[TP_91643]
        public static void TP_91643()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_89923":
                    TC_89923();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_91643]
        #endregion[PlainText]
        #endregion[DynamicContent]
        #endregion[ManageCampaign]

        #region[Preferences]
        #region[TP_182388]
        public static void TP_182388()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_180170":
                    TC_180170();
                    break;
                case "TC_180171":
                    TC_180171();
                    break;
                case "TC_180173":
                    TC_180173();
                    break;
                case "TC_253876":
                    TC_253876();
                    break;
                case "TC_253877":
                    TC_253877();
                    break;
                case "TC_253878":
                    TC_253878();
                    break;
                case "TC_276644":
                    TC_276644();
                    break;
                case "TC_275950":
                    TC_275950();
                    break;
                case "TC_276675":
                    TC_276675();
                    break;
                case "TC_276683":
                    TC_276683();
                    break;
                case "TC_281936":
                    TC_281936();
                    break;
                case "TC_284361":
                    TC_284361();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_182388]

        #endregion[Preferences]

        #region[Profile]

        #region[TP_106791]
        public static void TP_106791()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_68068":
                    TC_68068();
                    break;
                case "TC_74653":
                    TC_74653();
                    break;
                case "TC_80078":
                    TC_80078();
                    break;
                case "TC_80080":
                    TC_80080();
                    break;
                case "TC_63959":
                    TC_63959();
                    break;
                case "TC_95717":
                    TC_95717();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_106791]

        #region[TP_166736]
        public static void TP_166736()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_152570":
                    TC_152570();
                    break;
                case "TC_152607":
                    TC_152607();
                    break;
                case "TC_152686":
                    TC_152686();
                    break;
                case "TC_168859":
                    TC_168859();
                    break;
                case "TC_171634":
                    TC_171634();
                    break;
                case "TC_171636":
                    TC_171636();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_166736]

        #region[TP_234025]
        public static void TP_234025()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_234161":
                    TC_234161();
                    break;
                case "TC_284072":
                    TC_284072();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_234025]

        #region[TP_86435]
        public static void TP_86435()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_97478":
                    TC_97478();
                    break;
                case "TC_97482":
                    TC_97482();
                    break;
                case "TC_80485":
                    TC_80485();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_86435]

        #region[TP_86434]
        public static void TP_86434()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_80235":
                    TC_80235();
                    break;
                case "TC_80287":
                    TC_80287();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_86434]


        #endregion[Profile]

        #region[PriorityQ]
        #region[Search]
        #region[TP_271585]
        public static void TP_271585()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_263323":
                    TC_263323();
                    break;
                case "TC_264145":
                    TC_264145();
                    break;
                case "TC_264147":
                    TC_264147();
                    break;
                case "TC_264150":
                    TC_264150();
                    break;
                case "TC_267308":
                    TC_267308();
                    break;
                case "TC_283238":
                    TC_283238();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_271585]

        #endregion[Search]

        #region[CampaignHistory]
        #region[TP_271591]
        public static void TP_271591()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_264700":
                    TC_264700();
                    break;
                case "TC_264703":
                    TC_264703();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_271591]
        #endregion[CampaignHistory]



        #region[PriorityQ - Send]
        #region[TP_271588]
        public static void TP_271588()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_264338":
                    TC_264338();
                    break;
                case "TC_264339":
                    TC_264339();
                    break;
                case "TC_264939":
                    TC_264939();
                    break;
                case "TC_265090":
                    TC_265090();
                    break;
                case "TC_265091":
                    TC_265091();
                    break;
                case "TC_265988":
                    TC_265988();
                    break;
                case "TC_265989":
                    TC_265989();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_271588]

        #endregion[PriorityQ - Send]

        #region[PriorityQ - Edit]
        #region[TP_271586]
        public static void TP_271586()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_263820":
                    TC_263820();
                    break;
                case "TC_263822":
                    TC_263822();
                    break;
                case "TC_264152":
                    TC_264152();
                    break;
                case "TC_264151":
                    TC_264151();
                    break;
                case "TC_264333":
                    TC_264333();
                    break;
                case "TC_264334":
                    TC_264334();
                    break;
                case "TC_264335":
                    TC_264335();
                    break;
                case "TC_265698":
                    TC_265698();
                    break;
                case "TC_265920":
                    TC_265920();
                    break;
                case "TC_267147":
                    TC_267147();
                    break;
                case "TC_267002":
                    TC_267002();
                    break;
                case "TC_275783":
                    TC_275783();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_271586]
        #endregion[PriorityQ - Edit]
        #endregion[PriorityQ]


        #region[PostDeployment]
        #region[TP_276287]
        public static void TP_276287()
        {
            AssignCompany();
            switch (TestCaseId)
            {
                case "TC_69785":
                    //TC_69785();
                    break;
                case "TC_102002":
                    TC_102002();
                    break;
                case "TC_129807":
                    TC_129807();
                    break;
                case "TC_130057":
                    TC_130057();
                    break;
                case "TC_251664":
                    TC_251664();
                    break;
                case "TC_198278":
                    TC_198278();
                    break;
                case "TC_261909":
                    TC_261909();
                    break;
                case "TC_276301":
                    TC_276301();
                    break;
                case "TC_276316":
                    TC_276316();
                    break;
                case "TC_284072":
                    TC_284072();
                    break;
                default:
                    Assert.Fail("TestCaseID did not find");
                    break;
            }
        }
        #endregion[TP_276287]

        #endregion[PostDeployment]
    }
}
