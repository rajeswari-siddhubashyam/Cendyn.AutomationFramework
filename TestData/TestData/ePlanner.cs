namespace TestData
{
    class ePlanner
    {
        #region[Add Test Data]
        public static void AddeMenusData(string clientName)
        {
            AddTestData_ClientConfig(clientName);
            AddTestData_PropertyAdmin();
            AddTestData_FrontEnd();
            AddTestData_CendynAdmin();
        }
        private static void AddTestData_ClientConfig(string clientName)
        {
            TestDataHelper.AddTestData_ClientConfig("ePlanner", "https://qa.cendynaccess.com/", "qacendynautomation@cendyn17.com", "https://1445-qa.menusaccess.com/", "", "", "");
        }
        private static void AddTestData_PropertyAdmin()
        {
            AddTestData_PropertyAdmin_TC_232780();
            AddTestData_PropertyAdmin_TC_232781();
            AddTestData_PropertyAdmin_TC_232782();
            AddTestData_PropertyAdmin_TC_232783();
            AddTestData_PropertyAdmin_TC_232921();
            AddTestData_PropertyAdmin_TC_232922();
            AddTestData_PropertyAdmin_TC_232784();
            AddTestData_PropertyAdmin_TC_232785();
            AddTestData_PropertyAdmin_TC_232923();
            AddTestData_PropertyAdmin_TC_232925();
            AddTestData_PropertyAdmin_TC_232926();
            AddTestData_PropertyAdmin_TC_233769();


        }
        private static void AddTestData_CendynAdmin()
        {
            AddTestData_CendynAdmin_TC_232790();
            AddTestData_CendynAdmin_TC_232791();
            AddTestData_CendynAdmin_TC_232792();
            AddTestData_CendynAdmin_TC_232793();
            AddTestData_CendynAdmin_TC_232794();
        }
        private static void AddTestData_FrontEnd()
        {
            AddTestData_Frontend_TC_232759();
            AddTestData_Frontend_TC_232761();
            AddTestData_Frontend_TC_232763();
            AddTestData_Frontend_TC_232764();
            AddTestData_Frontend_TC_232795();
            AddTestData_Frontend_TC_232975();

            //AddTestData_Frontend_TC_232764();
            AddTestData_Frontend_TC_232765();
        }
        #endregion[Add Test Data]
        #region[Test Case Data]
        private static void AddTestData_PropertyAdmin_TC_232780()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232780", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232780", "1", "TRUE", "Sub_MenuName", "Banquet Beverage Selection");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232780", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232780", "1", "TRUE", "MenuDescription", "This is Test Menu Description");
            
        }
        private static void AddTestData_PropertyAdmin_TC_232781()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232781", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232781", "1", "TRUE", "Sub_MenuName", "Banquet Curfews");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232781", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232781", "1", "TRUE", "MenuDescription", "This is Test Menu Description");

        }
        private static void AddTestData_PropertyAdmin_TC_232782()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232782", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232782", "1", "TRUE", "Sub_MenuName", "Banquet Curfews");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232782", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232782", "1", "TRUE", "MenuDescription", "This is Test Menu Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232782", "1", "TRUE", "ImagePath", @"\Automation_Documents\TC_232782_Image.jpg");

        }
        private static void AddTestData_PropertyAdmin_TC_232783()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232783", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232783", "1", "TRUE", "Sub_MenuName", "Banquet Curfews");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232783", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232783", "1", "TRUE", "MenuDescription", "This is Test Menu Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232783", "1", "TRUE", "ImagePath", @"\Automation_Documents\TC_232782_Image.jpg");

        }

        private static void AddTestData_PropertyAdmin_TC_232921()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232921", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232921", "1", "TRUE", "Sub_MenuName", "Banquet Equipment");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232921", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232921", "1", "TRUE", "MenuDescription", "This is Test Menu Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232921", "1", "TRUE", "ImagePath", @"\Automation_Documents\TC_232782_Image.jpg");

        }
        private static void AddTestData_PropertyAdmin_TC_232922()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232922", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232922", "1", "TRUE", "Sub_MenuName", "Banquet Equipment");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232922", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232922", "1", "TRUE", "MenuDescription", "This is Test Menu Description");

        }
        private static void AddTestData_Frontend_TC_232759()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232759", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232759", "1", "TRUE", "Sub_MenuName", "Banquet Equipment");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232759", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232759", "1", "TRUE", "MenuDescription", "This is Test Menu Description");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232759", "1", "TRUE", "VerificationText", "result found");

        }

        private static void AddTestData_Frontend_TC_232761()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232761", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232761", "1", "TRUE", "Sub_MenuName", "Banquet Equipment");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232761", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232761", "1", "TRUE", "MenuDescription", "This is Test Menu Description");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232761", "1", "TRUE", "VerificationText", "result found");

        }

        private static void AddTestData_Frontend_TC_232763()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232763", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232763", "1", "TRUE", "VerificationText", "result found");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232763", "1", "TRUE", "UpdateContent", "_Updated home category content_");

        }

        private static void AddTestData_Frontend_TC_232764()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232764", "1", "TRUE", "ValidationMessage", "You have entered invalid characters such as " + @"""&#""" + ", " + @"""<>""" + ". Please re-enter.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232764", "1", "TRUE", "SearchInput1", "Test&#");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232764", "1", "TRUE", "SearchInput2", "Test<>");
        }

        private static void AddTestData_Frontend_TC_232795()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232795", "1", "TRUE", "ValidationMessage", "Your search was too vague. Please be more specific.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232795", "1", "TRUE", "SearchContent1", "abc");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232795", "1", "TRUE", "SearchContent2", "12");
        }

        private static void AddTestData_Frontend_TC_232975()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232975", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232975", "1", "TRUE", "Sub_MenuName", "Banquet Curfews");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232975", "1", "TRUE", "Disclaimer", "This is Desclaimer_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232975", "1", "TRUE", "VerificationText", "0 result found");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232975", "1", "TRUE", "CategoryDecsription", "this is category description_");


        }

      
        private static void AddTestData_PropertyAdmin_TC_232784()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232784", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232784", "1", "TRUE", "Sub_MenuName", "Banquet Menu Selection");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232784", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232784", "1", "TRUE", "MenuDescription", "This is Test Menu Description");

        }
        private static void AddTestData_PropertyAdmin_TC_232785()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232785", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232785", "1", "TRUE", "Sub_MenuName", "Banquet Menu Selection");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232785", "1", "TRUE", "Title", "Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232785", "1", "TRUE", "MenuDescription", "This is Test Menu Description");

        }
        private static void AddTestData_PropertyAdmin_TC_232923()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232923", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232923", "1", "TRUE", "Sub_MenuName", "Banquet Menu Selection");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232923", "1", "TRUE", "Title1", "First Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232923", "1", "TRUE", "MenuDescription1", "This is Test Menu Description for First Item");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232923", "1", "TRUE", "Title2", "Second Item Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232923", "1", "TRUE", "MenuDescription2", "This is Test Menu Description for Second Item");


        }
        private static void AddTestData_PropertyAdmin_TC_232925()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232925", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232925", "1", "TRUE", "Sub_MenuName", "Banquet Menu Selection");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232925", "1", "TRUE", "Category_Description", "This is the Test Category Description");
        }
        private static void AddTestData_PropertyAdmin_TC_232926()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232926", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232926", "1", "TRUE", "Sub_MenuName", "Banquet Menu Selection");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232926", "1", "TRUE", "Title", "Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_232926", "1", "TRUE", "Menu_Description", "This is Test Menu Description_");
        }
        private static void AddTestData_Frontend_TC_232765()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232765", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232765", "1", "TRUE", "CendynUrl", "https://qacendynadmin.eplanneraccess.com/");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232765", "1", "TRUE", "Sub_MenuName", "Bell Services");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232765", "1", "TRUE", "HomeLetter", "Home Letter");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232765", "1", "TRUE", "HomeNoLetter", "Home No Letter");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231899", "TC_232765", "1", "TRUE", "Manager_Name", "John Seaton ");

        }
        private static void AddTestData_PropertyAdmin_TC_233769()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Sub_MenuName", "Box Lunches");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Title", "Find_Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Menu_Description", "This is Test Description_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Maximum_Char", "abcdefghijklmnopqrstuvwxyz");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Special_Char", "*&%^$#@");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Numeric_Char", "123456");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Category_Description", "Category Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Category_Disclaimer", "Category Disclaimer");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Validation_Message", "We could not find what you were looking for.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "replaceTitle", "Replace_Title_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "OverlayTitle", "Find &amp; Replace");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "Replace_Confirmation", "Content was successfully replaced in all pages");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231900", "TC_233769", "1", "TRUE", "max_Char_Validation", "Minium 1 and Maximun 25 characters are allow to find.");
            

        }
        private static void AddTestData_CendynAdmin_TC_232790()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232790", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232790", "1", "TRUE", "CendynUrl", "https://qacendynadmin.eplanneraccess.com/");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232790", "1", "TRUE", "categoryName", "FirstLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232790", "1", "TRUE", "categoryValidation", "Category Name should not be blank.");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232790", "1", "TRUE", "sub_categoryName", "SecondLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232790", "1", "TRUE", "sub_sub_categoryName", "ThirdLevel_");
        }
        private static void AddTestData_CendynAdmin_TC_232791()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232791", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232791", "1", "TRUE", "CendynUrl", "https://qacendynadmin.eplanneraccess.com/");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232791", "1", "TRUE", "categoryName", "FirstLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232791", "1", "TRUE", "categoryValidation", "Category Name should not be blank.");
        }
        private static void AddTestData_CendynAdmin_TC_232792()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232792", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232792", "1", "TRUE", "CendynUrl", "https://qacendynadmin.eplanneraccess.com/");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232792", "1", "TRUE", "Category_Type", "Home Letter");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232792", "1", "TRUE", "Manager_Name", "John Seaton");
        }
        private static void AddTestData_CendynAdmin_TC_232793()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232793", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232793", "1", "TRUE", "CendynUrl", "https://qacendynadmin.eplanneraccess.com/");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232793", "1", "TRUE", "Category_Type", "Home No Letter");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232793", "1", "TRUE", "Manager_Name", "John Seaton ");
        }

        private static void AddTestData_CendynAdmin_TC_232794()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232794", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231901", "TC_232794", "1", "TRUE", "CendynUrl", "https://qacendynadmin.eplanneraccess.com/");
        }
        #endregion[Test Case Data]
    }
}
