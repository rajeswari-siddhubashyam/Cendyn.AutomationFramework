using BaseUtility.Utility;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using TestData;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region Instance Variables
        public static string pattern = @"\s.*$";
        private static string customerID = "";
        private static string confirmationNumber = "";
        private static string email = "";
        private static string firstName = "";
        private static string lastName = "";
        public static string ReturntoLogin = "Login";
        public static string LoginLand = "Login";
        public static string MySettingsURL = "Settings";
        public static string ForgotPasswordURL = "PasswordRecovery";
        public static bool RecoveryGetURL = Driver.Url.Contains("PasswordRecoveryConfirm");
        public static string GetDate = DateTime.Now.ToString("MMddyyHHmmss");
        public static string CommomPassword = "Cendyn123$";
        protected static Random randomNumber = new Random();
        private static readonly Users data;
        #endregion

        #region Common Methods
        public static void LoginCredentials(string userName, string password, string projectName)
        {
            
            SignIn.LogIn(userName, password, projectName);
        }

        public static void AdminLoginCredentials(string userName, string password)
        {
            Admin.AdminLogin(userName, password);
         }       

        public static void MySettingWait(string Projectname)
        {
            AddDelay(3500);
            if (ProjectName.Equals("Fraser") || ProjectName.Equals("Iberostar"))
            {
                Helper.ElementWait(PageObject_Navigation.Link_MyAccount(), 60);
            }
            else if (ProjectName.Equals("Loews") || Projectname.Equals("Bartell") || Projectname.Equals("Sarova") || Projectname.Equals("EHPC"))
            {
                Helper.ElementWait(PageObject_Navigation.LinkText_MySettings(Projectname), 60);
            }
            else
            {
                Helper.ElementWait(PageObject_Navigation.Link_MySettings(), 60);
            }
        }
        #endregion

        public static void TP_121746()
        {
            switch (TestCaseId)
            {
                case "TC_119819":
                    TC_119819();
                    break;
                case "TC_119820":
                    TC_119820();
                    break;
                case "TC_119821":
                    TC_119821();
                    break;
                case "TC_119822":
                    TC_119822();
                    break;
                case "TC_119823":
                    TC_119823();
                    break;
                case "TC_153344":
                    TC_153344();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }
        public static void TP_171074()
        {
            switch (TestCaseId)
            {
                case "TC_221090":
                    TC_221090();
                    break;
                case "TC_113756":
                    TC_113756();
                    break;
                case "TC_221277":
                    TC_221277();
                    break;
                case "TC_221395":
                    TC_221395();
                    break;
                case "TC_221385":
                    TC_221385();
                    break;
                case "TC_113764":
                    TC_113764();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
                    /*
                    else if (TestCaseId == Constants.TC_113741) TC_113741();
                    else if (TestCaseId == Constants.TC_113742) TC_113742();
                    else if (TestCaseId == Constants.TC_113743) TC_113743();
                    else if (TestCaseId == Constants.TC_113744) TC_113744();
                    else if (TestCaseId == Constants.TC_113745) TC_113745();
                    else if (TestCaseId == Constants.TC_113746) TC_113746();
                    else if (TestCaseId == Constants.TC_113747) TC_113747();
                    else if (TestCaseId == Constants.TC_113748) TC_113748();
                    else if (TestCaseId == Constants.TC_113749) TC_113749();
                    else if (TestCaseId == Constants.TC_113751) TC_113751();
                    else if (TestCaseId == Constants.TC_113752) TC_113752();
                    else if (TestCaseId == Constants.TC_113753) TC_113753();
                    else if (TestCaseId == Constants.TC_113754) TC_113754();
                    else if (TestCaseId == Constants.TC_113755) TC_113755();
                    else if (TestCaseId == Constants.TC_113757) TC_113757();
                    else if (TestCaseId == Constants.TC_113758) TC_113758();
                    else if (TestCaseId == Constants.TC_113760) TC_113760();
                    else if (TestCaseId == Constants.TC_113761) TC_113761();
                    else if (TestCaseId == Constants.TC_113762) TC_113762();
                    else if (TestCaseId == Constants.TC_113763) TC_113763();
                    else if (TestCaseId == Constants.TC_114570) TC_114570();
                    */

            }
        }
        public static void TP_121741(string ProjectName)
        {
            switch (TestCaseId)
            {
                case "TC_120118":
                    TC_120118();
                    break;
                case "TC_120119":
                    TC_120119();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }
        public static void TP_239393()
        {
            switch (TestCaseId)
            {
                case "TC_216107":
                    TC_216107();
                    break;
                case "TC_224924":
                    TC_224924();
                    break;
                case "TC_238611":
                    TC_238611();
                    break;
                case "TC_237552":
                    TC_237552();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }
        public static void TP_121737()
        {
            switch (TestCaseId)
            {
                case "TC_219285":
                    TC_219285();
                    break;
                case "TC_219287":
                    TC_219287();
                    break;
                case "TC_219288":
                    TC_219288();
                    break;
                case "TC_124896":
                    TC_124896();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
            /*
            else if (TestCaseId == Constants.TC_119830) TC_119830();
            else if (TestCaseId == Constants.TC_119831) TC_119831();
            else if (TestCaseId == Constants.TC_119832) TC_119832();
            else if (TestCaseId == Constants.TC_119833) TC_119833();
            else if (TestCaseId == Constants.TC_119836) TC_119836();
            else if (TestCaseId == Constants.TC_119837) TC_119837();
            else if (TestCaseId == Constants.TC_119838) TC_119838();
            else if (TestCaseId == Constants.TC_119840) TC_119840();
            
            else if (TestCaseId == Constants.TC_124897) TC_124897();
            else if (TestCaseId == Constants.TC_124898) TC_124898();
            */
        }
        public static void TP_121740(string ProjectName)
        {
            switch (TestCaseId)
            {
                case "TC_219459":
                    TC_219459();
                    break;
                case "TC_219517":
                    TC_219517();
                    break;
                case "TC_219436":
                    TC_219436();
                    break;
                case "TC_120138":
                    TC_120138();
                    break;
                case "TC_124899":
                    TC_124899();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
            /*
            else if (TestCaseId == Constants.TC_120126) TC_120126();
            else if (TestCaseId == Constants.TC_120127) TC_120127();
            else if (TestCaseId == Constants.TC_120128) TC_120128();
            else if (TestCaseId == Constants.TC_120129) TC_120129();
            else if (TestCaseId == Constants.TC_120130) TC_120130();
            else if (TestCaseId == Constants.TC_120131) TC_120131();
            else if (TestCaseId == Constants.TC_120132) TC_120132();
            else if (TestCaseId == Constants.TC_120133) TC_120133();
            else if (TestCaseId == Constants.TC_120134) TC_120134();
            else if (TestCaseId == Constants.TC_120135) TC_120135();
            else if (TestCaseId == Constants.TC_120136) TC_120136();
            else if (TestCaseId == Constants.TC_120137) TC_120137();
      
            else if (TestCaseId == Constants.TC_166273) TC_166273();
            else if (TestCaseId == Constants.TC_166274) TC_166274();
            else if (TestCaseId == Constants.TC_166283) TC_166283();
            else if (TestCaseId == Constants.TC_125818) TC_125818();
            else if (TestCaseId == Constants.TC_166288) TC_166288();
            */
        }
        /** Admin AdminUpdate  **/
        public static void TP_156796()
        {
            switch (TestCaseId)
            {
                case "TC_221208":
                    TC_221208();
                    break;
                case "TC_221217":
                    TC_221217();
                    break;
                case "TC_155521":
                    TC_155521();
                    break;
                case "TC_151546":
                    TC_151546();
                    break;
                case "TC_151548":
                    TC_151548();
                    break;
                case "TC_151552":
                    TC_151552();
                    break;
                case "TC_151553":
                    TC_151553();
                    break;
                case "TC_151554":
                    TC_151554();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
            /* V3 test cases
            else if (TestCaseId == Constants.TC_151536) TC_151536();
            else if (TestCaseId == Constants.TC_151537) TC_151537();
            else if (TestCaseId == Constants.TC_151538) TC_151538();
            else if (TestCaseId == Constants.TC_151539) TC_151539();
            else if (TestCaseId == Constants.TC_151542) TC_151542();
            else if (TestCaseId == Constants.TC_151547) TC_151547();
            else if (TestCaseId == Constants.TC_151555) TC_151555();
            */
        }

        // Manual Merge
        public static void TP_166488(string ProjectName)
        {
            switch (TestCaseId)
            {
                case "TC_161150":
                    TC_161150();
                    break;
                case "TC_161135":
                    TC_161135();
                    break;
                case "TC_161136":
                    TC_161136();
                    break;
                case "TC_161137":
                    TC_161137();
                    break;
                case "TC_161117":
                    TC_161117();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }
        /** Admin Member Transaction  **/
        public static void TP_186848()
        {
            switch (TestCaseId)
            {
                case "TC_124365":
                    TC_124365();
                    break;
                case "TC_220655":
                    TC_220655();
                    break;
                case "TC_220919":
                    TC_220919();
                    break;
                case "TC_220954":
                    TC_220954();
                    break;
                case "TC_124380":
                    TC_124380();
                    break;
                case "TC_124383":
                    TC_124383();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
            
            /* Test Cases Moved from V3 to Global
            else if (TestCaseId == Constants.TC_124368) TC_124368();
            else if (TestCaseId == Constants.TC_124369) TC_124369();
            else if (TestCaseId == Constants.TC_124370) TC_124370();
            else if (TestCaseId == Constants.TC_124371) TC_124371();
            else if (TestCaseId == Constants.TC_124372) TC_124372();
            else if (TestCaseId == Constants.TC_124373) TC_124373();
            else if (TestCaseId == Constants.TC_124377) TC_124377();
            else if (TestCaseId == Constants.TC_124378) TC_124378();
            else if (TestCaseId == Constants.TC_124381) TC_124381();
            else if (TestCaseId == Constants.TC_124385) TC_124385();
            else if (TestCaseId == Constants.TC_142421) TC_142421();
            */
        }

        /** Admin Member Stay TP_186863**/
        public static void TP_186863()
        {
            switch (TestCaseId)
            {
                case "TC_124508":
                    TC_124508();
                    break;
                case "TC_124511":
                    TC_124511();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }

        /** Admin Member Level  TP_186887**/
        public static void TP_186887()
        {
            switch (TestCaseId)
            {
                case "TC_114355":
                    TC_114355();
                    break;
                case "TC_114356":
                    TC_114356();
                    break;
                case "TC_114357":
                    TC_114357();
                    break;
                case "TC_114358":
                    TC_114358();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }

        /** Admin Member Status  TP_186894 **/
        public static void TP_186894()
        {
            switch (TestCaseId)
            {
                case "TC_111604":
                    TC_111604();
                    break;
                case "TC_111605":
                    TC_111605();
                    break;
                case "TC_111606":
                    TC_111606();
                    break;
                case "TC_111607":
                    TC_111607();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }

        /** Admin Member Reset TP_186906 **/
        public static void TP_186906()
        {
            switch (TestCaseId)
            {
                case "TC_115262":
                    TC_115262();
                    break;
                case "TC_115265":
                    TC_115265();
                    break;
                case "TC_115266":
                    TC_115266();
                    break;
                case "TC_115267":
                    TC_115267();
                    break;
                default:
                    Assert.Fail("No Such Test Case found");
                    break;
            }
        }

        /** Admin Member Search Stay TP_186921 **/
        public static void TP_186921()
        {
            if (TestCaseId == Constants.TC_221383) TC_221383();
            else if (TestCaseId == Constants.TC_146642) TC_146642();
            else if (TestCaseId == Constants.TC_221400) TC_221400();
            else if (TestCaseId == Constants.TC_221412) TC_221412();
            else if (TestCaseId == Constants.TC_147010) TC_147010();
            else if (TestCaseId == Constants.TC_147013) TC_147013();
            /* V3 Test Cases
            else if (TestCaseId == Constants.TC_146636) TC_146636();
            else if (TestCaseId == Constants.TC_146637) TC_146637();
            else if (TestCaseId == Constants.TC_146638) TC_146638();
            else if (TestCaseId == Constants.TC_146639) TC_146639();
            else if (TestCaseId == Constants.TC_146643) TC_146643();
            else if (TestCaseId == Constants.TC_146644) TC_146644();
            else if (TestCaseId == Constants.TC_146645) TC_146645();
            else if (TestCaseId == Constants.TC_146646) TC_146646();
            else if (TestCaseId == Constants.TC_147007) TC_147007();
            else if (TestCaseId == Constants.TC_147008) TC_147008();
            else if (TestCaseId == Constants.TC_149105) TC_149105();
            */
        }


        /** Admin Member Login  TP_190877 **/
        public static void TP_190877()
        {
            if (TestCaseId == Constants.TC_147736) TC_147736();
            else if (TestCaseId == Constants.TC_147743) TC_147743();
            else if (TestCaseId == Constants.TC_147747) TC_147747();
            else if (TestCaseId == Constants.TC_147748) TC_147748();
            else if (TestCaseId == Constants.TC_147758) TC_147758();
            else if (TestCaseId == Constants.TC_147759) TC_147759();
        }

        //Admin Smoke End to End TP_193880

        public static void TP_193880(string ProjectName)
        {
            if (TestCaseId == Constants.TC_194035) TC_194035();
            else if (TestCaseId == Constants.TC_194195) TC_194195();
            else if (TestCaseId == Constants.TC_194218) TC_194218();
            else if (TestCaseId == Constants.TC_194219) TC_194219();
            else if (TestCaseId == Constants.TC_194221) TC_194221();
            else if (TestCaseId == Constants.TC_194222) TC_194222();
            else if (TestCaseId == Constants.TC_194231) TC_194231();
            else if (TestCaseId == Constants.TC_194235) TC_194235();
            else if (TestCaseId == Constants.TC_194240) TC_194240();
            else if (TestCaseId == Constants.TC_194242) TC_194242();
            else if (TestCaseId == Constants.TC_141476) TC_141476();
            else if (TestCaseId == Constants.TC_222075) TC_222075();
            else if (TestCaseId == Constants.TC_222092) TC_222092();
            else if (TestCaseId == Constants.TC_209620) TC_209620();
            else if (TestCaseId == Constants.TC_189006) TC_189006();
            else if (TestCaseId == Constants.TC_218604) TC_218604();
            else if (TestCaseId == Constants.TC_218599) TC_218599();
            else if (TestCaseId == Constants.TC_227232) TC_227232();
            else if (TestCaseId == Constants.TC_221131) TC_221131();
            else if (TestCaseId == Constants.TC_194749) TC_194749();
            else if (TestCaseId == Constants.TC_242619) TC_242619();
            else if (TestCaseId == Constants.TC_109687) TC_109687();
            else if (TestCaseId == Constants.TC_239389) TC_239389();
            //else if (TestCaseId == Constants.TC_208722) TC_208722();
            else if (TestCaseId == Constants.TC_116201) TC_116201();
            else if (TestCaseId == Constants.TC_226427) TC_226427();
            else if (TestCaseId == Constants.TC_237408) TC_237408();
            else if (TestCaseId == Constants.TC_226431) TC_226431();
            else if (TestCaseId == Constants.TC_272803) TC_272803();


        }

        //Signup Valdation
        public static void TP_121735(string ProjectName)
        {
            if (TestCaseId == Constants.TC_119758) TC_119758();
            else if (TestCaseId == Constants.TC_119759) TC_119759();
            else if (TestCaseId == Constants.TC_119760) TC_119760();
            else if (TestCaseId == Constants.TC_119761) TC_119761();
        }
        //SignUp with PMS User 
        public static void TP_121734(string ProjectName)
        {
            if (TestCaseId == Constants.TC_119748) TC_119748();
            else if (TestCaseId == Constants.TC_119749) TC_119749();
            else if (TestCaseId == Constants.TC_119750) TC_119750();
            else if (TestCaseId == Constants.TC_119751) TC_119751();
            else if (TestCaseId == Constants.TC_119752) TC_119752();
            else if (TestCaseId == Constants.TC_119753) TC_119753();
            else if (TestCaseId == Constants.TC_119754) TC_119754();
        }

        #region Test Plan Methods - Production Defect 
        public static void TP_ProductionDefect()
        {
            D_222631();
            D_222706();
            D_222707();
        }

        public static void TP_JulyDefect()
        {
            D_220805();
            D_221237();
            D_221661();
            D_221720();
            D_221120();
            D_221663();
            D_221461();
            D_221118();
            D_221403();
        }
        #endregion

        public static void TP_218533(string ProjectName)
        {
            TC_218547();
            TC_218535();
            TC_218540(ProjectName);
            TC_218534();
            TC_185011();
            TC_185012();
            TC_223757();
            TC_217847();
            TC_109958();
            TC_109959();
            TC_119763();
            TC_113317();
            TC_119760();
            TC_112091();
            TC_112093();
            TC_112269(ProjectName);
            TC_112270();
            TC_112275();
            TC_112423();
            TC_112426();
            TC_223768();
            TC_223767();
            TC_223762();
            TC_223760();
        }

        //Admin Membership setup
        public static void TP_256428()
        {
                if (TestCaseId == Constants.TC_255553) TC_255553();
                else if (TestCaseId == Constants.TC_255554) TC_255554();
                else if (TestCaseId == Constants.TC_255556) TC_255556();
                else if (TestCaseId == Constants.TC_255563) TC_255563();
                else if (TestCaseId == Constants.TC_255557) TC_255557();
                else if (TestCaseId == Constants.TC_255559) TC_255559();
                else if (TestCaseId == Constants.TC_255575) TC_255575();
                else if (TestCaseId == Constants.TC_255561) TC_255561();
                else if (TestCaseId == Constants.TC_255562) TC_255562();
                else if (TestCaseId == Constants.TC_255564) TC_255564();

                else if (TestCaseId == Constants.TC_255578) TC_255578();
                else if (TestCaseId == Constants.TC_255574) TC_255574();
                else if (TestCaseId == Constants.TC_255573) TC_255573();
                else if (TestCaseId == Constants.TC_255572) TC_255572();
                else if (TestCaseId == Constants.TC_255576) TC_255576();
                else if (TestCaseId == Constants.TC_255577) TC_255577();
        }

        //Loyalty Redmption
        public static void TP_224753()
        {
            if (TestCaseId == Constants.TC_146567) TC_146567();
            else if (TestCaseId == Constants.TC_146564) TC_146564();
            else if (TestCaseId == Constants.TC_149354) TC_149354();
            else if (TestCaseId == Constants.TC_146568) TC_146568();
            else if (TestCaseId == Constants.TC_146563) TC_146563();
            else if (TestCaseId == Constants.TC_149352) TC_149352();
            else if (TestCaseId == Constants.TC_149351) TC_149351();
            else if (TestCaseId == Constants.TC_149349) TC_149349();
            else if (TestCaseId == Constants.TC_149357) TC_149357();
            else if (TestCaseId == Constants.TC_124627) TC_124627();
            else if (TestCaseId == Constants.TC_124625) TC_124625();
            else if (TestCaseId == Constants.TC_124626) TC_124626();
            else if (TestCaseId == Constants.TC_175101) TC_175101();

        }

        //Admin Memmber Award
        public static void TP_240322()
        {
            
            if (TestCaseId == Constants.TC_116979) TC_116979();
            else if (TestCaseId == Constants.TC_116403) TC_116403();
            else if (TestCaseId == Constants.TC_116980) TC_116980();
            else if (TestCaseId == Constants.TC_116978) TC_116978();
            else if (TestCaseId == Constants.TC_116401) TC_116401();
            else if (TestCaseId == Constants.TC_116402) TC_116402();
            else if (TestCaseId == Constants.TC_116404) TC_116404();
            else if (TestCaseId == Constants.TC_264758) TC_264758();
            else if (TestCaseId == Constants.TC_130237) TC_130237();
            

        }

        //Admin Offers

        public static void TP_267462()
        {
            if (TestCaseId == Constants.TC_110850) TC_110850();
        }

        public static void TP_184976()
        {
            switch(TestCaseId)
            {
                case "TC_184988":
                    TC_184988();
                    break;
            }
        }

        // Portal Membership Card
        public static void TP_240447(string ProjectName)
        {
            if (TestCaseId == Constants.TC_112899) TC_112899();
            else if (TestCaseId == Constants.TC_113079) TC_113079();
                        
        }
        
        //Loyalty Rule - Member Level Rule
        public static void TP_268973()
        {
            if (TestCaseId == Constants.TC_217871) TC_217871();
            else if (TestCaseId == Constants.TC_217878) TC_217878();
            else if (TestCaseId == Constants.TC_217879) TC_217879();
            else if (TestCaseId == Constants.TC_218238) TC_218238();
            else if (TestCaseId == Constants.TC_217877) TC_217877();
            else if (TestCaseId == Constants.TC_217874) TC_217874();
        }
        //Loyalty Rule - Point Earning Rule

        public static void TP_111963()
        {
            if (TestCaseId == Constants.TC_114486) TC_114486();
            else if (TestCaseId == Constants.TC_114488) TC_114488();
            else if (TestCaseId == Constants.TC_114489) TC_114489();
            else if (TestCaseId == Constants.TC_114490) TC_114490();
            else if (TestCaseId == Constants.TC_224606) TC_224606();
            else if (TestCaseId == Constants.TC_188991) TC_188991();
            else if (TestCaseId == Constants.TC_113457) TC_113457();
            else if (TestCaseId == Constants.TC_116140) TC_116140();
            else if (TestCaseId == Constants.TC_113454) TC_113454();
            else if (TestCaseId == Constants.TC_116328) TC_116328();
            else if (TestCaseId == Constants.TC_116329) TC_116329();
            else if (TestCaseId == Constants.TC_219503) TC_219503();
            else if (TestCaseId == Constants.TC_220672) TC_220672();


        }
        
        //Loyalty Rule - Qualifying Rule

        public static void TP_240750()
        {
            if (TestCaseId == Constants.TC_122056) TC_122056();
            else if (TestCaseId == Constants.TC_209606) TC_209606();
            else if (TestCaseId == Constants.TC_240753) TC_240753();
            else if (TestCaseId == Constants.TC_209605) TC_209605();
        }

        public static void TP_264509()
        {
            switch (TestCaseId)
            {
                case "TC_264512":
                    TC_264512();
                    break;
                case "TC_264521":
                    TC_264521();
                    break;
            }
        }
        public static void TP_109659()
        {
            switch (TestCaseId)
            {
                case "TC_109696":
                    TC_109696();
                    break;
                case "TC_109697":
                    TC_109697();
                    break;
                case "TC_109698":
                    TC_109698();
                    break;
                case "TC_109699":
                    TC_109699();
                    break;
                case "TC_109700":
                    TC_109700();
                    break;
                case "TC_109701":
                    TC_109701();
                    break;
                case "TC_109665":
                    TC_109665();
                    break;
                case "TC_109666":
                    TC_109666();
                    break;
                case "TC_109667":
                    TC_109667();
                    break;
            }
                        
        }
        public static void TP_109729()
        {
            if (TestCaseId == Constants.TC_109737) TC_109737();
            else if (TestCaseId == Constants.TC_109738) TC_109738();
            else if (TestCaseId == Constants.TC_109739) TC_109739();
        }
        public static void TP_AutoIT()
        {
            switch (TestCaseId)
            {
                case "TC_109684":
                    TC_109684();
                    break;
                case "TC_109685":
                    TC_109685();
                    break;
                case "TC_109686":
                    TC_109686();
                    break;
                case "TC_109688":
                    TC_109688();
                    break;
                case "TC_109689":
                    TC_109689();
                    break;
                case "TC_109750":
                    TC_109750();
                    break;
                case "TC_109667":
                    TC_109667();
                    break;
                case "TC_224924":
                    TC_224924();
                    break;
                case "TC_237552":
                    TC_237552();
                    break;
                case "TC_238611":
                    TC_238611();
                    break;
                case "TC_109687":
                    TC_109687();
                    break;
                case "TC_116201":
                    TC_116201();
                    break;
                case "TC_218599":
                    TC_218599();
                    break;
                case "TC_218604":
                    TC_218604();
                    break;
                case "TC_227232":
                    TC_227232();
                    break;
                    
            }
        }
        //Admin Post Deployment TP_189000
        public static void TP_189000(string ProjectName)
        {
            if (TestCaseId == Constants.TC_115262) TC_115262();
            else if (TestCaseId == Constants.TC_189002) TC_189002();
            else if (TestCaseId == Constants.TC_189003) TC_189003();
            else if (TestCaseId == Constants.TC_189006) TC_189006();
            else if (TestCaseId == Constants.TC_194749) TC_194749();
            else if (TestCaseId == Constants.TC_221385) TC_221385();

        }

        //Portal Post Deployment TP_185010
        public static void TP_185010(string ProjectName)
        {
            if (TestCaseId == Constants.TC_124896) TC_124896();
            else if (TestCaseId == Constants.TC_120138) TC_120138();
            else if (TestCaseId == Constants.TC_254265) TC_254265();
            else if (TestCaseId == Constants.TC_185011) TC_185011();
            else if (TestCaseId == Constants.TC_185012) TC_185012();
            else if (TestCaseId == Constants.TC_254266) TC_254266();
        }
        public static void Production_SmokeTestPlan()
        {
            if (TestCaseId == Constants.TC_119819) TC_119819();
            else if (TestCaseId == Constants.TC_219287) TC_219287();
            else if (TestCaseId == Constants.TC_128801) TC_128801();
            else if (TestCaseId == Constants.TC_184988) TC_184988();
        }
        //Service Testing Pre-Conditions
        public static void TP_Service_Preconditions()
        {

            switch (TestCaseId)
            {
                case "TC_Restore_DB":
                    TC_Restore_DB();
                    break;
                case "TC_Backup_DB":
                    TC_Backup_DB();
                    break;
                default:
                    Assert.Fail("Unable to Find the Test case");
                    break;
            }
        }
        public static void Service_Pre_Requisite()
        {

            switch (TestCaseId)
            {
                case "TC_CreateUser_UpdateRegistrationDate":
                    TC_CreateUser_UpdateRegistrationDate();
                    break;
                case "TC_InsertRule":
                    TC_InsertRule();
                    break;
                case "TC_InsertStay01_12":
                    TC_InsertStay01_12();
                    break;
                case "TC_InsertStay13_30":
                    TC_InsertStay13_30();
                    break;
                case "TC_UpdateQualifyingRuleFor_1to12":
                    TC_UpdateQualifyingRuleFor_1to12();
                    break;
                case "TC_UpdateQualifyingRuleFor_13to29":
                    TC_UpdateQualifyingRuleFor_13to29();
                    break;
                case "TC_InactiveRules1_4":
                    TC_InactiveRules1_4();
                    break;
                case "TC_InsertStay21_42":
                    TC_InsertStay21_42();
                    break;
                default:
                    Assert.Fail("Unable to Find the Test case");
                    break;
            }
        }
        public static void TP_276897()
        {
            switch (TestCaseId)
            {
                case "TC_276900":
                    TC_276900();
                    break;
                case "TC_276901":
                    TC_276901();
                    break;
                case "TC_276902":
                    TC_276902();
                    break;
                case "TC_276903":
                    TC_276903();
                    break;
                case "TC_276904":
                    TC_276904();
                    break;
                case "TC_276905":
                    TC_276905();
                    break;
                case "TC_276906":
                    TC_276906();
                    break;
                case "TC_276907":
                    TC_276907();
                    break;
                case "TC_276908":
                    TC_276908();
                    break;
                case "TC_276909":
                    TC_276909();
                    break;
                case "TC_276910":
                    TC_276910();
                    break;
                case "TC_276911":
                    TC_276911();
                    break;
                case "TC_276912":
                    TC_276912();
                    break;
                case "TC_276913":
                    TC_276913();
                    break;
                case "TC_276914":
                    TC_276914();
                    break;
                case "TC_276915":
                    TC_276915();
                    break;
                case "TC_276916":
                    TC_276916();
                    break;
                case "TC_276917":
                    TC_276917();
                    break;
                case "TC_276919":
                    TC_276919();
                    break;
                case "TC_276920":
                    TC_276920();
                    break;
                case "TC_276921":
                    TC_276921();
                    break;
                case "TC_276922":
                    TC_276922();
                    break;
                case "TC_276923":
                    TC_276923();
                    break;
                case "TC_276924":
                    TC_276924();
                    break;
                case "TC_276925":
                    TC_276925();
                    break;
                case "TC_276926":
                    TC_276926();
                    break;
                case "TC_276927":
                    TC_276927();
                    break;
                case "TC_276928":
                    TC_276928();
                    break;
                case "TC_276929":
                    TC_276929();
                    break;
                default:
                    Assert.Fail("Unable to Find the Test case");
                    break;

            }

        }

        public static void TP_294919()
        {
            switch (TestCaseId)
            {
                case "TC_294921":
                    TC_294921();
                    break;
                case "TC_294922":
                    TC_294922();
                    break;
                case "TC_294923":
                    TC_294923();
                    break;
                case "TC_294924":
                    TC_294924();
                    break;
                case "TC_294925":
                    TC_294925();
                    break;
                case "TC_294926":
                    TC_294926();
                    break;
                case "TC_294927":
                    TC_294927();
                    break;
                case "TC_294928":
                    TC_294928();
                    break;
                case "TC_294929":
                    TC_294929();
                    break;
                case "TC_294930":
                    TC_294930();
                    break;
                case "TC_294931":
                    TC_294931();
                    break;
                case "TC_294932":
                    TC_294932();
                    break;
                case "TC_294933":
                    TC_294933();
                    break;
                case "TC_294935":
                    TC_294935();
                    break;
                case "TC_294934":
                    TC_294934();
                    break;
                case "TC_294936":
                    TC_294936();
                    break;
                case "TC_294937":
                    TC_294937();
                    break;
                case "TC_294938":
                    TC_294938();
                    break;
                case "TC_294939":
                    TC_294939();
                    break;
                case "TC_294940":
                    TC_294940();
                    break;
                case "TC_294941":
                    TC_294941();
                    break;
                case "TC_294942":
                    TC_294942();
                    break;
                default:
                    Assert.Fail("Unable to Find the Test case");
                    break;

            }

        }
    }
}
