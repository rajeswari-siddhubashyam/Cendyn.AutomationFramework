using System;

namespace TestData
{
    public class eLoyaltyV3
    {
        public static string Project_Path { get; set; }
        #region Add Test Data
        public static void AddELoyaltyData(string clientName)
        {
            AddTestData_ClientConfig(clientName);
            AddTestData_CRMAPI();
            AddTestData_Admin(clientName);
            AddTestData_FrontEnd(clientName);
        }

        private static void AddTestData_ClientConfig(string clientName)
        {
            TestDataHelper.AddTestData_ClientConfig("AdareManor", "http://adareguestloyaltyadminqa.cendyn.com/", "adaremanoradmin@cendyn.com", "http://adareguestloyaltyqa.cendyn.com", "https://adareguestloyaltyqa.cendyn.com/signupkiosk", "B204BBFF", "qatestAuto@cendyn17.com");
            TestDataHelper.AddTestData_ClientConfig("AquaAston", "https://guestloyaltyadminaquaastonqa.cendyn.com", "aquaaston_automation@cendyn17.com", "", "", "E4A0188C", "");
            TestDataHelper.AddTestData_ClientConfig("Bartell", "https://bartellhotelsguestloyaltyadminqa.cendyn.com/en-US", "bartell_admin_automation_qa@cendyn17.com", "https://bartellhotelsguestloyaltyqa.cendyn.com", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("Fraser", "https://guestloyaltyadminfraserqa.cendyn.com", "fraser_admin_automation_qa@cendyn17.com", "https://fraserguestloyaltyqa.cendyn.com/en-US/Login", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("HotelOrigami", "https://origamiguestloyaltyadminqa.cendyn.com", "origamiautomationuser@cendyn17.com", "https://origami.qaeloyaltyportal.com/", "", "", "");
            TestDataHelper.AddRecord("HotelOrigami", "FrontEnd", "NA", "0", "0", "1", "TRUE", "Username", "origamifrontautomationuser@cendyn17.com");

            TestDataHelper.AddTestData_ClientConfig("MyPlace", "https://myplaceguestloyaltyadminqa.cendyn.com", "myplaceadmin@cendyn17.com", "https://myplaceloyaltyqa.cendyn.com/", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("PublicHotel", "https://guestloyaltyadminpublichotelqa.cendyn.com/", "publichoteladmin@cendyn.com", "https://publichotelsguestloyaltyqa.cendyn.com", "https://publichotelsguestloyaltyqa.cendyn.com/signupkiosk", "B675BF02", "qatestAuto@cendyn17.com");
            TestDataHelper.AddTestData_ClientConfig("Sarova", "https://sarovahotelsguestloyaltyadminqa.cendyn.com", "sarova_admin_automation_qa@cendyn17.com", "https://sarovahotelsguestloyaltyqa.cendyn.com", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("SH", "https://shgroupguestloyaltyadminqa.cendyn.com/en-US", "sh_admin_automation_qa@cendyn17.com", "http://hotelvicguestloyaltyqa.cendyn.com", "http://hotelvicguestloyaltyqa.cendyn.com/signupkiosk", "C67BC377", "");
            TestDataHelper.AddTestData_ClientConfig("WoodLoch", "https://guestloyaltyadminthelodgeatwoodlochqa.cendyn.com/en-US", "lodgewoodlochAdmin@cendyn17.com", "http://thelodgeatwoodlochguestloyaltyqa.cendyn.com", "http://WoodLochguestloyaltyqa.cendyn.com/signupkiosk", "C67BC377", "");
            TestDataHelper.AddTestData_ClientConfig("Virgin", "https://VirginHotelguestloyaltyadminqa.cendyn.com", "virgin_admin_automation_qa@cendyn17.com", "", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("Almanac", "http://almanacguestloyaltyadminqa.cendyn.com", "almanacadmin@cendyn.com", "", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("HotelIcon", "http://hoteliconguestadminqa.cendyn.com/", "hoteliconadmin@cendyn.com", "http://hoteliconguestloyaltyqa.cendyn.com/", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("IndependentCollection", "https://independentcollectionguestadminqa.cendyn.com/", "independentadmin@cendyn.com", "https://independentcollectionloyaltyqa.cendyn.com", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("EHPC", "https://ehpcguestloyaltyadminqa.cendyn.com", "cendynadmin@cendyn17.com", "https://ehpchotelguestloyaltyqa.cendyn.com", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("Sacher", "https://sacherhotelsguestloyaltyadminqa.cendyn.com/en-US", "sacher_admin_automation_qa@cendyn17.com", "https://sacherhotelsguestloyaltyqa.cendyn.com/en-US", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("AMR", "https://guestloyaltyadminamresortsqa.cendyn.com/en-US", "AMRAdmin@cendyn.com", "https://amresortsguestloyaltyqa.cendyn.com/en-US/Login", "", "", "");

            TestDataHelper.AddTestData_ClientConfig("eMenusAdmin", "https://democendynadmin.menusaccess.com", "qacendyn@cendyn17.com", "", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("HotelOrigami_Production", "https://guestloyaltyadminorigamidemo.cendyn.com", "Automationadmin@cendyn17.com", "https://origamiloyalty.cendyn.com/en-US", "", "", "");
        }

        private static void AddTestData_CRMAPI()
        {
            TestDataHelper.AddRecord("ALL", "CRMAPI", "NA", "0", "0", "1", "TRUE", "Username", "LOYALTY");
            TestDataHelper.AddRecord("ALL", "CRMAPI", "NA", "0", "0", "1", "TRUE", "Password", "LOY#912765");
        }

        private static void AddTestData_Admin(string clientName)
        {
            AddTestData_Admin_TC_111604(clientName);
            AddTestData_Admin_TC_111605(clientName);
            AddTestData_Admin_TC_111606(clientName);
            AddTestData_Admin_TC_111607(clientName);
            AddTestData_Admin_TC_115267(clientName);
            AddTestData_Admin_TC_124362(clientName);
            AddTestData_Admin_TC_124364(clientName);
            AddTestData_Admin_TC_124365(clientName);
            AddTestData_Admin_TC_124368(clientName);
            AddTestData_Admin_TC_124369(clientName);
            AddTestData_Admin_TC_124370(clientName);
            AddTestData_Admin_TC_124371(clientName);
            AddTestData_Admin_TC_124372(clientName);
            AddTestData_Admin_TC_124373(clientName);
            AddTestData_Admin_TC_124377(clientName);
            AddTestData_Admin_TC_124378(clientName);
            AddTestData_Admin_TC_124380(clientName);
            AddTestData_Admin_TC_124381(clientName);
            AddTestData_Admin_TC_124383(clientName);
            AddTestData_Admin_TC_124385(clientName);
            AddTestData_Admin_TC_124497(clientName);
            AddTestData_Admin_TC_124508(clientName);
            AddTestData_Admin_TC_141476(clientName);
            AddTestData_Admin_TC_142421(clientName);
            AddTestData_Admin_TC_146636(clientName);
            AddTestData_Admin_TC_146637(clientName);
            AddTestData_Admin_TC_146638(clientName);
            AddTestData_Admin_TC_146639(clientName);
            AddTestData_Admin_TC_146642(clientName);
            AddTestData_Admin_TC_146643(clientName);
            AddTestData_Admin_TC_146644(clientName);
            AddTestData_Admin_TC_146645(clientName);
            AddTestData_Admin_TC_146646(clientName);
            AddTestData_Admin_TC_147007(clientName);
            AddTestData_Admin_TC_147010(clientName);
            AddTestData_Admin_TC_147013(clientName);
            AddTestData_Admin_TC_147743(clientName);
            AddTestData_Admin_TC_147758(clientName);
            AddTestData_Admin_TC_151537(clientName);
            AddTestData_Admin_TC_151539(clientName);
            AddTestData_Admin_TC_151542(clientName);
            AddTestData_Admin_TC_151547(clientName);
            AddTestData_Admin_TC_151553(clientName);
            AddTestData_Admin_TC_151555(clientName);
            AddTestData_Admin_TC_155521(clientName);
            AddTestData_Admin_TC_188666(clientName);
            AddTestData_Admin_TC_188667(clientName);
            AddTestData_Admin_TC_194035(clientName);
            AddTestData_Admin_TC_194195(clientName);
            AddTestData_Admin_TC_194218(clientName);
            AddTestData_Admin_TC_194219(clientName);
            AddTestData_Admin_TC_194221(clientName);
            AddTestData_Admin_TC_194222(clientName);
            AddTestData_Admin_TC_194231(clientName);
            AddTestData_Admin_TC_194242(clientName);
            AddTestData_Admin_TC_209620(clientName);
            AddTestData_Admin_TC_218599(clientName);
            AddTestData_Admin_TC_218604(clientName);
            AddTestData_Admin_TC_220655(clientName);
            AddTestData_Admin_TC_220919(clientName);
            AddTestData_Admin_TC_220954(clientName);
            AddTestData_Admin_TC_221208(clientName);
            AddTestData_Admin_TC_221383(clientName);
            AddTestData_Admin_TC_221400(clientName);
            AddTestData_Admin_TC_222075(clientName);
            AddTestData_Admin_TC_222092(clientName);
            AddTestData_Admin_TC_227232(clientName);
            AddTestData_Admin_TC_221131(clientName);
            AddTestData_Admin_TC_194749(clientName);
            AddTestData_Admin_TC_242619(clientName);
            AddTestData_Admin_TC_109687(clientName);
            AddTestData_Admin_TC_208722(clientName);
            AddTestData_Admin_TC_116201(clientName);
            AddTestData_Admin_TC_226427(clientName);
            AddTestData_Admin_TC_226431(clientName);
            AddTestData_Admin_TC_255553();
            AddTestData_Admin_TC_255554();
            AddTestData_Admin_TC_255556();
            AddTestData_Admin_TC_255563();
            AddTestData_Admin_TC_255557();
            AddTestData_Admin_TC_255559();
            AddTestData_Admin_TC_255575();
            AddTestData_Admin_TC_255561();
            AddTestData_Admin_TC_255562();
            AddTestData_Admin_TC_255564();
            AddTestData_Admin_TC_255573();
            AddTestData_Admin_TC_255574();
            AddTestData_Admin_TC_255578();
            AddTestData_Admin_TC_255576();
            AddTestData_Admin_TC_255577();
            AddTestData_Admin_TC_146564();
            AddTestData_Admin_TC_149354();
            AddTestData_Admin_TC_146567();
            AddTestData_Admin_TC_146568();
            AddTestData_Admin_TC_116980();
            AddTestData_Admin_TC_116978();
            AddTestData_Admin_TC_116401();
            AddTestData_Admin_TC_116402();
            AddTestData_Admin_TC_116404();
            AddTestData_Admin_TC_264758();
            AddTestData_Admin_TC_130237();
            AddTestData_Admin_TC_109684();
            AddTestData_Admin_TC_109686();
            AddTestData_Admin_TC_109688();
            AddTestData_Admin_TC_109689();
            AddTestData_Admin_TC_109750();
            AddTestData_Admin_TC_109685();
            AddTestData_Admin_TC_255572();
            AddTestData_Admin_TC_146563();
            AddTestData_Admin_TC_149352();
            AddTestData_Admin_TC_149351();
            AddTestData_Admin_TC_149349();
            AddTestData_Admin_TC_149357();
            AddTestData_Admin_TC_217871();
            AddTestData_Admin_TC_217877();
            AddTestData_Admin_TC_217878();
            AddTestData_Admin_TC_217879();
            AddTestData_Admin_TC_218238();
            AddTestData_Admin_TC_217874();
            AddTestData_Admin_TC_114486();
            AddTestData_Admin_TC_114488();
            AddTestData_Admin_TC_114489();
            AddTestData_Admin_TC_114490();
            AddTestData_Admin_TC_224606();
            AddTestData_Admin_TC_188991();
            AddTestData_Admin_TC_124627();
            AddTestData_Admin_TC_124625();
            AddTestData_Admin_TC_124626();
            AddTestData_Admin_TC_175101();
            AddTestData_Admin_TC_122056();
            AddTestData_Admin_TC_209606();
            AddTestData_Admin_TC_240753();
            AddTestData_Admin_TC_209605();
            AddTestData_Admin_TC_113457();
            AddTestData_Admin_TC_116140();
            AddTestData_Admin_TC_116141();
            AddTestData_Admin_TC_113454();
            AddTestData_Admin_TC_116328();
            AddTestData_Admin_TC_219503();
            AddTestData_Admin_TC_264512();
            AddTestData_Admin_TC_264521();
            AddTestData_Admin_TC_272803();
            AddTestData_Admin_TC_109696();
            AddTestData_Admin_TC_109697();
            AddTestData_Admin_TC_109698();
            AddTestData_Admin_TC_109699();
            AddTestData_Admin_TC_109700();
            AddTestData_Admin_TC_109701();
            AddTestData_Admin_TC_109666();
            AddTestData_Admin_TC_109667();
            AddTestData_Admin_TC_161117();
            AddTestData_Admin_TC_161150();
            AddTestData_Admin_PostDeployment_TC_189003();
            AddTestData_Admin_PostDeployment_TC_189002();
        }

        private static void AddTestData_FrontEnd(string clientName)
        {
            AddTestData_Defect_D_220805();
            AddTestData_Defect_D_221118();
            AddTestData_Defect_D_221120();
            AddTestData_Defect_D_221237();
            AddTestData_Defect_D_221461();
            AddTestData_Defect_D_221661();
            AddTestData_Defect_D_221663();
            AddTestData_Defect_D_221720();
            AddTestData_FrontEnd_TC_124896();
            AddTestData_FrontEnd_TC_219285();
            AddTestData_FrontEnd_TC_219287();
            AddTestData_FrontEnd_TC_219288();
            AddTestData_FrontEnd_TC_112093();
            AddTestData_FrontEnd_TC_119759();
            AddTestData_FrontEnd_TC_119763();
            AddTestData_FrontEnd_TC_119764();
            AddTestData_FrontEnd_TC_119765();
            AddTestData_FrontEnd_TC_119768();
            AddTestData_FrontEnd_TC_119748();
            AddTestData_FrontEnd_TC_119749();
            AddTestData_FrontEnd_TC_119750();
            AddTestData_FrontEnd_TC_119751();
            AddTestData_FrontEnd_TC_119752();
            AddTestData_FrontEnd_TC_119753();
            AddTestData_FrontEnd_TC_119754();
            AddTestData_FrontEnd_TC_119760();
            AddTestData_FrontEnd_TC_119831();
            AddTestData_FrontEnd_TC_119832();
            AddTestData_FrontEnd_TC_119833();
            AddTestData_FrontEnd_TC_119837();
            AddTestData_FrontEnd_TC_119838();
            AddTestData_FrontEnd_TC_124897();
            AddTestData_FrontEnd_TC_124898();
            AddTestData_FrontEnd_TC_223757();
            AddTestData_FrontEnd_TC_120943();
            AddTestData_FrontEnd_TC_120944();
            AddTestData_FrontEnd_TC_120945();
            AddTestData_FrontEnd_TC_120946();
            AddTestData_FrontEnd_TC_120947();
            AddTestData_FrontEnd_TC_120948();
            AddTestData_FrontEnd_TC_120949();
            AddTestData_FrontEnd_TC_153852();
            AddTestData_FrontEnd_TC_153859();
            AddTestData_FrontEnd_TC_153860();
            AddTestData_FrontEnd_TC_120126();
            AddTestData_FrontEnd_TC_120127();
            AddTestData_FrontEnd_TC_120128();
            AddTestData_FrontEnd_TC_120129();
            AddTestData_FrontEnd_TC_120130();
            AddTestData_FrontEnd_TC_120131();
            AddTestData_FrontEnd_TC_120132();
            AddTestData_FrontEnd_TC_120133();
            AddTestData_FrontEnd_TC_120134();
            AddTestData_FrontEnd_TC_120135();
            AddTestData_FrontEnd_TC_120136();
            AddTestData_FrontEnd_TC_120137();
            AddTestData_FrontEnd_TC_120138();
            AddTestData_FrontEnd_TC_124899();
            AddTestData_FrontEnd_TC_125818();
            AddTestData_FrontEnd_TC_166273();
            AddTestData_FrontEnd_TC_166274();
            AddTestData_FrontEnd_TC_166283();
            AddTestData_FrontEnd_TC_166288();
            AddTestData_FrontEnd_TC_219436();
            AddTestData_FrontEnd_TC_219459();
            AddTestData_FrontEnd_TC_219517();
            AddTestData_FrontEnd_TC_112269();
            AddTestData_FrontEnd_TC_120120();
            AddTestData_FrontEnd_TC_119826();
            AddTestData_FrontEnd_TC_113051();
            AddTestData_FrontEnd_TC_113052();
            AddTestData_FrontEnd_TC_113056();
            AddTestData_FrontEnd_TC_124313();
            AddTestData_FrontEnd_TC_124314();
            AddTestData_FrontEnd_TC_124316();
            AddTestData_FrontEnd_TC_124317();
            AddTestData_FrontEnd_TC_124318();
            AddTestData_FrontEnd_TC_154267();
            AddTestData_FrontEnd_TC_160221();
            AddTestData_FrontEnd_TC_180158();
            AddTestData_FrontEnd_TC_113059();
            AddTestData_FrontEnd_TC_113060();
            AddTestData_FrontEnd_TC_116954();
            AddTestData_FrontEnd_TC_117664();
            AddTestData_FrontEnd_TC_117665();
            AddTestData_FrontEnd_TC_113757();
            AddTestData_FrontEnd_TC_112157();
            AddTestData_FrontEnd_TC_112449();
            AddTestData_FrontEnd_TC_124365();
            AddTestData_FrontEnd_TC_124368();
            AddTestData_FrontEnd_TC_124380();
            AddTestData_FrontEnd_TC_124508();
            AddTestData_FrontEnd_TC_124511();
            AddTestData_FrontEnd_TC_113877();
            AddTestData_FrontEnd_TC_113878();
            AddTestData_FrontEnd_TC_114792();
            AddTestData_FrontEnd_TC_115263();
            AddTestData_FrontEnd_TC_115264();
            AddTestData_FrontEnd_TC_111604();
            AddTestData_FrontEnd_TC_111605();
            AddTestData_FrontEnd_TC_111606();
            AddTestData_FrontEnd_TC_111607();
            AddTestData_FrontEnd_TC_115262();
            AddTestData_FrontEnd_TC_115265();
            AddTestData_FrontEnd_TC_115266();
            AddTestData_FrontEnd_TC_115267();
            AddTestData_FrontEnd_TC_147743();
            AddTestData_FrontEnd_TC_147758();
            AddTestData_FrontEnd_TC_166407();
            AddTestData_FrontEnd_TC_109687();
            AddTestData_FrontEnd_TC_109739();
            AddTestData_FrontEnd_TC_109741();
            AddTestData_FrontEnd_TC_110850();
            AddTestData_FrontEnd_TC_110855();
            AddTestData_FrontEnd_TC_116222();
            AddTestData_FrontEnd_TC_118019();
            AddTestData_FrontEnd_TC_109958();
            AddTestData_FrontEnd_TC_109959();
            AddTestData_FrontEnd_TC_112091();
            AddTestData_FrontEnd_TC_112270();
            AddTestData_FrontEnd_TC_116403();
            AddTestData_FrontEnd_TC_116979();
            AddTestData_FrontEnd_TC_217847();
            AddTestData_FrontEnd_TC_218534();
            AddTestData_FrontEnd_TC_218535();
            AddTestData_FrontEnd_TC_218540(clientName);
            AddTestData_FrontEnd_TC_218547();
            AddTestData_FrontEnd_TC_112275();
            AddTestData_FrontEnd_TC_112423();
            AddTestData_FrontEnd_TC_112426();
            AddTestData_FrontEnd_TC_224924();
            AddTestData_FrontEnd_TC_238611();
            AddTestData_FrontEnd_TC_237552();
            AddTestData_FrontEnd_TC_223768();
            AddTestData_FrontEnd_TC_223762();
            AddTestData_FrontEnd_TC_223760();
            AddTestData_FrontEnd_TC_109737();
            AddTestData_FrontEnd_TC_109738();
            AddTestData_FrontEnd_TC_216107();
            AddTestData_FrontEnd_TC_223767();
            AddTestData_FrontEnd_TC_254265();


        }


        #endregion

        #region Test Plan Data
        #region TP_Defects
        private static void AddTestData_Defect_D_220805()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "AwardExpMonth", "1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "AwardName", "AS");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "AwardType", "Points Based");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "Balance", "100");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "CardAmount", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "Catalog", "Darden eGift Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "Code", "8");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "CouponName", "CouponTo");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "EmailText", "Points Award Email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "MarketingPartner", "Tango Cards");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "MemberLevelText", "Club Member");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "PointValue", "2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_220805", "1", "TRUE", "RedemptionName", "PBASED");
        }
        private static void AddTestData_Defect_D_221118()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221118", "1", "TRUE", "FaceBookTitle", "Facebook");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221118", "1", "TRUE", "TwitterTitle", "Cendyn (@Cendyn) / Twitter");
        }
        private static void AddTestData_Defect_D_221120()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "FacebookPassword", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "FacebookTitleafterLoginFromExcel", "Facebook");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "FacebookTitleFromExcel", "Facebook");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "FacebookUserNameusername", "testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "TwitterPassword", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "TwitterTitleafterLoginFromExcel", "Twitter / Authorise an application");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "TwitterTitleFromExcel", "Twitter / Authorise an application");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221120", "1", "TRUE", "TwitterUsername", "test.twitter06@cendyn17.com");
        }
        private static void AddTestData_Defect_D_221237()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221237", "1", "TRUE", "Email", "qaAuto@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221237", "1", "TRUE", "FirstName", "TestFirstName");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221237", "1", "TRUE", "LastName", "TestLastName");
        }
        private static void AddTestData_Defect_D_221461()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221461", "1", "TRUE", "EmailValidationerrorMsg", "Wrong email format");
        }
        private static void AddTestData_Defect_D_221661()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221661", "1", "TRUE", "MultipleEmail", "testuser@cendyn17.com;wtest@cendyn17.com");
        }
        private static void AddTestData_Defect_D_221663()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "AwardExpMonth", "1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "AwardName", "NamA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "AwardType", "Points Based");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "Balance", "100");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "CardAmount", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "Catalog", "Darden eGift Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "Code", "2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "CouponName", "CoupOne");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "EmailText", "Points Award Email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "MarketingPartner", "Tango Cards ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "MemberLevelText", "Club Member");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221663", "1", "TRUE", "PointValue", "2");
        }
        private static void AddTestData_Defect_D_221720()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221720", "1", "TRUE", "Description", "TestTermsAndConditionDescription");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221720", "1", "TRUE", "FaceBookTitle", "https://www.facebook.com/");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "Defect", "", "D_221720", "1", "TRUE", "TwitterTitle", "https://twitter.com/home");
        }
        #endregion

        #region TP_186851
        private static void AddTestData_Admin_TC_124362(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_124362", "1", "TRUE", "PendingStatus", "Pending");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_124362", "1", "TRUE", "ConfirmedStatus", "Confirmed");
        }
        private static void AddTestData_Admin_TC_124364(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_124364", "1", "TRUE", "MobilePhoneNumber", "+123(1234)-456");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_124364", "1", "TRUE", "HomePhoneNumber", "+123(1234)-456");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_124364", "1", "TRUE", "OfficePhoneNumber", "+123(1234)-456");
        }
        private static void AddTestData_Admin_TC_188666(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_188666", "1", "TRUE", "PendingStatus", "Pending");
        }
        private static void AddTestData_Admin_TC_188667(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186851", "TC_188667", "1", "TRUE", "ConfirmedStatus", "Confirmed");
        }
        #endregion

        #region TP_121733   
        private static void AddTestData_FrontEnd_TC_112093()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_112093", "1", "TRUE", "InvitationEmail", "test@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_112093", "1", "TRUE", "InviteFriendsExpectedValidationmessage", "The captcha field is required");
        }
        private static void AddTestData_FrontEnd_TC_119759()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119759", "1", "TRUE", "Email", "QAtestJS@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119759", "1", "TRUE", "IncorrectConfirmPass", "43124FSAD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119759", "1", "TRUE", "Email1", "email@123.123.123.123");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119759", "1", "TRUE", "Email2", "[123.123.123.123]");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119759", "1", "TRUE", "Email3", "\"email\"@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119759", "1", "TRUE", "Email4", "?????@domain.com");
        }
        private static void AddTestData_FrontEnd_TC_119763()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "Card", "Automation_Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "Confirm", "ccendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "Email", "QATest_automation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "FirstName", "QATest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "LastName", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "LastName", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "Scenario", "ccendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "1", "TRUE", "Validationmessage", "Password does not meet requirements");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "2", "TRUE", "Confirm", "CCENDYN1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "2", "TRUE", "Scenario", "CCENDYN1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "3", "TRUE", "Confirm", "cCCENDYN");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "3", "TRUE", "Scenario", "cCCENDYN");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "4", "TRUE", "Confirm", "Cendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "4", "TRUE", "Scenario", "Cendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "5", "TRUE", "Confirm", "Cendyn@@");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "5", "TRUE", "Scenario", "Cendyn@@");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "6", "TRUE", "Confirm", "ccendyn@@");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119763", "6", "TRUE", "Scenario", "ccendyn@@");
        }
        private static void AddTestData_FrontEnd_TC_119764()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119764", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119764", "1", "TRUE", "LastName", "Test");
        }
        private static void AddTestData_FrontEnd_TC_119765()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119765", "1", "TRUE", "Email", "Test@cendyn17@.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119765", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119765", "1", "TRUE", "IncorrectConfirmPass", "43124FSAD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119765", "1", "TRUE", "LastName", "Test");
        }
        private static void AddTestData_FrontEnd_TC_119768()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119768", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121733", "TC_119768", "1", "TRUE", "LastName", "Test");
        }
        #endregion

        #region TP_121734
        private static void AddTestData_FrontEnd_TC_119748()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119748", "1", "TRUE", "first_name", "");
        }
        private static void AddTestData_FrontEnd_TC_119749()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119749", "1", "TRUE", "first_name", "");
        }
        private static void AddTestData_FrontEnd_TC_119750()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119750", "1", "TRUE", "first_name", "");

        }
        private static void AddTestData_FrontEnd_TC_119751()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119751", "1", "TRUE", "first_name", "");
        }
        private static void AddTestData_FrontEnd_TC_119752()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119752", "1", "TRUE", "first_name", "");
        }
        private static void AddTestData_FrontEnd_TC_119753()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119753", "1", "TRUE", "first_name", "");

        }
        private static void AddTestData_FrontEnd_TC_119754()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121734", "TC_119754", "1", "TRUE", "first_name", "");
        }
        #endregion

        #region TP_121735
        private static void AddTestData_FrontEnd_TC_119760()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "AdareValidationmessage", "Invalid email.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "Card", "Automation_Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "ConfirmPassword", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "Email", "1234567890@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "FirstName", "QATest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "LastName", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "10", "TRUE", "Email", "firstnamelastname@domain.name");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "2", "TRUE", "Email", "email@domain-one.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "3", "TRUE", "Email", "_______@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "4", "TRUE", "Email", "email@domain.name");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "5", "TRUE", "Email", "firstname-lastname@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "6", "TRUE", "Email", "firstname@yahoo.comm.in");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "7", "TRUE", "Email", "email@domain.co.jp");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "8", "TRUE", "Email", "firstname.lastname@domain.co.au");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "9", "TRUE", "Email", "firstname_lastname@domain.co.au");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121735", "TC_119760", "1", "TRUE", "Validationmessage", "Invalid email");
        }
        #endregion

        #region TP_121737        
        private static void AddTestData_FrontEnd_TC_124896()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124896", "1", "TRUE", "LinkExpiredValidation", "This link is no longer valid");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124896", "1", "TRUE", "Password", "Cendyn1234$");
            //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124896", "1", "TRUE", "RegisteredEmail", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124896", "1", "TRUE", "Registered Email", "qaAutomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124896", "1", "TRUE", "Validation Message", "An email with instructions has been sent to you. Please check your email to reset your password.");
        }
        private static void AddTestData_FrontEnd_TC_219285()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "1", "TRUE", "Email Address", "      ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "1", "TRUE", "Scenario", "Email as White Spaces");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "1", "TRUE", "Validation Message", "Please enter a valid email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "10", "TRUE", "Email Address", "email@domain.com (Joe Smith)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "10", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "10", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "11", "TRUE", "Email Address", "email@domain");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "11", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "11", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "12", "TRUE", "Email Address", "email@-domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "12", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "12", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "13", "TRUE", "Email Address", "email@domain.web");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "13", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "13", "TRUE", "Validation Message", "Email not found, try another email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "14", "TRUE", "Email Address", "email@111.222.333.44444");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "14", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "14", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "15", "TRUE", "Email Address", "email@domain..com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "15", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "15", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "16", "TRUE", "Email Address", "Testqa1@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "16", "TRUE", "Scenario", "Email Not Registered");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "16", "TRUE", "Validation Message", "Email not found, try another email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "17", "TRUE", "Email Address", "   qaAuto@cendyn17.com   ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "17", "TRUE", "Scenario", "Email with Lead and trail spaces");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "17", "TRUE", "Validation Message", "An email with instructions has been sent to you. Please check your email to reset your password.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "2", "TRUE", "Email Address", "#@%^%#$@#$@#.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "2", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "2", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "3", "TRUE", "Email Address", "@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "3", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "3", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "4", "TRUE", "Email Address", "Joe Smith ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "4", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "4", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "5", "TRUE", "Email Address", "email.domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "5", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "5", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "6", "TRUE", "Email Address", "email@domain@domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "6", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "6", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "7", "TRUE", "Email Address", ".email@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "7", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "7", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "8", "TRUE", "Email Address", "email.@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "8", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "8", "TRUE", "Validation Message", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "9", "TRUE", "Email Address", "email..@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "9", "TRUE", "Scenario", "Invalid Email format ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219285", "9", "TRUE", "Validation Message", "Wrong email format");
        }
        private static void AddTestData_FrontEnd_TC_219287()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219287", "1", "TRUE", "Password", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219287", "1", "TRUE", "Registered Email", "qaAutomation1@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219287", "1", "TRUE", "Validation Message", "An email with instructions has been sent to you. Please check your email to reset your password.");
        }
        private static void AddTestData_FrontEnd_TC_219288()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "1", "TRUE", "Email Address", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "1", "TRUE", "Scenario", "Password Mismatch");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "1", "TRUE", "Validation Message", "The new password and confirmation password do not match");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "2", "TRUE", "Email Address", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "2", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "2", "TRUE", "Scenario", "Same Password ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "2", "TRUE", "Validation Message", "The new password and confirmation password do not match");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "3", "TRUE", "Email Address", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "3", "TRUE", "Password", "abcdxyz1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "3", "TRUE", "Scenario", "Invalid Password Format( no upper case)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "3", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "4", "TRUE", "Email Address", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "4", "TRUE", "Password", "CCENDYN1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "4", "TRUE", "Scenario", "Invalid Password Format ( no lowercase case)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "4", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "5", "TRUE", "Email Address", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "5", "TRUE", "Password", "cCCENDYN");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "5", "TRUE", "Scenario", "Invalid Password Format ( no digit)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "5", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "6", "TRUE", "Email Address", "QATestAutoForgotPass@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "6", "TRUE", "Password", "Cendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "6", "TRUE", "Scenario", "Invalid Password Format( not 8 character )");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_219288", "6", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
        }

        private static void AddTestData_FrontEnd_TC_119831()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119831", "1", "TRUE", "Email", "QATestAutoForgotPass@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_119832()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119832", "1", "TRUE", "RegisteredEmail", "QATest@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119832", "1", "TRUE", "UnregisteredEmail", "Testqa1@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_119833()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress1", "#@%^%#$@#$@#.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress10", "email@domain ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress11", "email@-domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress12", "email@domain.web ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress13", "email@111.222.333.44444");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress14", "email@domain..com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress2", "@domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress3", "Joe Smith ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress4", "email.domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress5", "email@domain@domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress6", ".email@domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress7", "email.@domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress8", "email..@domain.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119833", "1", "TRUE", "EmailAddress9", "email@domain.com (Joe Smith) ");
        }
        private static void AddTestData_FrontEnd_TC_119837()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119837", "1", "TRUE", "RegisteredEmail", "QATestAutoForgotPass@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_119838()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119838", "1", "TRUE", "NewPassword1", "ccendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119838", "1", "TRUE", "NewPassword2", "CCENDYN1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119838", "1", "TRUE", "NewPassword3", "cCCENDYN");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119838", "1", "TRUE", "NewPassword4", "Cendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_119838", "1", "TRUE", "RegisteredEmail", "QATestAutoForgotPass@cendyn17.com");
        }

        private static void AddTestData_FrontEnd_TC_124897()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124897", "1", "TRUE", "RegisteredEmail", "QATestAutoForgotPass@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_124898()
        {

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_124898", "1", "TRUE", "Email", "QATestAutoForgotPass@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_223757()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_223757", "1", "TRUE", "NewPassword", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121737", "TC_223757", "1", "TRUE", "wrongPasswordPassword", "Cendyn123");
        }
        #endregion TP_121737

        #region TP_121738
        private static void AddTestData_FrontEnd_TC_120943()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120943", "1", "TRUE", "Email", "jgrey1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120943", "1", "TRUE", "FirstName", "Johnathan");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120943", "1", "TRUE", "LastName", "Grey");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120943", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120943", "1", "TRUE", "SignerName", "JG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120943", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_120944()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120944", "1", "TRUE", "Email", "qatest1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120944", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120944", "1", "TRUE", "LastName", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120944", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120944", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120944", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_120945()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120945", "1", "TRUE", "Email", "jgrey2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120945", "1", "TRUE", "FirstName", "Johnathan");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120945", "1", "TRUE", "LastName", "Grey");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120945", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120945", "1", "TRUE", "SignerName", "JG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120945", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_120946()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120946", "1", "TRUE", "Email", "qatest2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120946", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120946", "1", "TRUE", "LastName", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120946", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120946", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120946", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_120947()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120947", "1", "TRUE", "Email", "qatest3");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120947", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120947", "1", "TRUE", "LastName", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120947", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120947", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120947", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_120948()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120948", "1", "TRUE", "Email", "qatest2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120948", "1", "TRUE", "FirstName", "QATest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120948", "1", "TRUE", "LastName", "Internal");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120948", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120948", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120948", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_120949()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email1", "#@%^%#$@#$@#.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email10", "email@domain");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email11", "email@-domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email12", "email@111.222.333.44444");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email13", "email@domain..com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email2", "@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email3", "Joe Smith");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email4", "email.domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email5", "email@domain@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email6", ".email@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email7", "email.@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email8", "email..email@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Email9", "email@domain.com (Joe Smith)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "FirstName", "  QA  ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "LastName", "  Test3  ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_120949", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_153852()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153852", "1", "TRUE", "Email", "qatest4");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153852", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153852", "1", "TRUE", "LastName", "Test4");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153852", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153852", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153852", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_153859()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153859", "1", "TRUE", "Email", "qatest5");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153859", "1", "TRUE", "FirstName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153859", "1", "TRUE", "LastName", "Test5");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153859", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153859", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153859", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        private static void AddTestData_FrontEnd_TC_153860()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153860", "1", "TRUE", "Email", "  qatest6");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153860", "1", "TRUE", "FirstName", "  QA  ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153860", "1", "TRUE", "LastName", "  Test6  ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153860", "1", "TRUE", "Prefix", "Mr.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153860", "1", "TRUE", "SignerName", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121738", "TC_153860", "1", "TRUE", "SignUpSource", "Capri by Fraser");
        }
        #endregion

        #region TP_121740
        private static void AddTestData_FrontEnd_TC_120138()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120138", "1", "TRUE", "Password", "CCendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120138", "1", "TRUE", "UserName", "qatestAuto12@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_124899()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_124899", "1", "TRUE", "NewPassword", "Cendyn123.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_124899", "1", "TRUE", "Password", "Cendyn123$");
        }
        private static void AddTestData_FrontEnd_TC_219436()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219436", "1", "TRUE", "NewPassword", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219436", "1", "TRUE", "NewUsername", "TESTTWONEWTHREE@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219436", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219436", "1", "TRUE", "Registered Email", "mohamedobaidall@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219436", "1", "TRUE", "UserName", "TESTTHREE@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219436", "1", "TRUE", "Validation Message", "Please check your username and password. Your entry did not match our records.");
        }
        private static void AddTestData_FrontEnd_TC_219459()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "1", "TRUE", "Password1", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "1", "TRUE", "Scenario1", "Password Mismatch");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "1", "TRUE", "Validation Message1", "Confirm password doesn't match, Type again");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "2", "TRUE", "Password2", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "2", "TRUE", "Scenario2", "Same Password ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "2", "TRUE", "Validation Message2", "The new password cannot be the same as your current password");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "3", "TRUE", "Password", "ccendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "3", "TRUE", "Scenario", "Invalid Password Format( no upper case)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "3", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "4", "TRUE", "Password", "CCENDYN1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "4", "TRUE", "Scenario", "Invalid Password Format ( no lowercase case)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "4", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "5", "TRUE", "Password", "cCCENDYN");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "5", "TRUE", "Scenario", "Invalid Password Format ( no digit)");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "5", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "6", "TRUE", "Password", "Cendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "6", "TRUE", "Scenario", "Invalid Password Format( not 8 character )");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219459", "6", "TRUE", "Validation Message", "The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit");
        }
        private static void AddTestData_FrontEnd_TC_219517()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "1", "TRUE", "NewUsername", "qatestAuto21@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "1", "TRUE", "Scenario", "Update UserName");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "1", "TRUE", "UserName", "qatestAuto2@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "2", "TRUE", "ConfirmationMessage", "An email with instructions has been sent to you. Please check your email to reset your password.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "2", "TRUE", "NewUsername", "qatestAuto21@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "2", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "2", "TRUE", "Scenario", "Check the Forgot Password Functionality for old and new User");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "2", "TRUE", "UserName", "qatestAuto2@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "2", "TRUE", "ValidationMessage", "Email not found, try another email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "3", "TRUE", "NewUsername", "qatestAuto21@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "3", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "3", "TRUE", "Scenario", "Check the Member Information details for old and new Username");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "3", "TRUE", "UserName", "qatestAuto2@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_219517", "3", "TRUE", "ValidationMessage", "No member data available, please update search.");
        }
        private static void AddTestData_FrontEnd_TC_120126()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120126", "1", "TRUE", "NewPassword", "Cendyn123.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120126", "1", "TRUE", "Password", "Cendyn123$");
        }
        private static void AddTestData_FrontEnd_TC_120127()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120127", "1", "TRUE", "Email", "qatestAuto1@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120127", "1", "TRUE", "NewPassword", "Cendyn123.");
        }
        private static void AddTestData_FrontEnd_TC_120128()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120128", "1", "TRUE", "Email", "qatestAuto2@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120128", "1", "TRUE", "NewEmail", "qatestAuto21");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120128", "1", "TRUE", "NewPassword", "Cendyn123.");
        }
        private static void AddTestData_FrontEnd_TC_120129()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120129", "1", "TRUE", "Email", "qatestAuto3@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120129", "1", "TRUE", "NewPassword", "Cendyn1234.");
        }
        private static void AddTestData_FrontEnd_TC_120130()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120130", "1", "TRUE", "Email", "qatestAuto4@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120130", "1", "TRUE", "NewEmail", "qatestAuto41");
        }
        private static void AddTestData_FrontEnd_TC_120131()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120131", "1", "TRUE", "Email", "qatestAuto5@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120131", "1", "TRUE", "NewEmail", "qatestAuto52@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_120132()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120132", "1", "TRUE", "Email", "qatestAuto6@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120132", "1", "TRUE", "NewEmail", "qatestAuto61");
        }
        private static void AddTestData_FrontEnd_TC_120133()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120133", "1", "TRUE", "Email", "qatestAuto7@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120133", "1", "TRUE", "NewEmail", "qatestAuto71@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_120134()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120134", "1", "TRUE", "Email", "qatestAuto8@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120134", "1", "TRUE", "NewPassword1", "ccendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120134", "1", "TRUE", "NewPassword2", "CCENDYN1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120134", "1", "TRUE", "NewPassword3", "cCCENDYN");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120134", "1", "TRUE", "NewPassword4", "Cendyn1");
        }
        private static void AddTestData_FrontEnd_TC_120135()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120135", "1", "TRUE", "Email", "qatestAuto9@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120135", "1", "TRUE", "Password", "Cendyn123.");
        }
        private static void AddTestData_FrontEnd_TC_120136()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120136", "1", "TRUE", "Email", "qatestAuto10@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120136", "1", "TRUE", "NewPassword", "CCendyn1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120136", "1", "TRUE", "Password", "Cendyn123.");
        }
        private static void AddTestData_FrontEnd_TC_120137()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120137", "1", "TRUE", "Email", "qatestAuto11@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_120137", "1", "TRUE", "NewPassword", "CCendyn1");
        }

        private static void AddTestData_FrontEnd_TC_125818()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_125818", "1", "TRUE", "Email", "QATest@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_125818", "1", "TRUE", "Password", "Cendyn123$");
        }
        private static void AddTestData_FrontEnd_TC_166273()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166273", "1", "TRUE", "AlreadyExistsEmail", "qatestAuto1@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_166274()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166274", "1", "TRUE", "Email", "qatestAuto13@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166274", "1", "TRUE", "Password", "Cendyn123$  ");
        }
        private static void AddTestData_FrontEnd_TC_166283()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166283", "1", "TRUE", "Email", "qatestAuto14@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166283", "1", "TRUE", "Password", "Cendyn123$");
        }
        private static void AddTestData_FrontEnd_TC_166288()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166288", "1", "TRUE", "Email", "johny@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121740", "TC_166288", "1", "TRUE", "Password", "Cendyn123$");
        }
        #endregion TP_121740

        #region TP_121741
        private static void AddTestData_FrontEnd_TC_112269()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "1", "TRUE", "CaptchaValidationMessage", "The captcha field is required");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "1", "TRUE", "Subject", "Missing Stays/Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "1", "TRUE", "ValidationMessage", "This field cannot be blank");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "2", "TRUE", "Subject", "Points Redemption Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "3", "TRUE", "Subject", "Reservations Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "4", "TRUE", "Subject", "Feedback on Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "5", "TRUE", "Subject", "Feedback on Property");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_112269", "6", "TRUE", "Subject", "Other");
        }
        private static void AddTestData_FrontEnd_TC_120120()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_120120", "1", "TRUE", "Message", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_120120", "1", "TRUE", "PhoneNumber", "5611234567");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_120120", "1", "TRUE", "Subject", "Feedback on Independent Collection");
        }
        #endregion TP_121741

        #region TP_121746
        private static void AddTestData_FrontEnd_TC_119826()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121746", "TC_119826", "1", "TRUE", "EmailAddress", "jshah@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121746", "TC_119826", "1", "TRUE", "Password", "Cendyn123$");
        }
        #endregion TP_121746

        #region TP_124305
        private static void AddTestData_FrontEnd_TC_113051()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113051", "1", "TRUE", "FirstnameApostrophe", "DivyaTest'");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113051", "1", "TRUE", "FirstnameLetters", "DivyaTest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113051", "1", "TRUE", "FirstnameNumber", "56422317890");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113051", "1", "TRUE", "FirstnameSpace", "Test Lander");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113051", "1", "TRUE", "FirstnameSpecialCharacter", "!@#$%^()*");
        }
        private static void AddTestData_FrontEnd_TC_113052()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113052", "1", "TRUE", "LastnameApostrophe", "DivyaTest'");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113052", "1", "TRUE", "LastnameLetters", "DivyaTest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113052", "1", "TRUE", "LastnameNumber", "56422317890");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113052", "1", "TRUE", "LastnameSpace", "Test Lander");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113052", "1", "TRUE", "LastnameSpecialCharacter", "!@#$%^()*");
        }
        private static void AddTestData_FrontEnd_TC_113056()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Address1", "9628 Rose Dr.Williamsburg, VA 23185");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "CardName", "Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "City", "California City");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Country", "United States");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Firstname", "Dr.Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Language", "English");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Lastname", "Rose");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "State", "California");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Username", "testDivya2481992@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_113056", "1", "TRUE", "Zipcode", "12345678933");
        }
        private static void AddTestData_FrontEnd_TC_124313()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "Address1", "9628 Rose Dr.Williamsburg, VA 23185");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "CardName", "Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "City", "California City");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "Country", "United States");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "Firstname", "Dr.Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "Language", "English");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "Lastname", "Rose");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "State", "California");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124313", "1", "TRUE", "Zipcode", "12345678933");
        }
        private static void AddTestData_FrontEnd_TC_124314()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "Address1", "9628 Rose Dr.Williamsburg, VA 23185");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "CardName", "Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "City", "California City");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "Country", "United States");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "Firstname", "Dr.Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "Language", "English");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "Lastname", "Rose");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "State", "California");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124314", "1", "TRUE", "Zipcode", "12345678933");
        }
        private static void AddTestData_FrontEnd_TC_124316()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124316", "1", "TRUE", "PhoneNumber", "+123(1234)-456");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124316", "1", "TRUE", "PhoneNumber_DigitwithSpecialSymbol", "12365478#+-_#().,12234312453");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124316", "1", "TRUE", "PhoneNumber_Letter", "Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124316", "1", "TRUE", "PhoneNumber_Space", " +123(1234)-456  23185");
        }
        private static void AddTestData_FrontEnd_TC_124317()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124317", "1", "TRUE", "PhoneNumber", "+123(1234)-456");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124317", "1", "TRUE", "PhoneNumber_DigitwithSpecialSymbol", "12365478#+-_#().,12234312453");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124317", "1", "TRUE", "PhoneNumber_Letter", "Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124317", "1", "TRUE", "PhoneNumber_Space", " +123(1234)-456  23185");
        }
        private static void AddTestData_FrontEnd_TC_124318()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124318", "1", "TRUE", "PhoneNumber", "+123(1234)-456");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124318", "1", "TRUE", "PhoneNumber_DigitwithSpecialSymbol", "12365478#+-_#().,12234312453");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124318", "1", "TRUE", "PhoneNumber_Letter", "Williamsburg");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_124318", "1", "TRUE", "PhoneNumber_Space", " +123(1234)-456  23185");
        }
        private static void AddTestData_FrontEnd_TC_154267()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Address1", "Address 1:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Address2", "Address 2:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Cardname", "Card Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "City", "City:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Company", "Company Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Country", "Country/Territory:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "DateOfBirth", "Date of Birth");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "FaxPhoneNumber", "Fax Phone Number:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Firstname", "First Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Gender", "Gender:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "HomePhoneNumber", "Home Phone Number:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Language", "Language:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Lastname", "Last Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "LeisureBusinessDestinations", "Preferred Business Travel Destinations:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "LeisureTravelDestinations", "Preferred Leisure Travel Destinations:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "MobilePhoneNumber", "Mobile Phone Number:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Nationality", "Nationality:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "NextTravelDestinations", "Next Travel Destination:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "OfficePhoneNumber", "Office Phone Number:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "RecommendedBy", "Recommended by:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "State", "State/Province:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "Title", "Title:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_154267", "1", "TRUE", "ZipCode", "Zip/Postal Code:");
        }
        private static void AddTestData_FrontEnd_TC_160221()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_160221", "1", "TRUE", "Email", "testDivya@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_160221", "1", "TRUE", "Firstname", "Test Divya");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_160221", "1", "TRUE", "Lastname", "Nair");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_160221", "1", "TRUE", "Password", "Cendyn123$");
        }
        private static void AddTestData_FrontEnd_TC_180158()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_180158", "1", "TRUE", "Email", "ruchaTest@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_180158", "1", "TRUE", "Firstname", "Test Divya");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_180158", "1", "TRUE", "Lastname", "Nair");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124305", "TC_180158", "1", "TRUE", "Password", "Cendyn123$");
        }
        #endregion TP_124305

        #region TP_124306
        private static void AddTestData_FrontEnd_TC_113059()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113059", "1", "TRUE", "AnniversaryDate", "41647");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113059", "1", "TRUE", "Children", "2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113059", "1", "TRUE", "DateOfBirth", "31191");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113059", "1", "TRUE", "FirstnameLastname", "DivyaTest");
        }
        private static void AddTestData_FrontEnd_TC_113060()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113060", "1", "TRUE", "FirstnameLastname_Letters", "DivyaTest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113060", "1", "TRUE", "FirstnameLastname_Numbers", "TestNewUser24051985");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113060", "1", "TRUE", "FirstnameLastname_Space", " Test Divya ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113060", "1", "TRUE", "FirstnameLastname_SpecialCharacters", "!@#$%^*()");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_113060", "1", "TRUE", "FirstnameLastname_SpecialSymbol", "Test_Divya-201155");
        }
        private static void AddTestData_FrontEnd_TC_116954()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_116954", "1", "TRUE", "AnniversaryDate", "41647");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_116954", "1", "TRUE", "Children", "2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_116954", "1", "TRUE", "DateOfBirth", "31191");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124306", "TC_116954", "1", "TRUE", "FirstnameLastname", "DivyaTest");
        }
        #endregion TP_124306

        #region TP_124309
        private static void AddTestData_FrontEnd_TC_117664()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117664", "1", "TRUE", "Email", "ruchaTest@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117664", "1", "TRUE", "Firstname", "Test Divya");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117664", "1", "TRUE", "Lastname", "Nair");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117664", "1", "TRUE", "Password", "Cendyn123$");
        }
        private static void AddTestData_FrontEnd_TC_117665()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117665", "1", "TRUE", "Email", "ruchaTest@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117665", "1", "TRUE", "Firstname", "Test Divya");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117665", "1", "TRUE", "Lastname", "Nair");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_124309", "TC_117665", "1", "TRUE", "Password", "Cendyn123$");
        }
        #endregion TP_124309

        #region TP_156796
        /*No Test Data needed for 151546, 151548, 151554, 221217*/

        private static void AddTestData_Admin_TC_151553(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Email", "testuser");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Points", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "InternalComments", "Adding Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "MemberComments", "Testing Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Hotel", "Hotel Origami Palm Beach Resort");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Email", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Points", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Hotel", "Caravelle");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "InternalComments", "testing");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151553", "1", "TRUE", "Comments", "testing");
        }

        private static void AddTestData_Admin_TC_155521(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_155521", "1", "TRUE", "Email", "testuser");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_155521", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_155521", "1", "TRUE", "UpdateStatus", "Inactive");
        }

        private static void AddTestData_Admin_TC_221208(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_221208", "1", "TRUE", "Email", "testuser");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_221208", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_221208", "1", "TRUE", "EmailStatus", "Confirmed");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_221208", "1", "TRUE", "NoDataMatch", "Invalid Data");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_221208", "1", "TRUE", "NumbericData", "24");
        }

        private static void AddTestData_Admin_TC_151537(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151537", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151537", "1", "TRUE", "EmailStatus", "Confirmed");
        }
        private static void AddTestData_Admin_TC_151539(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151539", "1", "TRUE", "AutoStay", "Auto");
        }
        private static void AddTestData_Admin_TC_151542(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "LogDate", "Log Date");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "Action", "Action");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "By", "By");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "View", "View");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "ChangeType", "Change Type");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "OriginalData", "Original Data");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151542", "1", "TRUE", "NewData", "New Data");
        }
        private static void AddTestData_Admin_TC_151547(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151547", "1", "TRUE", "NoDataMatch", "Auto");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151547", "1", "TRUE", "NumbericData", "24");
        }
        private static void AddTestData_Admin_TC_151555(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "Email", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "Points", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "Hotel", "Caravelle");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "InternalComments", "testing");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_156796", "TC_151555", "1", "TRUE", "Comments", "testing");
        }
        #endregion TP_156796

        #region TP_166488

        private static void AddTestData_Admin_TC_161117()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_166488", "TC_161117", "1", "TRUE", "ValidationMessage1", "You cannot merge more than 6 accounts, please reduce your selections.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_166488", "TC_161117", "1", "TRUE", "ValidationMessage2", "Once confirmed this merge cannot be undone. Please confirm to continue.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_166488", "TC_161117", "1", "TRUE", "ValidationMessage3", "These accounts have now been merged successful. All accounts Stays and Benefits have been moved to this account.The other accounts have been deleted from the system.");
        }
        private static void AddTestData_Admin_TC_161150()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_166488", "TC_161150", "1", "TRUE", "ValidationMessage1", "There is a status of inactive or deactivated in the merge accounts. This will be discarded and the account merge will result in active status.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_166488", "TC_161150", "1", "TRUE", "ValidationMessage2", "Once confirmed this merge cannot be undone. Please confirm to continue.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_166488", "TC_161150", "1", "TRUE", "ValidationMessage3", "No member data available, please update search.");
        }

        #endregion TP_166488

        #region TP_171074
        /*No Test Data available - 113756, 113764, 221090, 221277, 221385, 221395*/
        private static void AddTestData_FrontEnd_TC_113757()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "AwardName", "Award Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "AwardNumber", "Award Number:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "CardName", "Card Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "City", "City:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Company", "Company:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Country", "Country");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Email", "Email:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Firstname", "First Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Lastname", "Last Name:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "MemberNumber", "Member Number:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "MemberStatus", "Member Status:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "MemberType", "Member Type:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Phone", "Phone:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "State", "State");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Street", "Street:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171074", "TC_113757", "1", "TRUE", "Zip", "Zip:");
        }

        #endregion TP_171074

        #region TP_171630
        private static void AddTestData_FrontEnd_TC_112157()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171630", "TC_112157", "1", "TRUE", "AwardName_1", "t2O7CJRK2ap9QZ7EeKptGGeJ3L7lSxKqre0zEoBsYs4zoSkIPczqfbLtNeYUwN1DP8tz2QybCjWX0ntvhTYo8F2meRWmmssehou7Xw2o");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171630", "TC_112157", "1", "TRUE", "AwardName_2", "t2O7CJR");
        }
        #endregion

        #region TP_171642
        private static void AddTestData_FrontEnd_TC_112449()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_1", " Code");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_10", "Edit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_2", "Name");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_3", "Start");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_4", "End");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_5", "Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_6", "Award Type");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_7", "Usage");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_8", "First Usage");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_171642", "TC_112449", "1", "TRUE", "Column_9", "Last Usage");
        }
        #endregion

        #region TP_186848
        private static void AddTestData_Admin_TC_124365(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124365", "1", "TRUE", "Email", "testuser040@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124365", "1", "TRUE", "Email", "testuser01@cendyn17.com");
        }
        private static void AddTestData_Admin_TC_124368(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Email", "testuser034@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Reason", "Reason");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Points", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Hotel", "Hotel");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "InternalComments", "Internal Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "MemberComments", "Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "EmailSent", "Email Sent    ");
        }
        private static void AddTestData_Admin_TC_124369(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124369", "1", "TRUE", "Email", "testuser040@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124369", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124369", "1", "TRUE", "Points", "100");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124369", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124369", "1", "TRUE", "InternalComments", "Text");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124369", "1", "TRUE", "MemberComments", "Text");
        }
        private static void AddTestData_Admin_TC_124370(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "Email", "test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "Points", "-1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "Hotel", "Caravelle");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "InternalComments", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124370", "1", "TRUE", "MemberComments", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
        }
        private static void AddTestData_Admin_TC_124371(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124371", "1", "TRUE", "Email", "testuser");
        }
        private static void AddTestData_Admin_TC_124372(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "Email", "testuser038@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "Points", "-1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "Hotel", "Caravelle");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "InternalComments", "text");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124372", "1", "TRUE", "MemberComments", "text");
        }
        private static void AddTestData_Admin_TC_124373(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124373", "1", "TRUE", "Email", "Test");
        }
        private static void AddTestData_Admin_TC_124377(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "Email", "testuser040@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "Points", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "Hotel", "Caravelle");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "InternalComments", "text");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124377", "1", "TRUE", "MemberComments", "text");
        }
        private static void AddTestData_Admin_TC_124378(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "Email", "testuser036@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "Points", "100");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "Hotel", "Caravelle");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "InternalComments", "text");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124378", "1", "TRUE", "MemberComments", "text");
        }
        private static void AddTestData_Admin_TC_124380(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124380", "1", "TRUE", "Email", "testuser040@cendyn17.com");
        }
        private static void AddTestData_Admin_TC_124381(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "Email", "testuser040@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "Reason", "Reason");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "Points", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "Hotel", "Hotel");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "InternalComments", "Internal Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "MemberComments", "Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124381", "1", "TRUE", "EmailSent", "Email Sent");
        }
        private static void AddTestData_Admin_TC_124383(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124383", "1", "TRUE", "Status", "Active");
        }
        private static void AddTestData_Admin_TC_124385(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Email", "testuser007@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Points", "100");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "BCCEmail", "testuser008@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "InternalComments", "Internal Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "MemberComments", "Member Comments");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Email", "testuser007@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Expiration", "43617");    //TODO: Verify test Date
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "Points", "100");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "BCCEmail", "cendynqaautomation@gmail.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "InternalComments", "Internal Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_124385", "1", "TRUE", "MemberComments", "Member Comments");
        }
        private static void AddTestData_Admin_TC_142421(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "Reason", "Transaction Reason:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "Points", "Points:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "Expiration", "Expiration Date:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "TheList", "TheList");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "Hotel", "Hotel:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "InternalComments", "Internal Comments:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "MemberComments", "Comments to Guest:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "EmailSent", "Send Email to Member");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "AddComments", "Add Comments to Email");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "MemberEmail", "Member Email:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "BCC", "BCC");
            TestDataHelper.AddRecord("PublicHotel", "Admin", "TestCase", "TP_186848", "TC_142421", "1", "TRUE", "MemberComments", "Comments to Member:");
        }
        private static void AddTestData_Admin_TC_220655(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "FraserReason", "Adjustments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "Points", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "InternalComments", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "MemberComments", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "Hotel", "Hotel Origami Palm Beach Resort");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "HotelMyPlace", "My Place Hotel-Aberdeen, SD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "1", "TRUE", "BCCEmail", "");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "Points", "100");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "InternalComments", "Testing Internal comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "MemberComments", "Testing Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "Hotel", "Hotel Origami Palm Beach Resort");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "HotelMyPlace", "My Place Hotel-Aberdeen, SD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220655", "2", "TRUE", "BCCEmail", "TestEmail@cendyn17.com");
        }
        private static void AddTestData_Admin_TC_220919(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "Email", "testuser038@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "Points", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "InternalComments", "Testing Internal comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "MemberComments", "Testing Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "1", "TRUE", "Hotel", "Hotel Origami Palm Beach Resort");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220919", "2", "TRUE", "Points", "1");
        }
        private static void AddTestData_Admin_TC_220954(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "Email", "testuser01@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "Points", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "InternalComments", "Adding Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "MemberComments", "Testing Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "1", "TRUE", "Hotel", "Hotel Origami Palm Beach Resort");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "Email", "testuser01@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "Reason", "Adjustment");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "Points", "-20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "Expiration", "06/2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "InternalComments", "Deducting Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "MemberComments", "Testing Member Comments");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186848", "TC_220954", "2", "TRUE", "Hotel", "Hotel Origami Palm Beach Resort");
        }
        private static void AddTestData_FrontEnd_TC_124365()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124365", "1", "TRUE", "Email", "testuser01@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_124368()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Email", "testuser034@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "EmailSent", "Email Sent");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Hotel", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "InternalComments", "Internal Comments");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "MemberComments", "Member Comments");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Points", "Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124368", "1", "TRUE", "Reason", "Reason");
        }
        private static void AddTestData_FrontEnd_TC_124380()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186848", "TC_124380", "1", "TRUE", "Email", "testuser040@cendyn17.com  ");
        }
        #endregion TP_186848

        #region TP_186863
        private static void AddTestData_Admin_TC_124508(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Res", "Res#");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "StayStatus", "Stay Status");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Arrival", "Arrival");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Departure", "Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Hotel", "Hotel");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Points", "Points");
        }
        private static void AddTestData_FrontEnd_TC_124511()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124511", "1", "TRUE", "Email", "testuser0341@cendyn17.com");
        }
        private static void AddTestData_Admin_TC_141476(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "PastExpMonth", "12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "PastExpDay", "11");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "PastExpYear", "2019");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "FutureExpMonth", "12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "FutureExpDay", "11");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "FutureExpYear", "2025");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "PresentExpYear", "2020");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "AwardStatus", "Issued");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "ExpiredAwardStatus", "Expired");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "1", "TRUE", "AwardSts", "SNT");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "2", "TRUE", "AwardStatus", "Redeemed");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_141476", "3", "TRUE", "AwardStatus", "Expired");
        }
        private static void AddTestData_Admin_TC_222075(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_222075", "1", "TRUE", "UserUserLogin", "Test@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_222075", "1", "TRUE", "UserFirstname", "AutoFirstName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_222075", "1", "TRUE", "UserLastname", "AutoLastName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_222075", "1", "TRUE", "UserTitle", "Admin");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186863", "TC_222075", "1", "TRUE", "UserPermission", "Admin");
        }
        private static void AddTestData_FrontEnd_TC_124508()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Arrival", "Arrival");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Departure", "Departure");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Hotel", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Points", "Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Res", "Res#");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186863", "TC_124508", "1", "TRUE", "StayStatus", "Stay Status");
        }
        #endregion TP_186863

        #region TP_186875
        private static void AddTestData_FrontEnd_TC_113877()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186875", "TC_113877", "1", "TRUE", "Email", "QAtestJS@Cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_113878()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186875", "TC_113878", "1", "TRUE", "Email", "QAtestJS@Cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_114792()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186875", "TC_114792", "1", "TRUE", "Email", "QAtestJS@Cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_115263()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186875", "TC_115263", "1", "TRUE", "Email", "QAtestJS@Cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_115264()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186875", "TC_115264", "1", "TRUE", "Email", "QAtestJS@Cendyn17.com");
        }
        #endregion

        #region TP_186887
        /*No Test Data available 114355, 114356, 114358*/

        #endregion TP_186887

        #region TP_186894
        private static void AddTestData_Admin_TC_111604(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111604", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111604", "1", "TRUE", "UpdateToStatus", "Inactive");
        }
        private static void AddTestData_Admin_TC_111605(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111605", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111605", "1", "TRUE", "UpdateToStatus", "Deactivated");
        }
        private static void AddTestData_Admin_TC_111606(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "Status", "Deactivated");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "UpdateToStatus", "Inactive");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "UpdateToStatusNew", "Active");
        }
        private static void AddTestData_Admin_TC_111607(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111607", "1", "TRUE", "Status", "Inactive");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186894", "TC_111607", "1", "TRUE", "UpdateToStatus", "Deactivated");
        }
        private static void AddTestData_FrontEnd_TC_111604()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111604", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111604", "1", "TRUE", "UpdateToStatus", "Inactive");
        }
        private static void AddTestData_FrontEnd_TC_111605()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111605", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111605", "1", "TRUE", "UpdateToStatus", "Deactivated");
        }
        private static void AddTestData_FrontEnd_TC_111606()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "Status", "Deactivated");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "Status1", "Deactivated");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "UpdateToStatus", "Inactive");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111606", "1", "TRUE", "UpdateToStatus1", "Active");
        }
        private static void AddTestData_FrontEnd_TC_111607()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111607", "1", "TRUE", "Status", "Inactive");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186894", "TC_111607", "1", "TRUE", "UpdateToStatus", "Deactivated");
        }
        #endregion TP_186894

        #region TP_186906
        private static void AddTestData_FrontEnd_TC_115262()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186906", "TC_115262", "1", "TRUE", "Email", "testdivya");
        }
        private static void AddTestData_FrontEnd_TC_115265()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186906", "TC_115265", "1", "TRUE", "Email", "testdivya");
        }
        private static void AddTestData_FrontEnd_TC_115266()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186906", "TC_115266", "1", "TRUE", "Email", "testdivya");
        }
        private static void AddTestData_FrontEnd_TC_115267()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186906", "TC_115267", "1", "TRUE", "AlreadyExistEmail", "testdivya20@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_186906", "TC_115267", "1", "TRUE", "Email", "testdivya21@cendyn17.com");
        }
        private static void AddTestData_Admin_TC_115267(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186906", "TC_115267", "1", "TRUE", "Email", "testdivya12@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186906", "TC_115267", "1", "TRUE", "AlreadyExistEmail", "testdivya20@cendyn17.com");
        }
        #endregion TP_186906

        #region TP_186921
        /*No Test Data available 221412*/
        private static void AddTestData_Admin_TC_146636(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146636", "1", "TRUE", "Status", "Active");
        }

        private static void AddTestData_Admin_TC_146637(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146637", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146637", "1", "TRUE", "DepartureFrom", "01/04/2016");
        }

        private static void AddTestData_Admin_TC_146638(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146638", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146638", "1", "TRUE", "DepartureTo", "08/06/2016");
        }

        private static void AddTestData_Admin_TC_146639(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146639", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146639", "1", "TRUE", "DepartureFrom", "01/04/2018");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146639", "1", "TRUE", "DepartureTo", "08/06/2018");
        }

        private static void AddTestData_Admin_TC_146642(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146642", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146642", "1", "TRUE", "Firstname", "test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146642", "1", "TRUE", "DepartureFrom", "01/04/2016");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146642", "1", "TRUE", "DepartureTo", "08/06/2018");
        }

        private static void AddTestData_Admin_TC_146643(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146643", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146643", "1", "TRUE", "Firstname", "%''%   ");
        }

        private static void AddTestData_Admin_TC_147010(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_147010", "1", "TRUE", "Status", "Active");
        }

        private static void AddTestData_Admin_TC_147013(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_147013", "1", "TRUE", "Status", "Active");
        }

        private static void AddTestData_Admin_TC_221383(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221383", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221383", "1", "TRUE", "SearchEmail", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221383", "1", "TRUE", "DepartureFrom", "10/5/2016");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221383", "1", "TRUE", "DepartureTo", "10/10/2016");
        }
        private static void AddTestData_Admin_TC_221400(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221400", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221400", "1", "TRUE", "Apostrophe", "%''%");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221400", "1", "TRUE", "Numeric", "%[0-9]%");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_221400", "1", "TRUE", "SpecialCharacter", "%[!@#$%]%");
        }

        private static void AddTestData_Admin_TC_146644(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146644", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146644", "1", "TRUE", "Firstname", "%''%");
        }
        private static void AddTestData_Admin_TC_146645(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146645", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146645", "1", "TRUE", "Firstname", "%[0-9]%");
        }
        private static void AddTestData_Admin_TC_146646(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146646", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_146646", "1", "TRUE", "Firstname", "%,,.%");
        }
        private static void AddTestData_Admin_TC_147007(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_186921", "TC_147007", "1", "TRUE", "Status", "Active");
        }
        #endregion TP_186921

        #region TP_190877
        private static void AddTestData_Admin_TC_147743(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_190877", "TC_147743", "1", "TRUE", "Status", "Active");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_190877", "TC_147743", "1", "TRUE", "EmailStatus", "Confirmed");
        }
        private static void AddTestData_FrontEnd_TC_147743()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_190877", "TC_147743", "1", "TRUE", "HomePhoneNumber", "(213)+1234565656");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_190877", "TC_147743", "1", "TRUE", "Status", "Active");
        }
        private static void AddTestData_Admin_TC_147758(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_190877", "TC_147758", "1", "TRUE", "Status", "Inactive");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_190877", "TC_147758", "1", "TRUE", "EmailStatus", "Confirmed");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_190877", "TC_147758", "1", "TRUE", "UpdateStatus", "Deactivated");
        }

        private static void AddTestData_FrontEnd_TC_147758()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_190877", "TC_147758", "1", "TRUE", "DeactivateStatus", "Deactivated");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_190877", "TC_147758", "1", "TRUE", "Status", "Inactive");
        }
        private static void AddTestData_FrontEnd_TC_166407()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_190877", "TC_166407", "1", "TRUE", "Status", "Active");
        }
        #endregion TP_190877

        #region TP_193880
        private static void AddTestData_Admin_TC_194195(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194195", "1", "TRUE", "AwardName", "Award");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194195", "1", "TRUE", "AwardType", "Birthday Based");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194195", "1", "TRUE", "DaysActive", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194195", "1", "TRUE", "AdvanceDeliveryDays", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194195", "1", "TRUE", "EmailName", "Birthday Email");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194195", "1", "TRUE", "OrigamiEmailName", "Birthday Free Night");
        }
        private static void AddTestData_Admin_TC_194218(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194218", "1", "TRUE", "Reason", "Adjustment_Text");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194218", "1", "TRUE", "Code", "ATe");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194218", "1", "TRUE", "SearchUser", "test");
        }
        private static void AddTestData_Admin_TC_194219(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194219", "1", "TRUE", "SignUpSourceCode", "Test_SourceCode");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194219", "1", "TRUE", "SignUpSource", "Test_SignUpSource");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194219", "1", "TRUE", "SearchUser", "test");
        }
        private static void AddTestData_Admin_TC_194221(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194221", "1", "TRUE", "Title", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194221", "1", "TRUE", "Description", "Test_SignUpSource");
        }

        private static void AddTestData_Admin_TC_218604(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218604", "1", "TRUE", "FirstName", "QATest");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218604", "1", "TRUE", "LastName", "LastName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218604", "1", "TRUE", "DOB", "12/05/2001");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218604", "1", "TRUE", "MembershipLevel", "Club Member");
        }

        private static void AddTestData_Admin_TC_124497(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_124497", "1", "TRUE", "AwardStatus", "SNT");
        }

        private static void AddTestData_Admin_TC_194035(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "Name", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "Description", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "Priority", "101");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194035", "1", "TRUE", "PointExpiryMonth", "10");
        }

        private static void AddTestData_Admin_TC_194222(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194222", "1", "TRUE", "Title", "Test Offers");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194222", "1", "TRUE", "PromotionCode", "Offers");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194222", "1", "TRUE", "ButtonText", "Offers");
        }

        private static void AddTestData_Admin_TC_194231(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194231", "1", "TRUE", "Filter", "Welcome");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194231", "1", "TRUE", "EmailName", "Test Welcome");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194231", "1", "TRUE", "Subject", "Welcome to Loyalty");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194231", "1", "TRUE", "EmailContent", "Test Email Content");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194231", "1", "TRUE", "EmailTermsAndConstions", "Test Condition");
        }

        private static void AddTestData_Admin_TC_194242(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194242", "1", "TRUE", "UserFirstname", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194242", "1", "TRUE", "UserLastname", "Auto Divya");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194242", "1", "TRUE", "UserLogin", "TestAutomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194242", "1", "TRUE", "UserTitle", "Admin");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194242", "1", "TRUE", "UserPermission", "Admin");
        }
        private static void AddTestData_Admin_TC_209620(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_209620", "1", "TRUE", "AdminLockoutAttempt", "Admin Lockout Attempts Number:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_209620", "1", "TRUE", "Username", "testuserorigami@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_209620", "1", "TRUE", "InvalidPassword", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_209620", "1", "TRUE", "IncorrectPasswordErrorMessage", "Password is incorrect.");
        }
        private static void AddTestData_Admin_TC_218599(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "FirstName", "John");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "LastName", "Parker");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "DOB", "12/05/2000");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "MembershipID", "98654321");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "MemberShipLevel", "Club Memberold");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "RegistrationDate", "02/05/2009");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "ReferralCode", "123456789");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "Language", "zh-CHS");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "ConfirmPassword", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_218599", "1", "TRUE", "VerficationText", "Welcome");
        }

        private static void AddTestData_Admin_TC_222092(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_222092", "1", "TRUE", "AdminEmail", "automationtestorigami@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_222092", "1", "TRUE", "InvalidEmail", "testorigami@cendyn.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_222092", "1", "TRUE", "InvalidPassword", "ccendyn123");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_222092", "1", "TRUE", "InvalidMessage", "This email does not match any of our records. Please contact admin for further assistance.");
        }

        private static void AddTestData_Admin_TC_227232(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "FirstName", "QATest");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "LastName", "Automation");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "DOB", "12/05/2000");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "MemberShipLevel", "Preferred Club Member");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "Language", "zh-CHS");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "ReferralCode", "1234333");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_227232", "1", "TRUE", "SheetName", "eLoyalty Update Member Template");
        }
        private static void AddTestData_Admin_TC_221131(string clientname)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "1", "TRUE", "FirstName", "John");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "1", "TRUE", "LastName", "Cena");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "2", "TRUE", "FirstName", "_John");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "2", "TRUE", "LastName", "_Cena");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "3", "TRUE", "FirstName", "John_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "3", "TRUE", "LastName", "Cena_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "4", "TRUE", "FirstName", "J_ohn");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "4", "TRUE", "LastName", "C_ena");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "5", "TRUE", "FirstName", "8John");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "5", "TRUE", "LastName", "8Cena");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "6", "TRUE", "FirstName", "John8");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "6", "TRUE", "LastName", "Cena8");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "7", "TRUE", "FirstName", "123");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_221131", "7", "TRUE", "LastName", "321");
        }
        private static void AddTestData_Admin_TC_194749(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Home_Tab", "Loyalty Search");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Home_MemberSearch_SubTab", "Loyalty Search");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Home_MemberInformation_SubTab", "Member Information");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "MemberInformation_SubTabs", "Member Awards");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "2", "TRUE", "MemberInformation_SubTabs", "Member Stays");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "3", "TRUE", "MemberInformation_SubTabs", "Member Transactions");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "4", "TRUE", "MemberInformation_SubTabs", "Invites");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "5", "TRUE", "MemberInformation_SubTabs", "Redemptions");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "6", "TRUE", "MemberInformation_SubTabs", "Admin Updates");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "MemberBatchUpload_Tab", "Member Batch Registration");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "BatchRegistration_SubTab", "Member Batch Registration");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "BatchUpdate_SubTab", "Member Batch Updates");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyRule_Tab", "General Rules");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyRules_SubTabs", "Qualifying Rules");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "2", "TRUE", "LoyaltyRules_SubTabs", "Points Earning Rules");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "3", "TRUE", "LoyaltyRules_SubTabs", "Award Earning Rules");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "4", "TRUE", "LoyaltyRules_SubTabs", "Member Level Rules");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyAward_Tab", "Loyalty Awards");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyeGifts_Tabs", "Loyalty eGifts");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyeGifts_SubTabs", "Loyalty eGifts");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "2", "TRUE", "LoyaltyeGifts_SubTabs", "Marketing Partners");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "3", "TRUE", "LoyaltyeGifts_SubTabs", "Account Balances");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyeSetup_Tab", "Transaction Reasons");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyeSetup_SubTabs", "Transaction Reasons");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "2", "TRUE", "LoyaltyeSetup_SubTabs", "Sign Up Sources");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "3", "TRUE", "LoyaltyeSetup_SubTabs", "FAQ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "4", "TRUE", "LoyaltyeSetup_SubTabs", "Terms & Conditions");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "5", "TRUE", "LoyaltyeSetup_SubTabs", "Offers");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "6", "TRUE", "LoyaltyeSetup_SubTabs", "Member Types");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "7", "TRUE", "LoyaltyeSetup_SubTabs", "Rate Exchange");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "8", "TRUE", "LoyaltyeSetup_SubTabs", "PMS Rate Codes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "9", "TRUE", "LoyaltyeSetup_SubTabs", "Award Types");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "10", "TRUE", "LoyaltyeSetup_SubTabs", "Referral Program");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyEmailSetup_Tab", "Email Dashboard");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "ManualMerge_Tab", "Member Results");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "SearchMember_SubTab", "Member Results");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "MemberMerge_SubTab", "Member Merge");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Users_Tab", "Users");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Users_SubTabs", "Users");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "2", "TRUE", "Users_SubTabs", "User Log");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "3", "TRUE", "Users_SubTabs", "Roles");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Roles_SubTab", "Edit");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "UserLog_SubTab", "Users Log");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "4", "TRUE", "Users_SubTabs", "User Settings");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "Redeem_Tab", "Redemption");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "ContentManagment_Tab", "Content Management");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyMapping_Tab", "Rate Code Mapping");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "1", "TRUE", "LoyaltyMapping_SubTab", "Rate Code");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "2", "TRUE", "LoyaltyMapping_SubTab", "Source Code");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "3", "TRUE", "LoyaltyMapping_SubTab", "Room Type");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_194749", "4", "TRUE", "LoyaltyMapping_SubTab", "Upload Log");
        }
        private static void AddTestData_Admin_TC_242619(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_242619", "1", "TRUE", "Title", "Automation_Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_242619", "1", "TRUE", "Description", "This test case is written for Terms and Condition to verify Add Terms and Condition, Edit Terms and Condition and Delete Terms and Condition. There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc. ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_242619", "1", "TRUE", "Edited_Description", "This test case is written for Terms and Condition to verify Add Terms and Condition, Edit Terms and Condition and Delete Terms and Condition");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_242619", "1", "TRUE", "ValidationMessage", "No matching records found");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_242619", "1", "TRUE", "iFrameId", "tcdesc_ifr");
        }
        private static void AddTestData_Admin_TC_109687(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "PromotionValidation", "Please add promotion");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "Title_Edit", "Auto_Offer_Edit");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "VisibilityStartDate_Edit", DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "VisibilityEndDate_Edit", DateTime.Now.AddDays(2).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109687", "1", "TRUE", "ShortDescription_Edit", "Test Description Edited");

        }
        private static void AddTestData_Admin_TC_116201(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_116201", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_116201", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_116201", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_116201", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_116201", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
        }

        public static void AddTestData_Admin_TC_208722(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "AwardName", "test eGift award Points Based");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "ValidationMsg", "No data available");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "ErrorMsg_1", "eGifts with Ordered or Expired status cannot be changed");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "ErrorMsg_2", "eGifts cannot be redeemed or consumed here.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "OrderedText", "Ordered");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "Status", "Issued");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "2", "TRUE", "Status", "Redeemed");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "3", "TRUE", "Status", "Expired");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "4", "TRUE", "Status", "Consumed");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "5", "TRUE", "Status", "Canceled");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "AwardExpMonth", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "AwardName", "Automation_Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "AwardType", "Points Based");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "Balance", "100");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "CardAmount", "5");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "Catalog", "Darden eGift Card");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "Code", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "CouponName", "CoupOne");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "EmailText", "Points Award Email");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "MarketingPartner", "Tango Cards");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "MemberLevelText", "Club Member");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "PointValue", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_208722", "1", "TRUE", "Comment", "AutomationTest");

        }
        private static void AddTestData_Admin_TC_226427(string clientName)
        {

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_226427", "1", "TRUE", "ValidationMessage", "We didn't find anything.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_226427", "1", "TRUE", "TextMessage", "Send Member Level-up email to the member?");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_226427", "1", "TRUE", "YesText", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_226427", "1", "TRUE", "NoText", "No");
        }
        private static void AddTestData_Admin_TC_226431(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_226431", "1", "TRUE", "ValidationMessage", "We didn't find anything.");
        }

        public static void AddTestData_Admin_TC_272803()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "LabelValue", "Minimum Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "2", "TRUE", "LabelValue", "Minimum Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "3", "TRUE", "LabelValue", "Minimum F&B Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "4", "TRUE", "LabelValue", "Minimum Other Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "5", "TRUE", "LabelValue", "Minimum Nights");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "6", "TRUE", "LabelValue", "Minimum Stays");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "7", "TRUE", "LabelValue", "Maximum Stays");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "8", "TRUE", "LabelValue", "Market Codes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "9", "TRUE", "LabelValue", "Rates Codes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "10", "TRUE", "LabelValue", "Hotels");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "11", "TRUE", "LabelValue", "Room Types");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "12", "TRUE", "LabelValue", "Source of Business");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "13", "TRUE", "LabelValue", "Booking Date");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "14", "TRUE", "LabelValue", "Join Date");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "15", "TRUE", "LabelValue", "Market/Rate Combo");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MinRevenueVal", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MinRoomRevenueVal", "15");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MinFnBRevenueVal", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MinOtherRevenueVal", "25");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MinNightVal", "30");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MinStayVal", "35");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MaxStayVal", "40");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MarketCodeVal", "AD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "LabelValue", "Market Codes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "RateCodeVal", "1NS");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "HotelsVal", "Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "RoomTypesVal", "BL");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "SourceOfBusinessVal", "1A");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "ChannelCodesVal", "ABP");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "MarketComboVal", "AD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "RateComboVal", "13ST");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "BookingDateValidation", "Invalid Booking Date Range.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_193880", "TC_272803", "1", "TRUE", "JoinDateValidation", "Invalid Join Date Range.");
        }

        #endregion TP_193880

        #region TP_207379
        private static void AddTestData_FrontEnd_TC_109687()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109687", "1", "TRUE", "ButtonText", "Offers");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109687", "1", "TRUE", "PromotionCode", "Offers");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109687", "1", "TRUE", "Title", "Test Offers");
        }
        
        //private static void AddTestData_FrontEnd_TC_109739()
        //{
        //    TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109739", "1", "TRUE", "ButtonText", "Book Now");
        //    TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109739", "1", "TRUE", "PromotionCode", "Offers");
        //    TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109739", "1", "TRUE", "Title", "Ruchi offer");
        //}
        private static void AddTestData_FrontEnd_TC_109741()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109741", "1", "TRUE", "ButtonText", "Book Now");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109741", "1", "TRUE", "PromotionCode", "#@Offers@$5#$%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_109741", "1", "TRUE", "Title", "Test");
        }
        private static void AddTestData_FrontEnd_TC_110850()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_110850", "1", "TRUE", "Title", "Hurray");
        }
        private static void AddTestData_FrontEnd_TC_110855()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_110855", "1", "TRUE", "ButtonText", "Book Now");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_110855", "1", "TRUE", "PromotionCode", "#@Offers@$5#$%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_110855", "1", "TRUE", "Title", "Hurray");
        }
        private static void AddTestData_FrontEnd_TC_116222()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_116222", "1", "TRUE", "ButtonText", "Book Now");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_116222", "1", "TRUE", "PromotionCode", "#@Offers@$5#$%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_116222", "1", "TRUE", "Title", "Hurray");
        }
        private static void AddTestData_FrontEnd_TC_118019()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_118019", "1", "TRUE", "ButtonText", "Book Now");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_118019", "1", "TRUE", "PromotionCode", "Offers Code");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_207379", "TC_118019", "1", "TRUE", "Title", "Test Offers");
        }
        #endregion TP_207379

        #region TP_218533
        private static void AddTestData_FrontEnd_TC_109958()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "CaptchaValidation", "The captcha field is required");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "Card", "Automation_Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "Confirm", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "Email", "QATest_automation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "FirstName", "QATest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "LastName", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109958", "1", "TRUE", "Validationmessage", "Field cannot be blank.");
        }
        private static void AddTestData_FrontEnd_TC_109959()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "CardName", "Automation Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "ConformPassword", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "Email", "abc.xyz.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "FirstName", "Joe");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "LastName", "Smith");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "1", "TRUE", "ValidationMessage", "Invalid email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "2", "TRUE", "Email", "#@%^%#$@#$@#.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "3", "TRUE", "Email", "@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "4", "TRUE", "Email", "user Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "5", "TRUE", "Email", "TestUser.Cendyn17.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "6", "TRUE", "Email", "TestUser@Cendyn17@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "7", "TRUE", "Email", ".TestUser@Cendyn17.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "8", "TRUE", "Email", " TestUser.@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "9", "TRUE", "Email", "email..@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "10", "TRUE", "Email", "TestUser@Cendyn17");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "11", "TRUE", "Email", "TestUser@-Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "12", "TRUE", "Email", "TestUser@111.222.333.44444 ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "13", "TRUE", "Email", "TestUser@Cendyn17.comsfdc");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "14", "TRUE", "Email", "TestUser@Cendyn17.com_____");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "15", "TRUE", "Email", "TestUser@Cendyn17.comesdf_____");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "16", "TRUE", "Email", "​​_harry104@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "17", "TRUE", "Email", "-harry104@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "18", "TRUE", "Email", "+test901@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "19", "TRUE", "Email", "harry104-@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_109959", "20", "TRUE", "Email", "​test901+@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_112091()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112091", "1", "TRUE", "InviteFriendsValidation", "This field is required");
        }
        private static void AddTestData_FrontEnd_TC_112270()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112270", "1", "TRUE", "Subject", "Missing Stays/Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112270", "2", "TRUE", "Subject", "Points Redemption Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112270", "3", "TRUE", "Subject", "Reservations Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112270", "4", "TRUE", "Subject", "Feedback on Property");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112270", "5", "TRUE", "Subject", "Feedback on Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112270", "6", "TRUE", "Subject", "Other");
        }
        private static void AddTestData_FrontEnd_TC_116403()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_116403", "1", "TRUE", "AwardStatus", "RED");
        }
        private static void AddTestData_FrontEnd_TC_116979()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_116979", "1", "TRUE", "AwardStatus", "SNT");
        }

        private static void AddTestData_FrontEnd_TC_217847()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_217847", "1", "TRUE", "AwardName", "Test Red4");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_217847", "1", "TRUE", "Balance", "100");
        }
        private static void AddTestData_FrontEnd_TC_218534()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218534", "1", "TRUE", "NewPassword", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218534", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218534", "1", "TRUE", "Username", "etcwk@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_218535()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218535", "1", "TRUE", "NewPassword", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218535", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218535", "1", "TRUE", "Registered Email", "mohamedobaidall@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_218540(string clientName)
        {
            if (clientName == "Sarova")
            {
                TestDataHelper.AddRecord("Sarova", "FrontEnd", "TestCase", "TP_218533", "TC_218540", "1", "TRUE", "Subject", "FeedBack on Property");
                TestDataHelper.AddRecord("Sarova", "FrontEnd", "TestCase", "TP_218533", "TC_218540", "1", "TRUE", "Subject1", "Reservations Inquiry");
            }
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218540", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218540", "1", "TRUE", "Subject", "Feedback on Property");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218540", "1", "TRUE", "Subject1", "Missing Stays/Points");
        }
        private static void AddTestData_FrontEnd_TC_218547()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218547", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_218547", "1", "TRUE", "Registered Email", "mohamedobaidall@cendyn17.com");
        }
        private static void AddTestData_FrontEnd_TC_112275()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "1", "TRUE", "Text", "@@$$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "1", "TRUE", "Subject", "Missing Stays/Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "2", "TRUE", "Subject", "Points Redemption Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "3", "TRUE", "Subject", "Reservations Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "4", "TRUE", "Subject", "Feedback on Property");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "5", "TRUE", "Subject", "Feedback on Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112275", "6", "TRUE", "Subject", "Other");
        }
        private static void AddTestData_FrontEnd_TC_112423()
        {
            Random randomnumber = new Random();
            string rannumber = randomnumber.Next().ToString();
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "1", "TRUE", "EmailAddress", rannumber + "TestUser@cendyn17");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "2", "TRUE", "EmailAddress", "TestUser" + rannumber + "@-cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "3", "TRUE", "EmailAddress", "TestUser" + rannumber + "@cendyn17.com_____");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "4", "TRUE", "EmailAddress", rannumber + "TestUser@cendyn17.comesdf_____");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "5", "TRUE", "EmailAddress", "@%^%#$@#$@#.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "6", "TRUE", "EmailAddress", "@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "7", "TRUE", "EmailAddress", "user Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "8", "TRUE", "EmailAddress", "TestUser" + rannumber + ".cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "9", "TRUE", "EmailAddress", "TestUser" + rannumber + "@cendyn17@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "10", "TRUE", "EmailAddress", rannumber + "TestUser.@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "11", "TRUE", "EmailAddress", "email." + rannumber + ".@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "1", "TRUE", "EmailAddressValidation", "An email address has incorrect format, please fix before continuing.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "2", "TRUE", "ValidEmailAddress", "email@domain-one.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "3", "TRUE", "ValidEmailAddress", "_______@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "4", "TRUE", "ValidEmailAddress", "email@domain.name");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "5", "TRUE", "ValidEmailAddress", "firstname-lastname@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "6", "TRUE", "ValidEmailAddress", "email@subdomain.domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "7", "TRUE", "ValidEmailAddress", "email@domain.co.jp");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "8", "TRUE", "ValidEmailAddress", "firstname.lastname@domain.co.au");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "9", "TRUE", "ValidEmailAddress", "firstname_lastname@domain.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112423", "10", "TRUE", "ValidEmailAddress", "1234567890@domain.com");
        }

        private static void AddTestData_FrontEnd_TC_112426()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "1", "TRUE", "InviteFriendsExpectedValidationmessage", "This field can't have more than 200 characters");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "1", "TRUE", "InvitationEmail", "testUser@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "2", "TRUE", "InvitationEmail", "testuserawsered@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "3", "TRUE", "InvitationEmail", "uydfydfydfydfidfiudyfiudfyiuayifyauifyiayfiyzxchzkkkkkkkkkkkkkkkkkkkdhayfyafyzchajhfeyafaihzkczdkcnz@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "4", "TRUE", "InvitationEmail", "fffffffffvffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffdkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkffffffffffffffffffffffddddddffff@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "5", "TRUE", "InvitationEmail", "fffffffffvfffffffgfdffffffffffffffffffffffffffffffffffffffffffffffffffffffdkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkffffffffffffffffffffffddddddfffdrf@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "1", "TRUE", "InviteMailContentExpectedValidationmessage", "This field can't have more than 500 characters");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_112426", "1", "TRUE", "InviteMailContent", "yfeftwatyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyysvgddvsad@Cendyn17.com");
        }
        
        private static void AddTestData_FrontEnd_TC_223768()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223768", "1", "TRUE", "ValidationMesssage", "This account has been deactivated. If you feel you have reached this message in error please contact us.");
        }
        private static void AddTestData_FrontEnd_TC_223767()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223767", "1", "TRUE", "MemberType", "Loyalty");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223767", "1", "TRUE", "EmailStatus", "Pending");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223767", "1", "TRUE", "MemberStatus", "Active");
        }
        private static void AddTestData_FrontEnd_TC_223762()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223762", "1", "TRUE", "WrongPasswordPassword", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223762", "1", "TRUE", "ValidationMessage", "Please enter valid credentials.");
        }
        private static void AddTestData_FrontEnd_TC_223760()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223760", "1", "TRUE", "WrongPasswordPassword", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223760", "1", "TRUE", "ValidationMessage", "Please enter valid credentials.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_218533", "TC_223760", "1", "TRUE", "SetPassword", "Cendyn1234$");

        }

        #region TP_121741

        private static void AddTestData_FrontEnd_TC_216107()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_216107", "1", "TRUE", "Name", "Name");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_216107", "1", "TRUE", "Membership_No", "Membership No.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_216107", "1", "TRUE", "Email", "Email");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_216107", "1", "TRUE", "Phone", "Phone");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_216107", "1", "TRUE", "Subject", "Subject");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_216107", "1", "TRUE", "Message", "Message");

        }
        private static void AddTestData_FrontEnd_TC_224924()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_224924", "1", "TRUE", "FilePath", @"\Admin_Offer_DummyImage\TC_224924_DummyImage.JPEG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_224924", "1", "TRUE", "PhoneNo", "123-23-1234");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_224924", "1", "TRUE", "Subject", "Points Redemption Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_224924", "1", "TRUE", "Message", "This is Dummy Contact us Message");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_224924", "1", "TRUE", "Image_Text", "TC_224924_DummyImage");

        }
        private static void AddTestData_FrontEnd_TC_238611()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_238611", "1", "TRUE", "FilePath", @"\Admin_Offer_DummyImage\TC_238611_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_238611", "1", "TRUE", "ValidationMessage", "Upload failed. Each file must not exceed 2MB");


        }
        private static void AddTestData_FrontEnd_TC_237552()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_237552", "1", "TRUE", "FilePath", @"\Admin_Offer_DummyImage\TC_237552_DummyImage");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_AutoIT", "TC_237552", "1", "TRUE", "ValidationMessage", "You cannot upload more than 5 files");


        }

        #endregion TP_121741

        #endregion TP_218533

        #region TP_256428
        private static void AddTestData_Admin_TC_255553()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255553", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255553", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255553", "1", "TRUE", "MembershipLevel_Name_Validation", "Please enter a membership level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255553", "1", "TRUE", "MembershipCode_Validation", "Please enter a membership code");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255553", "1", "TRUE", "MemberLevel_Order_Validation", "Please enter a member level order");
        }
        private static void AddTestData_Admin_TC_255554()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255554", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255554", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255554", "1", "TRUE", "Process_By_Service", "Yes");
        }
        private static void AddTestData_Admin_TC_255556()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255556", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255556", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255556", "1", "TRUE", "Process_By_Service", "No");
        }
        private static void AddTestData_Admin_TC_255563()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255563", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255563", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255563", "1", "TRUE", "Process_By_Service", "Yes");
        }
        private static void AddTestData_Admin_TC_255557()
        {

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "MemberLevelName", "Test_Member_Level_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "MemberLevelCode", "TML_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "Field", "      spaces");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "2", "TRUE", "Field", "#@$&&&");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "3", "TRUE", "Field", "5657657");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "4", "TRUE", "Field", "rtrtgfhgjyurtewrwaedsadcgfjyg");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "5", "TRUE", "Field", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "2", "TRUE", "Service", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "Error_LevelOrder1", "Please enter a member level order");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "Error_LevelOrder2", "Save failed. You cannot enter a negative level order");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "ErrorMessage_MemberLevel", "Please enter a membership level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255557", "1", "TRUE", "ErrorMessage_MemberCode", "Please enter a membership code");
        }
        private static void AddTestData_Admin_TC_255559()
        {

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255559", "1", "TRUE", "MemberLevelName", "Test_Member_Level_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255559", "1", "TRUE", "MemberLevelCode", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255559", "1", "TRUE", "Service", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255559", "1", "TRUE", "ValidationMessage_MemberLevel", "Save failed. You cannot enter duplicated membership level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255559", "1", "TRUE", "ValidationMessage_Code", "Save failed. You cannot enter duplicated membership code");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255559", "1", "TRUE", "ValidationMessage_LevelOrder", "Save failed. You cannot enter duplicated level order");
        }
        private static void AddTestData_Admin_TC_255575()
        {

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "0", "TRUE", "RuleType", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "RuleType", "Level Up");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "0", "TRUE", "DefaultRule", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "DefaultRule", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "MonthPeriod_Validation", "Month Period must be greater than 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "MonthPeriod", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "MonthPeriod", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "MonthPeriod", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "MonthPeriod", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "MonthPeriod", "5");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "QualifiedNight_Validation", "Number Of Qualified Nights: Please enter a positive number or leave it 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "QualifiedNight_Negative_Validation", "Save failed. Please enter a positive Number Of Qualified Nights");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "QualifiedNight", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "QualifiedNight", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "QualifiedNight", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "QualifiedNight", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "QualifiedNight", "3");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "StayProperties_Validation", "Number of Stay Properties: Please enter a positive number or leave it 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "StayProperties_Negative_Validation", "Save failed. Please enter a positive Number of Stay Properties");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "StayProperties", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "StayProperties", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "StayProperties", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "StayProperties", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "StayProperties", "1");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "QualifiedStay_Validation", "Number of Qualified Stays: Please enter a positive number or leave it 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "QualifiedStay_Negative_Validation", "Save failed. Please enter a positive Number of Qualified Stays");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "QualifiedStay", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "QualifiedStay", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "QualifiedStay", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "QualifiedStay", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "QualifiedStay", "4");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "CheckedOutStay_Validation", "Number of Checked Out Stays: Please enter a positive number or leave it 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "CheckOutStay_Negative_Validation", "Save failed. Please enter a positive Number of Checked Out Stays");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "CheckOutStay", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "CheckOutStay", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "CheckOutStay", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "CheckOutStay", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "CheckOutStay", "4");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "Points_Validation", "Points: Please enter a positive number or leave it 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "Points_Negative_Validation", "Save failed. Please enter a positive Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "Points", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "Points", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "Points", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "Points", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "Points", "50");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "Revenue_Validation", "Revenue: Please enter a positive number or leave it 0");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "Revenue_Negative_Validation", "Save failed. Please enter a positive Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "1", "TRUE", "Revenue", "    ");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "2", "TRUE", "Revenue", "abc");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "3", "TRUE", "Revenue", "##$$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "4", "TRUE", "Revenue", "-12");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255575", "5", "TRUE", "Revenue", "100");

        }
        private static void AddTestData_Admin_TC_255561()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255561", "1", "TRUE", "MembershipLevel_Name", "M_Level_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255561", "1", "TRUE", "MembershipLevel_Code", "T_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255561", "1", "TRUE", "Process_By_Service", "Yes");
        }
        private static void AddTestData_Admin_TC_255562()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255562", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255562", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255562", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255562", "1", "TRUE", "Process_By_Service_Edit", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255562", "1", "TRUE", "MembershipLevel_Name_Validation", "Please enter a membership level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255562", "1", "TRUE", "MemberLevel_Order_Validation", "Please enter a member level order");
        }
        private static void AddTestData_Admin_TC_255564()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255564", "1", "TRUE", "Delete_Validation", "You cannot delete a member level in use");

        }

        private static void AddTestData_Admin_TC_255573()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "Rule_Type", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "Default_Rule", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "Month_Period", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "No_Of_QNights", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "No_Of_StayProp", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "No_Of_QualStays", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "No_Of_CheckedOutStays", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "Points", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255573", "1", "TRUE", "Revenue", "1");

        }

        private static void AddTestData_Admin_TC_255574()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "Rule_Type", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "Default_Rule", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255574", "1", "TRUE", "Month_Period", "1");

        }

        private static void AddTestData_Admin_TC_255578()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "Rule_Type", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "Default_Rule", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255578", "1", "TRUE", "Month_Period", "1");

        }

        private static void AddTestData_Admin_TC_255576()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "Rule_Type", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "Default_Rule", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "Month_Period", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "No_Of_QNights", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "No_Of_StayProp", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "No_Of_QualStays", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "No_Of_CheckedOutStays", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "Points", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255576", "1", "TRUE", "Revenue", "1");

        }

        private static void AddTestData_Admin_TC_255577()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Rule_Type", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Default_Rule", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Month_Period", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_QNights", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_StayProp", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_QualStays", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_CheckedOutStays", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Points", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Revenue", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "MembershipLevel_Name_Edit", "Member Level Edit");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "MembershipCode_Edit", "TML_Edit");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "MembershipLevel_Name_Edit", "Member Level Edit");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Rule_Type_Edit", "Level Up");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Default_Rule_Edit", "No");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Month_Period_Edit", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Month_Period_Edit", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_StayProp_Edit", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_QualStays_Edit", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "No_Of_CheckedOutStays_Edit", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Points_Edit", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255577", "1", "TRUE", "Revenue_Edit", "2");

        }
        private static void AddTestData_Admin_TC_255572()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "MembershipLevel_Code", "TML");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "Process_By_Service", "Yes");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "MembershipLevel_Name", "Test_Member_Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "Rule_Type", "Renew");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "Month_Period", "1");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "MembershipLevel_Name_Validation", "Please select a Member Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "Rule_Type_validation_message", "Please select a Rule Type");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_256428", "TC_255572", "1", "TRUE", "Month_Period_validation_message", "Month Period must be greater than 0");
        }


        #endregion TP_256428

        #region TP_224753
        private static void AddTestData_Admin_TC_146564()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_146564", "1", "TRUE", "ValidationMessage", "No data available");
        }
        private static void AddTestData_Admin_TC_149354()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_149354", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }
        private static void AddTestData_Admin_TC_146567()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_146567", "1", "TRUE", "ValidationMessage", "You do not have enough points to redeem this award");
        }
        private static void AddTestData_Admin_TC_146568()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_146568", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }

        private static void AddTestData_Admin_TC_146563()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_146563", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }

        private static void AddTestData_Admin_TC_149352()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_149352", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }

        private static void AddTestData_Admin_TC_149351()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_149351", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }
        private static void AddTestData_Admin_TC_149349()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_149349", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }
        private static void AddTestData_Admin_TC_149357()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_149357", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_149357", "1", "TRUE", "Status", "Canceled");
        }
        private static void AddTestData_Admin_TC_124627()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_124627", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_124627", "1", "TRUE", "ValidationMessage", "You do not have enough points to redeem this award");
        }
        private static void AddTestData_Admin_TC_124625()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_124625", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }
        private static void AddTestData_Admin_TC_124626()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_124626", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
        }
        private static void AddTestData_Admin_TC_175101()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_175101", "1", "TRUE", "AdminUrl", "https://origamiguestloyaltyadminqa.cendyn.com/");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_224753", "TC_175101", "1", "TRUE", "ValidationText", "Points Award Email");
        }


        #endregion TP_224753
        #region TP_250750
        private static void AddTestData_Admin_TC_122056()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "Description", "This is the Test Rule Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "MinimumRevenue", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "ParallelStay", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "MarketCode", "AN");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "2", "TRUE", "MarketCode", "ART");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "3", "TRUE", "MarketCode", "ARCH");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "SourceOfBusiness", "1A");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "2", "TRUE", "SourceOfBusiness", "AMAD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "3", "TRUE", "SourceOfBusiness", "AIR");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "ChannelCode", "ABP");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "2", "TRUE", "ChannelCode", "MAG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "3", "TRUE", "ChannelCode", "PMS");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "1", "TRUE", "NotAllowedValue", "-10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "2", "TRUE", "NotAllowedValue", "#@$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_122056", "3", "TRUE", "NotAllowedValue", "Test");

        }
        private static void AddTestData_Admin_TC_209606()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209606", "1", "TRUE", "Description", "This is the General Rule Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209606", "1", "TRUE", "MinimumRevenue", "3");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209606", "1", "TRUE", "ParallelStay", "3");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209606", "1", "TRUE", "MarketCode", "AIR");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209606", "1", "TRUE", "ChannelCode", "ABP");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209606", "1", "TRUE", "SourceOfBusiness", "1A");

        }
        private static void AddTestData_Admin_TC_240753()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "Description", "This is the Qualifying Night Rule Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "MinimumRevenue", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "MarketCode", "AN");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "2", "TRUE", "MarketCode", "ART");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "3", "TRUE", "MarketCode", "AD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "SourceOfBusiness", "AIR");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "2", "TRUE", "SourceOfBusiness", "AMAD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "3", "TRUE", "SourceOfBusiness", "1A");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "ChannelCode", "PMS");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "2", "TRUE", "ChannelCode", "MAG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "3", "TRUE", "ChannelCode", "ABP");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "NotAllowedValue", "-10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "2", "TRUE", "NotAllowedValue", "#@$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "3", "TRUE", "NotAllowedValue", "Test");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "RateCode", "COACH");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "2", "TRUE", "RateCode", "AOVO");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "3", "TRUE", "RateCode", "0000363700");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "MarketCombo", "ADVERT");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_240753", "1", "TRUE", "RateCombo", "13ST");


        }
        private static void AddTestData_Admin_TC_209605()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "Description", "This is the Test Rule Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "MinimumRevenue", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "MarketCode", "AN");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "SourceOfBusiness", "1A");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "ChannelCode", "ABP");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "RateCode", "COACH");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "MarketCombo", "ADVERT");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240750", "TC_209605", "1", "TRUE", "RateCombo", "13ST");
        }
        #endregion TP_240750
        #region TP_109658
        private static void AddTestData_Admin_TC_109684()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "TitleVaidation", "Please enter title.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "VisibilityStartValidation", "Please enter visibility start date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "VisibilityEndValidation", "Please enter visibility end date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "MemberLevelValidation", "Please select member level.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "PromotionStartValidation", "Please enter promotion start date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "PromotionEndValidation", "Please enter promotion end date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "ShortDescriptionValidation", "Please enter short description.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "ImageValidation", "Please upload a image.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "AddPromoionValidation", "Please add promotion.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "PromotionValidation", "Please add promotion");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "PromotionCodeValidation", "Please enter promotion code.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "ButtonTextValidation", "Please enter button text.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "DescriptionValidation", "Please enter description.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109684", "1", "TRUE", "HotelValidation", "Please select hotel.");
        }

        private static void AddTestData_Admin_TC_109686()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109686", "1", "TRUE", "Frontend_URL", "https://origami.qaeloyaltyportal.com/");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109686", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109686", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109686", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109686", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109686", "1", "TRUE", "ShortDescription", "Test Description");
        }

        private static void AddTestData_Admin_TC_109688()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109688", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109688", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109688", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109688", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109688", "1", "TRUE", "ShortDescription", "Test Description");
        }
        private static void AddTestData_Admin_TC_109689()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109689", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109689", "1", "TRUE", "Title", "Auto_Offer_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109689", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109689", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109689", "1", "TRUE", "ShortDescription", "Test Short Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109689", "1", "TRUE", "CancelButton_Validation", "No member data available, please update search.");
        }
        private static void AddTestData_Admin_TC_109750()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "VisibilityStartDate_Greater", DateTime.Now.AddDays(2).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "VisibilityDate_Validation", "Visibility end date must be greater than start date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109750", "1", "TRUE", "PromotionDate_Validation", "Promotion end date must be greater than start date.");
        }
        private static void AddTestData_Admin_TC_109685()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "Shortdescription_CharLimit", "ShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTest");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "Title_CharLimit", "TitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestvTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTest");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "PromoDescription_CharLimit", "PromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptiondddddddddddddddddddddddddddddddddddddddddddddddddddddDescriptionPromotionDescriptionPromotionDescription");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "PromoCode_CharLimit", "AutomationPromotionCode12344");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "ButtonText_CharLimit", "Testttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "Shortdescription_CharLimitValidation", "Short description can not more than 1000 characters.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "Title_CharLimit_CharLimitValidation", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "PromoDescription_CharLimitValidation", "Description can not more than 2000 characters.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "PromoCode_CharLimitValidation", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109685", "1", "TRUE", "ButtonText_CharLimitValidation", "Test Description");
        }


        #endregion TP_109658

        #region[TP_240322]

        private static void AddTestData_Admin_TC_116980()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116980", "1", "TRUE", "AwardStatus", "RNT");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116980", "1", "TRUE", "FrontEndStatus", "Issued");
        }
        private static void AddTestData_Admin_TC_116978()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116978", "1", "TRUE", "AwardStatus", "ORD");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116978", "1", "TRUE", "FrontEndStatus", "Ordered");
        }
        private static void AddTestData_Admin_TC_116401()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116401", "1", "TRUE", "AwardStatus", "EXP");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116401", "1", "TRUE", "DisplayStatus", "Expired");
        }
        private static void AddTestData_Admin_TC_116402()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116402", "1", "TRUE", "AwardStatus", "ISS");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116402", "1", "TRUE", "DisplayStatus", "Issued");
        }
        private static void AddTestData_Admin_TC_116404()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116404", "1", "TRUE", "AwardStatus", "CXL");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_116404", "1", "TRUE", "DisplayStatus", "Canceled");
        }
        private static void AddTestData_Admin_TC_264758()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_264758", "1", "TRUE", "AdminNoAward", "No member data available, please update search.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_264758", "1", "TRUE", "FrontendNoAward", "No data available");
        }
        private static void AddTestData_Admin_TC_130237()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_240322", "TC_130237", "1", "TRUE", "AwardStatus", "SNT");

        }

        #endregion[TP_240322]
        #region[TP_268973]

        private static void AddTestData_Admin_TC_217871()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "ReferralCodeText", "Referral Code");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "NumberOfNightsText", "Number of Nights");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "MemberLevelText", "Member Level");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "ActionText", "Action");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "5", "TRUE", "PaginationValue", "5");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "10", "TRUE", "PaginationValue", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "15", "TRUE", "PaginationValue", "15");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "20", "TRUE", "PaginationValue", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "ReferralCode", "Referral Code");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "QualifyingNight", "Qualifying Nights");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "StayType", "Stay Type");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217871", "1", "TRUE", "NewLevel", "New Level");

        }
        private static void AddTestData_Admin_TC_217877()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217877", "1", "TRUE", "ReferralCode", "ReferralCode");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217877", "1", "TRUE", "NumberOfNights", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217877", "1", "TRUE", "StayType", "Not Specified");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217877", "1", "TRUE", "ValidationMessage", "No member data available, please update search.");
        }
        private static void AddTestData_Admin_TC_217878()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217878", "1", "TRUE", "ReferralCode", "ReferralCode");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217878", "1", "TRUE", "NumberOfNights", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217878", "1", "TRUE", "StayType", "Not Specified");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217878", "1", "TRUE", "ReferralCode_Edit", "ReferralCode_Edit");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217878", "1", "TRUE", "NumberOfNights_Edit", "4");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217878", "1", "TRUE", "StayType_Edit", "Not Specified");
        }
        private static void AddTestData_Admin_TC_217879()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217879", "1", "TRUE", "ReferralCode", "ReferralCode");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217879", "1", "TRUE", "NumberOfNights", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217879", "1", "TRUE", "StayType", "Not Specified");
        }
        private static void AddTestData_Admin_TC_218238()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_218238", "1", "TRUE", "ReferralCode", "ReferralCode");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_218238", "1", "TRUE", "NumberOfNights", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_218238", "1", "TRUE", "StayType", "Not Specified");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_218238", "1", "TRUE", "ValidationMessage", "Save failed. Cannot save if a rule already exists for the New Level selected.");
        }
        private static void AddTestData_Admin_TC_217874()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "ReferralCode", "ReferralCode");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "NumberOfNights", "2");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "StayType", "Not Specified");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "ReferralValidation", "Referral Code is required");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "NightValidation", "Qualifying Nights should be greater than 0.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "StayValidation", "Please select a Stay Type.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_217874", "1", "TRUE", "NewLevelValidation", "Please select a New Level");
        }


        #endregion[TP_268973]

        #region[TP_111963]
        private static void AddTestData_Admin_TC_114486()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "Name", "Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "Priority", "101");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "1", "TRUE", "FiledOnOverlay", "Name:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "2", "TRUE", "FiledOnOverlay", "Based On:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "3", "TRUE", "FiledOnOverlay", "StartDate:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "4", "TRUE", "FiledOnOverlay", "End Date:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "5", "TRUE", "FiledOnOverlay", "Priority:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "6", "TRUE", "FiledOnOverlay", "Rule Type:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "7", "TRUE", "FiledOnOverlay", "For:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "8", "TRUE", "FiledOnOverlay", "Points Earned:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "9", "TRUE", "FiledOnOverlay", "Per:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "10", "TRUE", "FiledOnOverlay", "Calculated On:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "11", "TRUE", "FiledOnOverlay", "Points Expiry Month:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114486", "12", "TRUE", "FiledOnOverlay", "Include Member Level:");

        }
        private static void AddTestData_Admin_TC_114488()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114488", "1", "TRUE", "NameValidation", "That Name is already in use. Please enter another.");


        }
        private static void AddTestData_Admin_TC_114489()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114489", "1", "TRUE", "PriorityValidation", "Multiple Rules cannot have same priority, please enter another priority number.");


        }
        private static void AddTestData_Admin_TC_114490()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_114490", "1", "TRUE", "DateValidation", "Invalid Date Range");

        }
        private static void AddTestData_Admin_TC_224606()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_224606", "1", "TRUE", "RevenueType", "Room Revenue");

        }
        private static void AddTestData_Admin_TC_188991()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_188991", "1", "TRUE", "CalculatedOnValidation", "Please select Revenue Type.");
        }
        #endregion[TP_111963]

        #region[TP_113453]
        private static void AddTestData_Admin_TC_113457()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113457", "1", "TRUE", "TitleValidation", "That Name is already in use. Please enter another.");
        }
        private static void AddTestData_Admin_TC_116140()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116140", "1", "TRUE", "PriorityValidation", "Multiple Rules cannot have same priority, please enter another priority number.");
        }
        private static void AddTestData_Admin_TC_116141()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116141", "1", "TRUE", "DateValidation", "Invalid Date Range");
        }
        private static void AddTestData_Admin_TC_113454()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "1", "TRUE", "Status", "Inactive");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "BasedOn", "Arrival");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "For", "Stay");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "PointsEarned", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "Per", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "CalculatedOn", "Stay/Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "PointExpiryMonth", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_113454", "2", "TRUE", "RevenueType", "Other Revenue");

        }
        private static void AddTestData_Admin_TC_116328()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "Name", "Auto_Test_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "DisplayName", "Test_DisplayName");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "Description", "Test_Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "BasedOn", "Arrival And Departure");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "For", "Qualifying Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "PointsEarned", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "Per", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "CalculatedOn", "Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "PointExpiryMonth", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "RevenueType", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "1", "TRUE", "Status", "Active");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "BasedOn", "Arrival");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "RuleType", "Points");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "For", "Stay");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "PointsEarned", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "Per", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "CalculatedOn", "Stay/Night");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "PointExpiryMonth", "20");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_116328", "2", "TRUE", "RevenueType", "Other Revenue");
        }
        private static void AddTestData_Admin_TC_219503()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_111963", "TC_219503", "1", "TRUE", "ValidationMessage", "Multiple Rules cannot have same priority, please enter another priority number");

        }
        #endregion[TP_113453]

        #region[TP_264509]
        private static void AddTestData_Admin_TC_264512()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "1", "TRUE", "FromEmail", "From Email:");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "1", "TRUE", "EmailValidation", "Please enter the From Email.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "1", "TRUE", "InvalidEmailValidation", "From email should match the format: Display Name<from@domain.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "1", "TRUE", "Email", "Hotel Origami<#@%^%#$@#$@#.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "2", "TRUE", "Email", "Hotel Origami<@Cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "3", "TRUE", "Email", "Hotel Origami<user Test>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "4", "TRUE", "Email", "Hotel Origami<TestUser.Cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "5", "TRUE", "Email", "Hotel Origami<TestUser@Cendyn17@Cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "6", "TRUE", "Email", "Hotel Origami<.TeztUser@Cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "7", "TRUE", "Email", "Hotel Origami<TestUser.@Cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "8", "TRUE", "Email", "Hotel Origami<email..@Cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "9", "TRUE", "Email", "Hotel Origami<TestUser@Cendyn17>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "10", "TRUE", "Email", "Hotel Origami<TestUser@111.222.333.44444>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "11", "TRUE", "Email", "Hotel Origami<TestUser@Cendyn17.com_____>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "12", "TRUE", "Email", "Hotel Origami<TestUser@Cendyn17.comesdf_____>");

            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "13", "TRUE", "Email", "Hotel Origami<firstnamelastname@domain.name>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "14", "TRUE", "Email", "Hotel Origami<_______@domain.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "15", "TRUE", "Email", "Hotel Origami<email@domain.name>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "16", "TRUE", "Email", "Hotel Origami<firstname-lastname@domain.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "17", "TRUE", "Email", "Hotel Origami<firstname@yahoo.comm.in>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "18", "TRUE", "Email", "Hotel Origami<email@domain.co.jp>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "19", "TRUE", "Email", "Hotel Origami<firstname.lastname@domain.co.au>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "20", "TRUE", "Email", "Hotel Origami<firstname_lastname@domain.co.au>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264512", "21", "TRUE", "Email", "Hotel Origami<hotelorigami@cendyn.com>");
            

        }
        private static void AddTestData_Admin_TC_264521()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264521", "1", "TRUE", "FromEmail", "Origami <origami@cendyn17.com>");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_264509", "TC_264521", "2", "TRUE", "FromEmail", "Hotel Origami <hotelorigami@cendyn.com>");
        }
        #endregion[TP_264509]

        #region [TP_109659]
        private static void AddTestData_Admin_TC_109696()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "TitleVaidation", "Please enter title.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "VisibilityStartValidation", "Please enter visibility start date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "VisibilityEndValidation", "Please enter visibility end date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "MemberLevelValidation", "Please select member level.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "PromotionStartValidation", "Please enter promotion start date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "PromotionEndValidation", "Please enter promotion end date.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "ShortDescriptionValidation", "Please enter short description.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "ImageValidation", "Please upload a image.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "AddPromoionValidation", "Please add promotion.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddYears(2).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "PromotionValidation", "Please add promotion");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "PromotionCodeValidation", "Please enter promotion code.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "ButtonTextValidation", "Please enter button text.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "DescriptionValidation", "Please enter description.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109696", "1", "TRUE", "HotelValidation", "Please select hotel.");
        }
        private static void AddTestData_Admin_TC_109697()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "ShortDescription", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "Shortdescription_CharLimit", "ShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTestShortDescriptionTest");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "Title_CharLimit", "TitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestvTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTestTitleTest");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "PromoDescription_CharLimit", "PromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptionPromotionDescriptiondddddddddddddddddddddddddddddddddddddddddddddddddddddDescriptionPromotionDescriptionPromotionDescription");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "PromoCode_CharLimit", "AutomationPromotionCode12344");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "ButtonText_CharLimit", "Testttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "Shortdescription_CharLimitValidation", "Short description can not more than 1000 characters.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "Title_CharLimit_CharLimitValidation", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "PromoDescription_CharLimitValidation", "Description can not more than 2000 characters.");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "PromoCode_CharLimitValidation", "Test Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109697", "1", "TRUE", "ButtonText_CharLimitValidation", "Test Description");
        }
        private static void AddTestData_Admin_TC_109698()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109698", "1", "TRUE", "Frontend_URL", "https://origami.qaeloyaltyportal.com/");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109698", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109698", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109698", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109698", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109698", "1", "TRUE", "ShortDescription", "Test Description");
        }
        private static void AddTestData_Admin_TC_109699()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109699", "1", "TRUE", "Title", "Test Offers");
        }
        private static void AddTestData_Admin_TC_109700()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109700", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109700", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109700", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109700", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddYears(2).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109700", "1", "TRUE", "ShortDescription", "Test Description");
        }
        private static void AddTestData_Admin_TC_109701()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109701", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109701", "1", "TRUE", "Title", "Auto_Offer_");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109701", "1", "TRUE", "VisibilityStartDate", DateTime.Now.ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109701", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109701", "1", "TRUE", "ShortDescription", "Test Short Description");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_109659", "TC_109701", "1", "TRUE", "CancelButton_Validation", "No member data available, please update search.");
        }
        private static void AddTestData_Admin_TC_109666()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_109666", "5", "TRUE", "PaginationValue", "5");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_109666", "10", "TRUE", "PaginationValue", "10");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_109666", "15", "TRUE", "PaginationValue", "15");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_268973", "TC_109666", "20", "TRUE", "PaginationValue", "20");
        }
        private static void AddTestData_Admin_TC_109667()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109667", "1", "TRUE", "ImagePath", @"\Admin_Offer_DummyImage\TC_109687_DummyImage.JPG");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109667", "1", "TRUE", "Title", "Auto_Offer");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109667", "1", "TRUE", "VisibilityStartDate", DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109667", "1", "TRUE", "VisibilityEndDate", DateTime.Now.AddDays(2).ToString("MM/dd/yyyy"));
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_AutoIT", "TC_109667", "1", "TRUE", "ShortDescription", "Test Description");
        }
        #endregion[TP_109659]

        #region [TP_109729]
        private static void AddTestData_FrontEnd_TC_109737()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_267813", "TC_109737", "1", "TRUE", "Title", "Auto_Offer1392206784");
        }
        private static void AddTestData_FrontEnd_TC_109738()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_267813", "TC_109738", "1", "TRUE", "Title", "Auto_Offer1392206784");
        }
        private static void AddTestData_FrontEnd_TC_109739()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_267813", "TC_109739", "1", "TRUE", "Title", "Auto_Offer1392206784");
        }
        #endregion [TP_109729]

        #region TP_189000
        private static void AddTestData_Admin_PostDeployment_TC_189003()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_189000", "TC_189003", "1", "TRUE", "Status1", "Deactivated");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_189000", "TC_189003", "1", "TRUE", "UpdateToStatus", "Inactive");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_189000", "TC_189003", "1", "TRUE", "UpdateToStatus1", "Active");
        }
        private static void AddTestData_Admin_PostDeployment_TC_189002()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_189000", "TC_189002", "1", "TRUE", " upgradeemail", "Send Member Level-up email to the member?.");

        }


        #endregion TP_189000

        #region   TP_225570
        private static void AddTestData_FrontEnd_TC_254266()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_225570", "TC_254266", "1", "TRUE", "EmailValidation", "Wrong email format");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_225570", "TC_254266", "1", "TRUE", "PasswordValidation", "Please enter your password");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_225570", "TC_254266", "1", "TRUE", "UserName", "Testuser001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_225570", "TC_254266", "1", "TRUE", "Password", "Cendyn123$");

        }

        private static void AddTestData_FrontEnd_TC_254265()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "1", "TRUE", "CaptchaValidationMessage", "The captcha field is required");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "1", "TRUE", "Subject", "Missing Stays/Points");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "1", "TRUE", "ValidationMessage", "This field cannot be blank");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "2", "TRUE", "Subject", "Points Redemption Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "3", "TRUE", "Subject", "Reservations Inquiry");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "4", "TRUE", "Subject", "Feedback on Club Rewards");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "5", "TRUE", "Subject", "Feedback on Property");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_121741", "TC_254265", "6", "TRUE", "Subject", "Other");
        }
        #endregion TP_225570
        #endregion
    }
}

