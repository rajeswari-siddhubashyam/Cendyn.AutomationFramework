namespace TestData
{
    public class eMenus
    {

        #region[Add Test Data]
        public static void AddeMenusData(string clientName)
        {
            AddTestData_ClientConfig(clientName);
            AddTestData_FrontEnd(clientName);
            AddTestData_PropertyAdmin();
            AddTestData_CendynAdmin(clientName);
            AddTestData_ProductionDefects();
            AddTestData_eMenusLITE(clientName);
        }
        private static void AddTestData_ClientConfig(string clientName)
        {
            TestDataHelper.AddTestData_ClientConfig("HotelOrigami", "https://qa.cendynaccess.com/", "qacendyn@cendyn17.com", "https://1445-qa.menusaccess.com/", "", "", "");

            TestDataHelper.AddTestData_ClientConfig("eMenus", "https://qa.cendynaccess.com/", "qacendynautomation@cendyn17.com", "https://1445-qa.menusaccess.com/", "", "", "");

            TestDataHelper.AddTestData_ClientConfig("CendynAdmin", "https://qacendynadmin.menusaccess.com/", "qacendynautomation@cendyn17.com", "https://1445-qa.menusaccess.com/", "", "", "");
        }
        private static void AddTestData_FrontEnd(string clientName)
        {
            AddTestData_FrontEnd_TC_231915();
            AddTestData_FrontEnd_TC_231918();
            AddTestData_FrontEnd_TC_231942();
            AddTestData_FrontEnd_TC_231919();
            AddTestData_FrontEnd_TC_231943();
            AddTestData_FrontEnd_TC_231944();
            AddTestData_FrontEnd_TC_231928();
            AddTestData_FrontEnd_TC_231929();
            AddTestData_FrontEnd_TC_233084();
            AddTestData_FrontEnd_TC_232085();
            AddTestData_FrontEnd_TC_232083();
            AddTestData_FrontEnd_TC_231935();
            AddTestData_FrontEnd_TC_231936();
            AddTestData_FrontEnd_TC_231937();
            AddTestData_FrontEnd_TC_231938();
        }
        private static void AddTestData_PropertyAdmin()
        {
            AddTestData_PropertyAdmin_TC_232900();
            AddTestData_PropertyAdmin_TC_232899();
            AddTestData_PropertyAdmin_TC_232888();
            AddTestData_PropertyAdmin_TC_232889();
            AddTestData_PropertyAdmin_TC_232890();
            AddTestData_PropertyAdmin_TC_232891();
            AddTestData_PropertyAdmin_TC_232897();
            AddTestData_PropertyAdmin_TC_232898();
            AddTestData_PropertyAdmin_TC_232911();
            AddTestData_PropertyAdmin_TC_232892();
            AddTestData_PropertyAdmin_TC_232893();
            AddTestData_PropertyAdmin_TC_232894();
            AddTestData_PropertyAdmin_TC_232895();
            AddTestData_PropertyAdmin_TC_232913();
        }

        private static void AddTestData_CendynAdmin(string clientName)
        {
            AddTestData_CendynAdmin_TC_232154();
            AddTestData_CendynAdmin_TC_232156();
            AddTestData_CendynAdmin_TC_232159();
            AddTestData_CendynAdmin_TC_232160();
            AddTestData_CendynAdmin_TC_232161();
            AddTestData_CendynAdmin_TC_232157();
            AddTestData_CendynAdmin_TC_232158();
        }
        private static void AddTestData_ProductionDefects()
        {
            AddTestData_ProductionDefects_D_233380();
            AddTestData_ProductionDefects_D_234734();
            AddTestData_ProductionDefects_D_248778();
            AddTestData_ProductionDefects_D_250928();
            AddTestData_ProductionDefects_D_261817();
            AddTestData_ProductionDefects_D_260067();
        }

        private static void AddTestData_eMenusLITE(string clientName)
        {
            AddTestData_eMenusLITE_TC_231048();
            AddTestData_eMenusLITE_TC_232423();
            AddTestData_eMenusLITE_TC_231050();
        }

        private static void AddTestData_eMenuPostDeployment()
        {
            AddTestData_eMenuPostDeployment_TC_278050();


        }


        #endregion[Add Test Data]
        #region[Test Case Data]
        private static void AddTestData_FrontEnd_TC_231915()
        {
            //Valid Test Data
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "FirstName", "Auto_First");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "LastName", "Auto_Last");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "Phone", "(541) 754-3010");

            //Validation message
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "0", "TRUE", "SignUpValidationMessage", "First Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "SignUpValidationMessage", "Last Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "2", "TRUE", "SignUpValidationMessage", "Phone is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "3", "TRUE", "SignUpValidationMessage", "Email is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "4", "TRUE", "SignUpValidationMessage", "Password is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "5", "TRUE", "SignUpValidationMessage", "Confirm Password is a required field");

            //Invalid Email
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "0", "TRUE", "InvalidEmail", "#@%^%#$@#$@#.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "InvalidEmail", "@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "2", "TRUE", "InvalidEmail", "user Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "3", "TRUE", "InvalidEmail", "TestUser.Cendyn17.com ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "4", "TRUE", "InvalidEmail", "TestUser@Cendyn17@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "InvalidEmail_Validation", "The Email field is not a valid e-mail address.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231915", "1", "TRUE", "ExistingEmail_Validation", " is already taken");


        }

        private static void AddTestData_FrontEnd_TC_231918()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231918", "1", "TRUE", "Email_Validation", "Please enter a valid email address.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231918", "1", "TRUE", "Password_Validation", "Password is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231918", "1", "TRUE", "Invalid_Credential_Validation", "Invalid email or password");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231918", "1", "TRUE", "Invalid_Username", "QATest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231918", "1", "TRUE", "Invalid_Password", "Cendyn1");
        }

        private static void AddTestData_FrontEnd_TC_231942()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231942", "1", "TRUE", "My_Order", "My Orders");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231942", "1", "TRUE", "Manage_My_Account", "Manage My Account");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231942", "1", "TRUE", "Sign_In", "Sign In");
        }

        private static void AddTestData_FrontEnd_TC_231919()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231919", "1", "TRUE", "ForgetPassword_InValid_Email", "atest");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231919", "1", "TRUE", "Required_Field_Validation", "Email is required.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231919", "1", "TRUE", "InValid_Email_Validation", "Please enter a valid email address.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231919", "1", "TRUE", "NotRegister_Email_Validation", "Email was not found. Please insert a valid email.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231919", "1", "TRUE", "Email_Send_Validation", "An email has been sent to your email address.Follow the directions in the email to reset your password.");
        }

        private static void AddTestData_FrontEnd_TC_231943()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "FirstName", "Test_Updated_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "LastName", "Automation_Updated_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Address", "980 N_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Address2", "Federal Hwy_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Country", "Albania");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "State", "Florida");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "City", "Miami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "PostalCode", "123456");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Phone", "(561) 123 - 4567");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Company", "dp_Updated_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "UpdationSuccess_Validation", "Profile has been successfully updated.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "FirstName_Validation", "First Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "LastName_Validation", "Last Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Phone_Validation", "Phone is a required field");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "EventName", "Test Event_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "OrderConfirmation", "Order was successfully created.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "FunctionName", "Test Function_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "NoOfGuest", "3");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "FunctionRoom", "Main Hall");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "FunctionType", "Amenity");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "SetupStyle", "Boardroom");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "MenuName", "Continental Breakfast");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Contact", "Cendyn admin - Delaplex");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Save_Confirmation", "Your order has been saved.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231943", "1", "TRUE", "Send_Confirmation", "Your Order Has Been Submitted");

        }
        private static void AddTestData_FrontEnd_TC_231944()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231944", "1", "TRUE", "Update_Password", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231944", "1", "TRUE", "Update_Confirm_Password", "Cendyn1234$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231944", "1", "TRUE", "Update_Validation", "Profile has been successfully updated.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231944", "1", "TRUE", "Incorrect_Password_Validation", "Invalid email or password");
        }
        private static void AddTestData_FrontEnd_TC_231928()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "EventName_Validation", "Event Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "FunctionName_Validation", "Function Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "NoOfGuests_Validation", "Number of Guests is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Function_Name", "TestAutomation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "NoOf_Guests", "2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Function_Room", "Reserved");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Function_Type", "Break");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "SetUp_Style", "BANQT RNDS 10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Menu_Name", "Breakfast Buffet");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Contact", "Cendyn admin - Delaplex");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Payment_Method", "Credit Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "Status", "Pending");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231928", "1", "TRUE", "PropertyLink", "https://qaadmin.menusaccess.com/?sid=1445");
        }
        private static void AddTestData_FrontEnd_TC_231929()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "EventName_Validation", "Event Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "FunctionName_Validation", "Function Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "NoOfGuests_Validation", "Number of Guests is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Function_Name", "TestAutomation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "NoOf_Guests", "2");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Function_Room", "Reserved");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Function_Type", "Break");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "SetUp_Style", "BANQT RNDS 10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Menu_Name", "Breakfast Buffet");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Contact", "Cendyn admin - Delaplex");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Payment_Method", "Credit Card");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "Status", "Sent");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231929", "1", "TRUE", "PropertyLink", "https://qaadmin.menusaccess.com/?sid=1445");

        }
        private static void AddTestData_FrontEnd_TC_233084()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_233084", "1", "TRUE", "GlutenFreeMenu_Name", "Gluten Free");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_233084", "1", "TRUE", "EggMenu_Name", "Fruitarian");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_233084", "1", "TRUE", "MostPopularMenu_Name", "Most Popular");
        }
        private static void AddTestData_FrontEnd_TC_232085()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "EventName_Validation", "Event Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "FunctionName_Validation", "Function Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "NoOfGuests_Validation", "Number of Guests is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "NoOf_Guests", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "Function_Room", "Reserved");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "Function_Type", "Break");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "Menu_Name", "Breakfast Buffet");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "SetUp_Style", "BANQT RNDS 10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "Function_Comments", "Test Function Comments");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "NoOf_Guests_Update", "20");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "Function_Room_Update", "Decorative Hall");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "Function_Type_Update", "Dance");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232085", "1", "TRUE", "SetUp_Style_Update", "CONFERENCE");
        }
        private static void AddTestData_FrontEnd_TC_232083()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "EventName_Validation", "Event Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "FunctionName_Validation", "Function Name is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "NoOfGuests_Validation", "Number of Guests is a required field");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "NoOf_Guests", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "Function_Room", "Reserved");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "Function_Type", "Break");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "Menu_Name", "Breakfast Buffet");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "SetUp_Style", "BANQT RNDS 10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "Function_Comments", "Test Function Comments");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "Menu_Quantity", "20");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_232083", "1", "TRUE", "Menu_Special_Request", "Extra Cheese");
            
        }
        private static void AddTestData_FrontEnd_TC_231935()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "PropertyLink", "https://qaadmin.menusaccess.com/?sid=1445");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "MenuDescription", "Menu Description Test Text");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "Price", "20");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "PriceDescription", "Per 20 Guests");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "DynamicPrice", "100");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231935", "1", "TRUE", "DynamicPriceDescription", "Per 100 Guests");

        }
        private static void AddTestData_FrontEnd_TC_231936()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "PropertyLink", "https://qaadmin.menusaccess.com/?sid=1445");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "MenuDescription", "Menu Description Test Text");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "Price", "20");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "PriceDescription", "Per 20 Guests");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "DynamicPrice", "100");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231936", "1", "TRUE", "DynamicPriceDescription", "Per 100 Guests");

        }
        private static void AddTestData_FrontEnd_TC_231937()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "MenuDescription", "Menu Description Test Text");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "Price", "20");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "PriceDescription", "Per 20 Guests");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "DynamicPrice", "50");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231937", "1", "TRUE", "DynamicPriceDescription", "Per 100 Guests");

        }
        private static void AddTestData_FrontEnd_TC_231938()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "MenuDescription", "Menu Description Test Text");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "Price", "20");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "PriceDescription", "Per 20 Guests");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "DynamicPrice", "50");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_231896", "TC_231938", "1", "TRUE", "DynamicPriceDescription", "Per 100 Guests");

        }
        private static void AddTestData_PropertyAdmin_TC_232900()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "ChoiceName", "Egg Omlet");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "ChoiceDesciption", "Egg Masala Omlet");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "Option1Name", "With Cheese");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "Option1Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "Option2Name", "With Oregano");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "Option2Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "MenuName", "Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232900", "1", "TRUE", "SubMenuName", "Continental Breakfast");



        }
        private static void AddTestData_PropertyAdmin_TC_232899()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Title", "Automation Title");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Add_On1_Name", "First Add On");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Add_On1_Description", "First Add on Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Add_On2_Name", "Second Add On");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Add_On2_Description", "Second Add on Description");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232899", "1", "TRUE", "Add_On2_Price", "20");
            
        }
        private static void AddTestData_CendynAdmin_TC_232154()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "Email_Validation", "The email field is required");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "invalid_Username", "Test");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "invalid_Username_validation", "The Enter Your Email field is not a valid e-mail address.");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "username", "qacendyn@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "Notregistor_Username", "Testuser@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "password_Validation", "The password field is required");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "invalid_password", "Cendyn1");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "invalid_password_Validation", "Invalid login attempt");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232154", "1", "TRUE", "password", "Cendyn123$");

        }
        private static void AddTestData_CendynAdmin_TC_232156()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232156", "1", "TRUE", "Username", "qacendyn@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231898", "TC_232156", "1", "TRUE", "password", "Cendyn123$");

        }
        private static void AddTestData_CendynAdmin_TC_232159()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232159", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232159", "1", "TRUE", "categoryName", "FirstLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232159", "1", "TRUE", "categoryValidation", "Category Name should not be blank.");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232159", "1", "TRUE", "sub_categoryName", "SecondLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232159", "1", "TRUE", "sub_sub_categoryName", "ThirdLevel_");
        }
        private static void AddTestData_PropertyAdmin_TC_232888()
        {
            //Valid Test Data
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
           
            //Validation message
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "EmailValidationMessage", "The email field is required");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "PasswordValidationMessage", "The password field is required");

            //Invalid Email
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "Invalid_Email_Validation", "The Enter Your Email field is not a valid e-mail address.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "Invalid_Credential_Validation", "Invalid login attempt");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "Invalid_Email", "QATest");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232888", "1", "TRUE", "Invalid_Password", "Cendyn1");
        }
        private static void AddTestData_PropertyAdmin_TC_232889()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "0", "TRUE", "CendynAdmin_UtilityNav", "My Profile");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "1", "TRUE", "CendynAdmin_UtilityNav", "Manage Users");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "2", "TRUE", "CendynAdmin_UtilityNav", "Manage Newsletter");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "3", "TRUE", "CendynAdmin_UtilityNav", "Hotel Central");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "4", "TRUE", "CendynAdmin_UtilityNav", "Cendyn Admin");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "5", "TRUE", "CendynAdmin_UtilityNav", "Help");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232889", "6", "TRUE", "CendynAdmin_UtilityNav", "Log Out");

        }
        private static void AddTestData_PropertyAdmin_TC_232890()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "Social_Media_Type", "Yelp");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "Social_Media_Url", "https://www.yelp.com/");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "Social_Media_Url_Edit", "https://www.yelp.com/login");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "Type_Vaidation", "Social media type is required.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "Url_Validation", "Please enter URL.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "Invalid_Url", "Test");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232890", "1", "TRUE", "InValid_Url_Validation", "Please enter valid URL that starts with https.");

        }
        private static void AddTestData_PropertyAdmin_TC_232891()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232891", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232891", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232891", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232891", "1", "TRUE", "TagName", "Test Tag");

        }
        private static void AddTestData_PropertyAdmin_TC_232897()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232897", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232897", "1", "TRUE", "MenuName", "Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232897", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232897", "1", "TRUE", "Price", "0");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232897", "1", "TRUE", "PriceDescription", "-- Please Select --");

        }
        private static void AddTestData_PropertyAdmin_TC_232898()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232898", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232898", "1", "TRUE", "MenuName", "Breakfast_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232898", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232898", "1", "TRUE", "Price", "10");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232898", "1", "TRUE", "PriceDescription", "Per Adult");

        }

        private static void AddTestData_PropertyAdmin_TC_232911()
        {
            //Valid Test Data
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "PropertyAdmin_Username", "QaCendyn@Cendyn17.com");

            //Validation message
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "FindReplace_SuccessMessage", "Content was successfully replaced in all pages.");
            
            //Menu Item
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "MenuNameAddOns", "NAME&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "MenuDescriptionAddOns", "DESC&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Title", "TITLE&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Add_On1_Name", "FIRST&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Add_On1_Description", "FIRSTDESC&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Add_On1_Price", "25");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Add_On2_Name", "SECOND&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Add_On2_Description", "SECONDDESC&_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232911", "1", "TRUE", "Add_On2_Price", "20");

        }
        private static void AddTestData_CendynAdmin_TC_232160()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232160", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232160", "1", "TRUE", "categoryName", "FirstLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232160", "1", "TRUE", "categoryValidation", "Category Name should not be blank.");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232160", "1", "TRUE", "sub_categoryName", "SecondLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232160", "1", "TRUE", "sub_sub_categoryName", "ThirdLevel_");
        }
        private static void AddTestData_CendynAdmin_TC_232161()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232161", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232161", "1", "TRUE", "categoryName", "FirstLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232161", "1", "TRUE", "categoryValidation", "Category Name should not be blank.");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232161", "1", "TRUE", "sub_categoryName", "SecondLevel_");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232161", "1", "TRUE", "sub_sub_categoryName", "ThirdLevel_");
        }
        private static void AddTestData_PropertyAdmin_TC_232892()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232892", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232892", "1", "TRUE", "Dynamic_Pricing_Name", "Dynamic Pricing Name");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232892", "1", "TRUE", "Start_Date", "Start Date");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232892", "1", "TRUE", "End_Date", "End Date");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232892", "1", "TRUE", "Actions", "Actions");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232892", "1", "TRUE", "Add_New", "Add New");

        }
        private static void AddTestData_PropertyAdmin_TC_232893()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232893", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232893", "1", "TRUE", "Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232893", "1", "TRUE", "PriceDescription", "Per 20 Guests");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232893", "1", "TRUE", "DynamicPrice", "100");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232893", "1", "TRUE", "DynamicPriceDescription", "Per 100 Guests");

        }
        private static void AddTestData_PropertyAdmin_TC_232894()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232894", "1", "TRUE", "PropertyName", "Hotel Origami");

        }
        private static void AddTestData_PropertyAdmin_TC_232895()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232895", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232895", "1", "TRUE", "Price", "20");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232895", "1", "TRUE", "PriceDescription", "Per 20 Guests");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232895", "1", "TRUE", "DynamicPrice", "100");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232895", "1", "TRUE", "DynamicPriceDescription", "Per 100 Guests");

        }
        private static void AddTestData_PropertyAdmin_TC_232913()
        {
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "MenuName", "TestShareMenu_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "Search_ClientEmail", "mnagrani@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "Search_ClientName", "Mayur");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "First_Name", "John_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "Last_Name", "Steve_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "Company_Name", "dpPL_");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "First_MenuName", "Breakfast");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "Second_MenuName", "Lunch");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_231897", "TC_232913", "1", "TRUE", "Third_MenuName", "Reception");

        }
        private static void AddTestData_CendynAdmin_TC_232157()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232157", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232157", "1", "TRUE", "ShareMenu", "Share");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232157", "1", "TRUE", "DynamicPricing", "Dynamic Pricing");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232157", "1", "TRUE", "PropertyUrl", "https://qaadmin.menusaccess.com/");
        }
        private static void AddTestData_CendynAdmin_TC_232158()
        {
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232158", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232158", "1", "TRUE", "MenuImage_Text", "Menu Image");
            TestDataHelper.AddRecord("ALL", "CendynAdmin", "TestCase", "TP_231897", "TC_232158", "1", "TRUE", "PropertyUrl", "https://qaadmin.menusaccess.com/");
        }
        private static void AddTestData_ProductionDefects_D_233380()
        {
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_233380", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_233380", "1", "TRUE", "MenuName", "Breakfast");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_233380", "1", "TRUE", "Error_Message", "Please input share eMenu Name.");
        }

        private static void AddTestData_ProductionDefects_D_234734()
        {
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "ChoiceName", "Egg Omlet");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "ChoiceName2", "Wraps");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "Option1Name", "With Cheese");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "Option2Name", "With Oregano");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "Option3Name", "Chicken");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "MenuName", "Breakfast");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_234734", "1", "TRUE", "SubMenuName", "Continental Breakfast");

        }
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
        private static void AddTestData_eMenusLITE_TC_231050() { 


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
        private static void AddTestData_eMenusLITE_TC_231212()
        {


            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231212", "1", "TRUE", "PropertyCorporate", "Cendyn - Hotel Origami Corporate - USA");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231212", "1", "TRUE", "PropertyLITE", "Cendyn - Hotel Origami Chicago");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231212", "1", "TRUE", "Settings_Inherited_Message", "Settings Unavailable");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231212", "1", "TRUE", "Supplier_Settings_Message", "Supplier Settings are inherited from Master/Corporate property.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231212", "1", "TRUE", "Basic_Settings_Message", "Supplier Settings are inherited from Master/Corporate property.");
            TestDataHelper.AddRecord("ALL", "PropertyAdmin", "TestCase", "TP_250896", "TC_231212", "1", "TRUE", "Advanced_Settings_Message", "Supplier Settings are inherited from Master/Corporate property.");
        }

        private static void AddTestData_ProductionDefects_D_248778()
        {
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_248778", "1", "TRUE", "FrontendUrl", "https://1461-qa.menusaccess.com/");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_248778", "1", "TRUE", "SignInText", "Sign in");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_248778", "1", "TRUE", "UserNameText", "Username");
        }

        private static void AddTestData_ProductionDefects_D_250928()
        {
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_250928", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_250928", "1", "TRUE", "SupplierName", "Hotel Origami - Meetings");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_250928", "1", "TRUE", "Text", "Gluten Free");
        }

        private static void AddTestData_ProductionDefects_D_261817()
        {
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_261817", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_261817", "1", "TRUE", "MenuName", "Menu name");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_261817", "1", "TRUE", "MenuDescription", "Menu description");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_261817", "1", "TRUE", "Title", "Add Ons");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_261817", "1", "TRUE", "Add_On1_Name", "Add on1");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_261817", "1", "TRUE", "Add_On2_Name", "Add on2");
        }

        private static void AddTestData_ProductionDefects_D_260067()
        {
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "PropertyName", "Hotel Origami");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "MenuName", "Morning Breakfast_");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "MenuDescription", "Good Morning Breakfast");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "ChoiceName", "Egg Omlet");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "Option1Name", "Egg_Option1");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "Option2Name", "Egg_Option2");
            TestDataHelper.AddRecord("ALL", "ProductionDefect", "Defect", "Production_Defects", "D_260067", "1", "TRUE", "ValidationMessage", "A choice must have at least 2 options");
        }
        private static void AddTestData_eMenuPostDeployment_TC_278050()
        {
            TestDataHelper.AddRecord("ALL", "PostDeployment", "TestCase", "TP_277741", "TC_278050", "1", "TRUE", "PropertyName", "Hotel Origami");
            
        }

        #endregion[Test Case Data]
    }
}