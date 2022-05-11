namespace TestData
{
    public class eMenusLite
    {

        #region[Add Test Data]
        public static void AddeMenusData(string clientName)
        {
            AddTestData_ClientConfig(clientName);
            AddTestData();
        }
        private static void AddTestData_ClientConfig(string clientName)
        {
            TestDataHelper.AddTestData_ClientConfig("HotelOrigami", "https://qa.cendynaccess.com/", "qacendyn@cendyn17.com", "https://1445-qa.menusaccess.com/", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("eMenusLite", "https://qa.cendynaccess.com/", "qacendyn@cendyn17.com", "https://1445-qa.menusaccess.com/", "", "", "");
        }

        private static void AddTestData()
        {

            AddTestData_eMenusLITE_TC_231048();
            AddTestData_eMenusLITE_TC_232423();
            AddTestData_eMenusLITE_TC_231050();
            AddTestData_eMenusLITE_TC_231214();
            AddTestData_eMenusLITE_TC_231215();
            AddTestData_eMenusLITE_TC_231216();
            AddTestData_eMenusLITE_TC_261318();
            AddTestData_eMenusLITE_TC_231219();
            AddTestData_eMenusLITE_TC_231473();
            AddTestData_eMenusLITE_TC_233030();
            AddTestData_eMenusLITE_TC_256953();
            AddTestData_eMenusLITE_TC_260414();
            AddTestData_eMenusLITE_TC_260420();
            AddTestData_eMenusLITE_TC_260415();
            AddTestData_eMenusLITE_TC_260417();
            AddTestData_eMenusLITE_TC_260418();
            AddTestData_eMenusLITE_TC_260419();
            AddTestData_eMenusLITE_TC_261125();
            AddTestData_eMenusLITE_TC_261127();
            AddTestData_eMenusLITE_TC_261130();
            AddTestData_eMenusLITE_TC_261131();
            AddTestData_eMenusLITE_TC_260422();
            AddTestData_eMenusLITE_TC_261133();
            AddTestData_eMenusLITE_TC_260421();
            AddTestData_eMenusLITE_TC_261132();
            AddTestCase_eMenusLITE_TC_232406();
        }
        #endregion[Add Test Data]
        #region[Test Case Data]

        private static void AddTestData_eMenusLITE_TC_231048()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "PropertyLITE", "Cendyn - Hotel Origami Chicago");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "CategoryName", "TestCategory_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "CategoryDesc", "CategoryDescriptionTest_");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "MenuName", "Snack w/ Choices_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "MenuDescription", "Good Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "ChoiceName", "Egg Omlet_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "ChoiceDesciption", "Egg Masala Omlet_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Option1Name", "With Cheese_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Option1Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Option2Name", "With Oregano_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Option2Price", "10");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "MenuNameAddOns", "Snack w/ Adds_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "MenuDescriptionAddOns", "Good Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Title", "Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Add_On1_Name", "First_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Add_On1_Description", "First Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Add_On2_Name", "Second_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Add_On2_Description", "Second Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "Add_On2_Price", "20");


            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231048", "1", "TRUE", "updateText", "_updated");


        }
        private static void AddTestData_eMenusLITE_TC_232423()
        {

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "PropertyLITE", "Cendyn - Hotel Origami Chicago");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "CategoryName", "TestCategory_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "CategoryDesc", "CategoryDescriptionTest_");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "MenuName", "Snack w/ Choices_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "MenuDescription", "Good Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "ChoiceName", "Egg Omlet_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "ChoiceDesciption", "Egg Masala Omlet_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Option1Name", "With Cheese_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Option1Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Option2Name", "With Oregano_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Option2Price", "10");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "MenuNameAddOns", "Snack w/ Adds_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "MenuDescriptionAddOns", "Good Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Title", "Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Add_On1_Name", "First_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Add_On1_Description", "First Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Add_On2_Name", "Second_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Add_On2_Description", "Second Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "Add_On2_Price", "20");


            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_232423", "1", "TRUE", "updateText", "_updated");
        }
        private static void AddTestData_eMenusLITE_TC_231050()
        {


            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "PropertyLITE", "Cendyn - Hotel Origami Chicago");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "CategoryName", "TestCategory_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "CategoryDesc", "CategoryDescriptionTest_");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "MenuName", "Snack w/ Choices_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "MenuDescription", "Good Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "ChoiceName", "Egg Omlet_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "ChoiceDesciption", "Egg Masala Omlet_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Option1Name", "With Cheese_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Option1Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Option2Name", "With Oregano_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Option2Price", "10");

            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "MenuNameAddOns", "Snack w/ Adds_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "MenuDescriptionAddOns", "Good Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Title", "Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Add_On1_Name", "First_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Add_On1_Description", "First Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Add_On2_Name", "Second_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Add_On2_Description", "Second Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "Add_On2_Price", "20");


            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231050", "1", "TRUE", "updateText", "_updated");

        }
        private static void AddTestData_eMenusLITE_TC_231214()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231214", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231214", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231214", "1", "TRUE", "SettingsUnavailable_Message", "Settings Unavailable");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231214", "1", "TRUE", "BasicSettings_inheritedMessage", "Settings are inherited from Master/Corporate property.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231214", "1", "TRUE", "ShareMenu", "Share");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231214", "1", "TRUE", "PropertyUrl", "https://qaadminlite.menusaccess.com/");
        }
        private static void AddTestData_eMenusLITE_TC_231215()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231215", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231215", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231215", "1", "TRUE", "SettingsUnavailable_Message", "Settings Unavailable");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231215", "1", "TRUE", "AdvancedSettings_inherited_Message", "Settings are inherited from Master/Corporate property.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231215", "1", "TRUE", "MenuImage_Text", "Menu Image");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231215", "1", "TRUE", "PropertyUrl", "https://qaadminlite.menusaccess.com/");
        }
        private static void AddTestData_eMenusLITE_TC_231216()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231216", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231216", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231216", "1", "TRUE", "SettingsUnavailable_Message", "Settings Unavailable");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231216", "1", "TRUE", "SupplierSettings_inheritedMessage", "Supplier Settings are inherited from Master/Corporate property.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231216", "1", "TRUE", "ImagePath", @"\Automation_Documents\TC_231216_Logo.png");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231216", "1", "TRUE", "PropertyUrl", "https://qaadminlite.menusaccess.com/");
        }
        private static void AddTestData_eMenusLITE_TC_261318()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261318", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261318", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261318", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261318", "1", "TRUE", "addedCategory", "TestCategory_");


        }
        private static void AddTestData_eMenusLITE_TC_231219()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231219", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231219", "1", "TRUE", "addedCategory", "TestCategory_");
        }
        private static void AddTestData_eMenusLITE_TC_231473()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "addedCategory", "TestCategory_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "PriceDescription", "Per Adult");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231473", "1", "TRUE", "Disclaimer", "DisclaimerTest_");

        }
        private static void AddTestData_eMenusLITE_TC_233030()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "MenuDescription", "Catch a Break!");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "PriceDescription", "Per Adult");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "UpdatedPrice", "12");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "UpdatedPriceDescription", "Each");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "UpdatedPrice1", "15");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "UpdatedPriceDescription1", "Additional");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "UpdatedPriceLite", "8");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_233030", "1", "TRUE", "UpdatedPriceDescriptionLite", "Per Bag");

        }
        private static void AddTestData_eMenusLITE_TC_256953()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami - Corporate");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "Category", "TestCategory_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "Disclaimer", "This is a Corporate Disclaimer_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "UpdatedDisclaimer", "Corporate Disclaimer first update_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "UpdatedDisclaimer1", "Corporate Disclaimer second update_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_256953", "1", "TRUE", "UpdatedDisclaimerLite", "This Disclaimer is for LITE property_");

        }
        private static void AddTestData_eMenusLITE_TC_260414()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260414", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260414", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260414", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260414", "1", "TRUE", "TagName", "Test Tag");
        }
        private static void AddTestData_eMenusLITE_TC_260420()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");

            //Validation message
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "FindReplace_SuccessMessage", "Content was successfully replaced in all pages.");

            //Menu Item
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "MenuNameAddOns", "NAME&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "MenuDescriptionAddOns", "DESC&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Title", "TITLE&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Add_On1_Name", "FIRST&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Add_On1_Description", "FIRSTDESC&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Add_On2_Name", "SECOND&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Add_On2_Description", "SECONDDESC&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260420", "1", "TRUE", "Add_On2_Price", "20");
        }
        private static void AddTestData_eMenusLITE_TC_260415()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260415", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260415", "1", "TRUE", "MenuName", "Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260415", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260415", "1", "TRUE", "Price", "0");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260415", "1", "TRUE", "PriceDescription", "-- Please Select --");
        }
        private static void AddTestData_eMenusLITE_TC_260417()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260417", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260417", "1", "TRUE", "MenuName", "Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260417", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260417", "1", "TRUE", "Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260417", "1", "TRUE", "PriceDescription", "Per Adult");


        }
        private static void AddTestData_eMenusLITE_TC_260419()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "ChoiceName", "Egg Omlet");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "ChoiceDesciption", "Egg Masala Omlet");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "Option1Name", "With Cheese");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "Option1Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "Option2Name", "With Oregano");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "Option2Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260419", "1", "TRUE", "Category", "Breaks");

        }
        private static void AddTestData_eMenusLITE_TC_260418()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Title", "Automation Title");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Add_On1_Name", "First Add On");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Add_On1_Description", "First Add on Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Add_On2_Name", "Second Add On");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Add_On2_Description", "Second Add on Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Add_On2_Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260418", "1", "TRUE", "Category", "Breaks");

        }
        private static void AddTestData_eMenusLITE_TC_261125()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "Category", "Special Offers");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "MenuName", "Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "Price", "0");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261125", "1", "TRUE", "PriceDescription", "-- Please Select --");

        }
        private static void AddTestData_eMenusLITE_TC_261127()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261127", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261127", "1", "TRUE", "Category", "Special Offers");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261127", "1", "TRUE", "MenuName", "Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261127", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261127", "1", "TRUE", "Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261127", "1", "TRUE", "PriceDescription", "Per Adult");
        }
        private static void AddTestData_eMenusLITE_TC_261130()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Title", "Automation Title");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Add_On1_Name", "First Add On");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Add_On1_Description", "First Add on Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Add_On2_Name", "Second Add On");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Add_On2_Description", "Second Add on Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Add_On2_Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261130", "1", "TRUE", "Category", "Special Offers");

        }
        private static void AddTestData_eMenusLITE_TC_261131()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "ChoiceName", "Egg Omlet");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "ChoiceDesciption", "Egg Masala Omlet");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "Option1Name", "With Cheese");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "Option1Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "Option2Name", "With Oregano");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "Option2Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261131", "1", "TRUE", "Category", "Special Offers");

        }
        private static void AddTestData_eMenusLITE_TC_260422()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260422", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260422", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260422", "1", "TRUE", "Category", "Lunch");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260422", "1", "TRUE", "GlutenFreeMenu_Name", "Gluten Free_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260422", "1", "TRUE", "MilkAvoidanceMenu_Name", "Milk_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260422", "1", "TRUE", "MostPopularMenu_Name", "Most Popular_");

        }
        private static void AddTestData_eMenusLITE_TC_261133()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261133", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261133", "1", "TRUE", "PropertyLite", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261133", "1", "TRUE", "Category", "Special Offers");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261133", "1", "TRUE", "GlutenFreeMenu_Name", "Gluten Free_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261133", "1", "TRUE", "MilkAvoidanceMenu_Name", "Milk_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261133", "1", "TRUE", "MostPopularMenu_Name", "Most Popular_");

        }
        private static void AddTestData_eMenusLITE_TC_260421()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_260421", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "MenuName", "TestShareMenu_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "Search_ClientEmail", "mnagrani@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "Search_ClientName", "Mayur");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "First_Name", "John_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "Last_Name", "Steve_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "Company_Name", "dpPL_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "First_MenuName", "Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "Second_MenuName", "Lunch");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_260421", "1", "TRUE", "Third_MenuName", "Breaks");

        }
        private static void AddTestData_eMenusLITE_TC_261132()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_261132", "1", "TRUE", "PropertySupplier", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "MenuName", "TestShareMenu_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "Search_ClientEmail", "mnagrani@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "Search_ClientName", "Mayur");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "First_Name", "Paul_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "Last_Name", "Miller_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "Company_Name", "dpPL_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "First_MenuName", "Special Offers");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "Second_MenuName", "Lunch");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_261132", "1", "TRUE", "Third_MenuName", "Breaks");

        }
        private static void AddTestCase_eMenusLITE_TC_232406()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "PropertyName", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "Social_Media_Type", "Yelp");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "Social_Media_Url", "https://www.yelp.com/");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "Social_Media_Url_Edit", "https://www.yelp.com/login");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "Type_Vaidation", "Social media type is required.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "Url_Validation", "Please enter URL.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "Invalid_Url", "Test");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231896", "TC_232406", "1", "TRUE", "InValid_Url_Validation", "Please enter valid URL that starts with https.");
        }
        #endregion[Test Case Data]
    }
}