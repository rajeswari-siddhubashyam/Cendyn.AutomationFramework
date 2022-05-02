using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using eProposal.Utility;
using OpenQA.Selenium;
using SqlWarehouse;
using InfoMessageLogger;

namespace eProposal.AppModule.UI
{
    internal class EmployeeHome : Helper
    {
        public static void Click_Profile()
        {
            ElementClick(PageObject_EmployeeHome.EmployeeHome_Profile());
        }

        public static void Click_AddEditProfile()
        {
            ElementClick(PageObject_EmployeeHome.EmployeeHome_AddEditProfile());
        }

        public static void Hover_MySettings()
        {
            ElementHover(PageObject_EmployeeHome.EmployeeHome_MySettings());
        }
        public static void Hover_MySettings_Demo()
        {
            ElementClick(PageObject_EmployeeHome.EmployeeHome_MySettings_Demo());
        }
        public static void Click_MySettings_Demo()
        {
            ElementClick(PageObject_EmployeeHome.EmployeeHome_MySettings_Click_Demo());
        }
        public static void Hover_MySettings_New()
        {
            ElementClick(PageObject_EmployeeHome.EmployeeHome_MySettings_New());
        }
        public static void Click_MySettings_New()
        {
            ElementClick(PageObject_EmployeeHome.EmployeeHome_MySettings_Click_New());
        }

        private static void Click_PropertyDropDown_Button()
        {
            ElementClick(PageObject_EmployeeHome.PropertyDropDown_Button());
        }

        public static void Click_WelcomeButton()
        {
            ElementClick(PageObject_EmployeeHome.WelcomeButton());
        }

        public static void Click_ViewAllLink()
        {
            ElementClick(PageObject_EmployeeHome.ViewAllLink());
        }

        public static void Click_Link_UpdateMySettings()
        {
            ElementClick(PageObject_EmployeeHome.Link_UpdateMySettings());
        }

        public static void Click_HelpLink()
        {
            ElementClick(PageObject_EmployeeHome.HelpLink());
        }

        public static void Click_EditProfileLink()
        {
            ElementClick(PageObject_EmployeeHome.EditProfileLink());
        }

        public static void Click_ClientsButton()
        {
            ElementClick(PageObject_EmployeeHome.ClientsButton());
        }

        public static void Click_ReportsButton()
        {
            ElementClick(PageObject_EmployeeHome.ReportsButton());
        }

        private static void SelectFromDropDown_PropertyDropDown_Text(string text)
        {
            ElementSelectFromDropDown(PageObject_EmployeeHome.PropertyDropDown_Text(), text);
        }

        public static void Click_CreateEditButton()
        {
            ElementClick(PageObject_EmployeeHome.CreateEditButton());
        }

        public static void Hover_CreateEditButton()
        {
            ScrollToElement(PageObject_EmployeeHome.CreateEditButton());
            AddDelay(2000);
            ElementHover(PageObject_EmployeeHome.CreateEditButton());
        }

        public static void Click_ActivityTab()
        {
            ElementClick(PageObject_EmployeeHome.ActivityTab());
        }

        public static void Click_CreateEdit_eProposalButton()
        {
            ElementClick(PageObject_EmployeeHome.CreateEdit_eProposalButton());
        }

        public static void Click_CreateEdit_eProposalButton2()
        {
            ElementClick(PageObject_EmployeeHome.CreateEdit_eProposalButton2());
        }

        public static void Click_CreateEdit_eFacetimeButton()
        {
            ElementClick(PageObject_EmployeeHome.CreateEdit_eFacetimeButton());
        }

        public static void Click_CreateEdit_eCardButton()
        {
            ElementClick(PageObject_EmployeeHome.CreateEdit_eCardButton());
        }

        public static string TC_112919Properties(int iteration)
        {
            string hilton1 = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Hilton1");
            string hilton2 = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Hilton2");
            string hilton3 = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Hilton3");
            if (iteration == 1)
                return hilton1;
            if (iteration == 2)
                return hilton2;

            return hilton3;
        }

        /// <summary>
        ///     This methood will select the test property from the drop down.
        /// </summary>
        /// <param name="property"></param>
        public static void SelectProperty(string property)
        {
            AddDelay(10000);
            //Check if user has multiple properties by checking if the property dropdown exists.
            if (IsElementPresent(By.XPath("/html/body/div/form/div[6]/div/h1/div/a/div/b")))
            {
                Click_PropertyDropDown_Button();
                
                //If a multiple property user, select the property.
                ElementSelectFromDropDownDownAndClick(PageObject_EmployeeHome.PropertyDropDown_Text(), property);
            }
            else
            {
                //If a single property user, click the "Welcome" tab.
                Click_WelcomeButton();
            }
        }
        public static void Demo_SelectProperty(string property)
        {
            AddDelay(10000);
            //Check if user has multiple properties by checking if the property dropdown exists.
            if (IsElementPresent(By.XPath("/html/body/div/form/div[6]/div/h1/div/a/span")))
            {
                Click_PropertyDropDown_Button();

                //If a multiple property user, select the property.
                ElementSelectFromDropDownDownAndClick(PageObject_EmployeeHome.PropertyDropDown_Text(), property);
            }
            else
            {
                //If a single property user, click the "Welcome" tab.
                Click_WelcomeButton();
            }
        }

        /// <summary>
        ///     Verify the value selected in Property dropdown.
        /// </summary>
        public static void VerifyDropdownValue(string expectedvalue)
        {
            var actualvalue = PageObject_EmployeeHome.PropertyDropDown_Button().GetAttribute("innerHTML");
            if (actualvalue.Equals(expectedvalue))
                Logger.WriteInfoMessage("Its selected");
            else
                Logger.WriteInfoMessage("Not selected");
        }

        /// <summary>
        ///     This method will get the entire employee name.
        /// </summary>
        /// <returns>Entire employee name from the top right corner.</returns>
        private static string GetEmployeeFullName()
        {
            var fullName = CommonMethod.Driver.FindElement(By.XPath("//span[@id='ctl00_MainContent_lblEmpName']")).Text;
            return fullName;
        }

        /// <summary>
        ///     This method will find the employee's first name on the top right corner of the page.
        /// </summary>
        /// <returns>Employee's first name</returns>
        public static void GetEmployeeFirstName()
        {
            var firstName = GetEmployeeFullName().Split(' ')[0];
            var lastName = GetEmployeeFullName().Split(' ')[0];
            Logger.WriteDebugMessage("FirstName is " + firstName + " and LastName is " + lastName);
        }

        /// <summary>
        ///     This method will find the employee's last name on the top right corner of the page.
        /// </summary>
        /// <returns>Employee's last name</returns>
        //public static string GetEmployeeLastName()
        //{
        //    var lastName = GetEmployeeFullName().Split(' ')[1];

        //    return lastName;
        //}
    }
}