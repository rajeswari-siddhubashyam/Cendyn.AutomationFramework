using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eNgage.PageObject.UI;
using eNgage.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SqlWarehouse;

namespace eNgage.AppModule.UI
{
    class Search
    {
        public static void searchBy(IWebDriver d, IList<String> values)
        {
            Helper.AddDelay(1000);
            WebDriverWait wait = new WebDriverWait(d, TimeSpan.FromSeconds(20));
            IList<IWebElement> inputFields = new List<IWebElement>();
            foreach (IWebElement textbox in PageObject_Search.Search_Input())
            {
                if (textbox.Displayed)
                    inputFields.Add(textbox);
            }

            try
            {
                switch (values[0])
                {
                    case "Name":
                        {                            
                            if (values[1]=="Name"){
                                enterValues("First", values[2], inputFields);
                                enterValues("Last", values[3], inputFields);
                            }
                            else 
                                enterValues(values[1], values[2], inputFields);                     
                        }
                        break;
                    case "Profile":
                        {
                            enterValues(values[1], values[2], inputFields);
                        }
                        break;
                    case "Reservation":
                        {
                            enterValues(values[1], values[2], inputFields);
                        }
                        break;
                    case "Zip":
                        {
                            enterValues("Zip", values[1], inputFields);
                            enterValues("First", values[2], inputFields);
                            enterValues("Last", values[3], inputFields);
                        }
                        break;
                    case "Phone":
                        {
                            enterValues("Phone", values[1], inputFields);
                            enterValues("First", values[2], inputFields);
                            enterValues("Last", values[3], inputFields);
                        }
                        break;
                    case "Email":
                        {
                            enterValues("Email", values[1], inputFields);
                            if (values.Count > 2)
                            {
                                enterValues("First", values[2], inputFields);
                                enterValues("Last", values[3], inputFields);
                            }
                        }
                        break;
                    case "Membership": 
                        {
                            enterValues(values[1], values[2], inputFields);
                        }
                        break;
                    default:
                        Assert.Fail("Invalid value "+values[0]);
                        break;
                    
                }
                              
                Helper.AddDelay(500);
                PageObject_Search.Search_submit().Click();
                Helper.AddDelay(2000);
                wait.Until(x => (bool)(x as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));
                IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
                if (searchResults_Rows.Count > 0)
                {
                    Logger.WriteDebugMessage("Search By "+values[0]+"- Results Rows are present");          
                }
                else
                {
                    Logger.WriteDebugMessage("Search By "+values[0]+" Results empty");
                }

            }
            catch (WebDriverTimeoutException e)
            {
                TestHandling.TestFailed(e);
            }
        }
        public static void enterValues(string placeholder, string text, IList<IWebElement> inputFields)
        {
            foreach (IWebElement i in inputFields)
            {
                
                if (i.GetAttribute("placeholder") == placeholder)
                {
                    i.Clear();
                    i.SendKeys(text);
                }
                   
             }
        }
        public static void clickFromSearchResults(IWebDriver d)
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            Random randomNumber = new Random();
            Logger.WriteInfoMessage("Clicking on the first profile from search list");
            //int row = randomNumber.Next(0, searchResults_Rows.Count - 1);
            if (searchResults_Rows.Count != 0)
                searchResults_Rows[0].FindElement(By.TagName("td")).Click();
            else
            {
                Assert.Fail("Search result empty");
                Assert.Fail("Search result empty");
            }

        }
        
        public static void verifyNameSearchResults(IWebDriver d,string FirstName,string LastName)
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            if (searchResults_Rows.Count != 0)
            {
                //Logger.WriteInfoMessage("Search Results Rows are present");
                IList<IWebElement> searchResults_Columns = searchResults_Rows[0].FindElements(By.TagName("td"));
                string FullName = LastName + ", " + FirstName;
                Assert.IsTrue(searchResults_Columns[1].Text.Contains(FullName));
                if (searchResults_Columns[1].Text.Contains(FullName))
                {
                    Logger.WriteDebugMessage("Search name Present");
                }
                else
                {
                    Assert.Fail("search name not present");
                }
            }
        }
        /*public static void VerifyProfileSearchResults(IWebDriver d, string ProfileID)
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            if (searchResults_Rows.Count != 0)
            {
                //Logger.WriteInfoMessage("Search Results Rows are present");
                IList<IWebElement> searchResults_Columns = searchResults_Rows[0].FindElements(By.TagName("td"));
                
                Assert.IsTrue(searchResults_Columns[0].Text.Contains(ProfileID));
                if (searchResults_Columns[0].Text.Contains(ProfileID))
                {
                    Logger.WriteDebugMessage("Search Profile ID Present");
                }
                else
                {
                    Logger.WriteFatalMessage("search Profile ID not present");
                }
            }
        }*/

        public static void VerifyEmailPhoneSearchResults(IWebDriver d, string value ,string firstname,string lastname,string SelectValue)
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            if (searchResults_Rows.Count != 0)
            {
                IList<IWebElement> searchResults_Columns = searchResults_Rows[0].FindElements(By.TagName("td"));
                int index = 2;
                switch (SelectValue)
                {
                    case "Phone":
                        {
                            index = 3;
                            break;
                        }
                    case "Email":
                        {
                            index = 2;
                            break;
                        }
                    case "Zip":
                        {
                            index = 5;
                            break;
                        }
                }
                /*if (SelectValue == "Phone")
                    index = 3;*/

                if (value != null )
                {
                    string columnText = searchResults_Columns[index].Text;
                    if(columnText.Contains(" ") && SelectValue=="Phone")
                        columnText = columnText.Replace(" ", "");
                    Assert.IsTrue(columnText.Contains(value.Trim()));
                    if (columnText.Contains(value.Trim()))
                    {
                        Logger.WriteDebugMessage("Search Value Present");
                    }
                    else
                    {
                        Assert.Fail("search Value not present");
                    }
                }
                if (firstname != null & lastname != null)
                {
                    string FullName = lastname + ", " + firstname;
                    Assert.IsTrue(searchResults_Columns[1].Text.Contains(FullName));
                    if (searchResults_Columns[1].Text.Contains(FullName))
                    {
                        Logger.WriteDebugMessage("Search name Present");
                    }
                    else
                    {
                        Assert.Fail("search name not present");
                    }
                }
            }
        }
        public static void VerifyIDSearchResults(IWebDriver d, string ID, string ProfileID)
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            if (searchResults_Rows.Count != 0)
            {
                IList<IWebElement> searchResults_Columns = searchResults_Rows[0].FindElements(By.TagName("td"));
                if (ID != null && ID!="")
                {
                    Assert.IsTrue(searchResults_Columns[0].Text.Contains(ProfileID));
                    if (searchResults_Columns[0].Text.Contains(ProfileID))
                    {
                        Logger.WriteDebugMessage("Search ID Present");
                    }
                    else
                    {
                        Assert.Fail("search Email not present");
                    }
                }
                else
                {
                    Logger.WriteDebugMessage("No ID in input xml");
                }
               
            }
        }
        public static string getEmailFromSearch(IWebDriver d, string ID)
        {
            string returnEmail = "";
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            if (searchResults_Rows.Count != 0)
            {
                IList<IWebElement> searchResults_Columns = searchResults_Rows[0].FindElements(By.TagName("td"));
                if (ID != null && ID != "")
                {
                    returnEmail = searchResults_Columns[2].Text;
                }
                else
                {
                    Logger.WriteDebugMessage("No ID in input xml");
                }

            }
            return returnEmail.Trim();
        }
        public static void ClearInputValues()
        {
            foreach (IWebElement textbox in PageObject_Search.Search_Input())
            {
                if (textbox.Displayed)
                    textbox.Clear();
            }
        }
        public static void loadMultipleSearches(IWebDriver d,WebDriverWait w,IList<String> searchText,string searchByValue)
        {
            PageObject_Search.Nav_Search().Click();
            Helper.AddDelay(500);
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue(searchByValue);
            IList<IWebElement> inputFields = new List<IWebElement>();
            foreach (IWebElement textbox in PageObject_Search.Search_Input())
            {
                if (textbox.Displayed)
                    inputFields.Add(textbox);
            }
            Search.ClearInputValues();
            
            int count = 0;
            int i = 0;
            while (count < 5)
            {
                Search.ClearInputValues();
                IList<String> InputElements = new List<String>();
                if (searchByValue == "Reservation")
                {
                    InputElements.Add(searchDropDown.SelectedOption.GetAttribute("value"));
                    InputElements.Add(searchByValue);
                    InputElements.Add(searchText[i]);
                }
                else if (searchByValue == "Email")
                {
                    InputElements.Add(searchDropDown.SelectedOption.GetAttribute("value"));
                    InputElements.Add(searchText[i]);
                }

                Search.searchBy(d, InputElements);
                count++;
                IWebElement searchResults_Row = PageObject_Search.Search_Results().FindElement(By.TagName("tr"));
                searchResults_Row.FindElement(By.TagName("td")).Click();
                Helper.AddDelay(200);
                Prompts.checkPromptsLoad(d, w);
                Logger.WriteInfoMessage(searchByValue +" Search Count " + count);
                PageObject_Search.Nav_Search().Click();
                i++;
                if (i > searchText.Count - 1)
                {
                    i = 0;
                }

            }
        }
        public static IList<String> FilterEmailList(IList<String> originalEmail)
        {
            IList<String> EmailList = new List<String>();
            foreach(String email in originalEmail)
            {
                EmailList.Add(email.Replace("@cendyn17.com", ""));
            }
            return EmailList;
        }

        public static void changeSearchButton(string searchType)
        {
            string selectedSearch = PageObject_Search.Search_submit().Text;
            Helper.AddDelay(500);
            PageObject_Search.Search_Button_MoreValues().Click();
            IList<IWebElement> SearchValues = PageObject_Search.Search_Button_Listed_Values();
            foreach(IWebElement i in SearchValues)
            {
                if (i.Text.Trim() == searchType)
                    i.Click();
            }
            Logger.WriteInfoMessage("Search changed to -" + searchType);
        }
        public static void checkSearchResultsForInvalid()
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            Assert.Zero(searchResults_Rows.Count);
            if (searchResults_Rows.Count == 0)
            {
                Logger.WriteInfoMessage("Search For Invalid data- So search Result is 0");
            }
            else
            {
                Assert.Fail("Search For Invalid data - Results is not 0");
            }
        }
        public static void checkSearchResultsForValid()
        {
            IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
            Assert.NotZero(searchResults_Rows.Count);
            if (searchResults_Rows.Count >= 0)
            {
                Logger.WriteInfoMessage("Search For Valid data - Results Found");
            }
            else
            {
                Assert.Fail("Search for valid data - Results not found");
            }
        }
        public static void searchByNullValues()
        {
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            Search.changeSearchButton("Search Network");
            for (int i = 0; i < searchDropDown.Options.Count; i++)
            {
                Search.ClearInputValues();
                PageObject_Search.Search_submit().Click();
                IList<IWebElement> searchResults_Rows = PageObject_Search.Search_Results().FindElements(By.TagName("tr"));
                Assert.NotZero(searchResults_Rows.Count);
                if (searchResults_Rows.Count >= 0)
                {
                    Logger.WriteInfoMessage("Empty search - Lists Generic search results");
                }
                else
                {
                    Assert.Fail("Empty search - no results found");
                }
            }
        }
        public static void searchInvalidData(IWebDriver d, string caseID)
        {
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());

            string profile_ID = SqlWarehouseQuery.ReturnGetTestDataValue(caseID, "ProfileID");
            string fName = SqlWarehouseQuery.ReturnGetTestDataValue(caseID, "FirstName");
            string lName = SqlWarehouseQuery.ReturnGetTestDataValue(caseID, "LastName");
            string emailadd = SqlWarehouseQuery.ReturnGetTestDataValue(caseID, "Email");
            string resID = SqlWarehouseQuery.ReturnGetTestDataValue(caseID, "ReservationID");
            string phoneNum = SqlWarehouseQuery.ReturnGetTestDataValue(caseID, "Phone");

            Search.changeSearchButton("Search Hotel");
            for (int i = 0; i < searchDropDown.Options.Count; i++)
            {
                searchDropDown.SelectByIndex(i);
                IList<String> InputElements = new List<String>();
                InputElements.Clear();
                switch (searchDropDown.SelectedOption.GetAttribute("Value"))
                {
                    case "Name":
                        {
                            InputElements = new List<String>()
                             {   searchDropDown.SelectedOption.GetAttribute("value"),
                                 "Name",
                                 fName,
                                 lName
                             };
                        }
                        break;
                    case "Profile":
                        {
                            InputElements = new List<String>()
                             {   searchDropDown.SelectedOption.GetAttribute("value"),
                                 "Profile",
                                  profile_ID
                             };
                        }
                        break;
                    case "Reservation":
                        {
                            InputElements = new List<String>()
                             {   searchDropDown.SelectedOption.GetAttribute("value"),
                                 "Reservation",
                                 resID
                             };
                        }
                        break;
                    case "Membership":
                        {
                            InputElements = new List<String>()
                             {   searchDropDown.SelectedOption.GetAttribute("value"),
                                 "Membership",
                                 resID
                             };
                        }
                        break;
                    case "Email":
                        {
                            InputElements = new List<String>()
                             {   searchDropDown.SelectedOption.GetAttribute("value"),
                                 emailadd,
                                 fName,
                                 lName
                             };
                        }
                        break;
                    case "Phone":
                        {
                            InputElements = new List<String>()
                             {   searchDropDown.SelectedOption.GetAttribute("value"),
                                 phoneNum,
                                 fName,
                                 lName
                             };
                        }
                        break;
                    case "Zip":
                        {
                            InputElements = new List<String>()
                            {   searchDropDown.SelectedOption.GetAttribute("value"),
                                phoneNum,
                                fName,
                                lName
                             };
                        }
                        break;
                    default:
                        break;
                }

                Search.searchBy(d, InputElements);
                Search.checkSearchResultsForInvalid();
            }
        }
        public static void VerifySearchValuesFields()
        {
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            List<string> searchValues = new List<string>() { "Profile", "Reservation", "Name", "Membership", "Email", "Phone", "Zip" };
            for (int i = 0; i < searchDropDown.Options.Count; i++)
            {
                searchDropDown.SelectByIndex(i);
                if (searchValues.Contains(searchDropDown.SelectedOption.GetAttribute("Value")))
                {
                    searchValues.Remove(searchDropDown.SelectedOption.GetAttribute("Value"));
                }
            }
            Assert.Zero(searchValues.Count);
            if (searchValues.Count == 0)
            {
                Logger.WriteDebugMessage("All the Search Values are present");
            }
            else
            {
                Assert.Fail("Some Search values missing " + string.Join(",", searchValues));
            }


            for (int i = 0; i < searchDropDown.Options.Count; i++)
            {
                searchDropDown.SelectByIndex(i);
                IList<IWebElement> inputFields = new List<IWebElement>();
                foreach (IWebElement textbox in PageObject_Search.Search_Input())
                {
                    if (textbox.Displayed)
                        inputFields.Add(textbox);
                }


                switch (searchDropDown.SelectedOption.GetAttribute("Value"))
                {

                    case "Name":
                        {
                            Assert.AreEqual(inputFields.Count, 2);
                            if (inputFields.Count == 2)
                            {
                                Logger.WriteDebugMessage(inputFields.Count + " input fields found for " + searchDropDown.SelectedOption.GetAttribute("Value"));
                            }
                            else
                            {
                                Assert.Fail(inputFields.Count + " input fields found for " + searchDropDown.SelectedOption.GetAttribute("Value") + " - Should be 2");
                            }
                        }
                        break;
                    case "Profile":
                    case "Reservation":
                    case "Membership":
                        {
                            Assert.AreEqual(inputFields.Count, 1);
                            if (inputFields.Count == 1)
                            {
                                Logger.WriteDebugMessage(inputFields.Count + " input fields found for " + searchDropDown.SelectedOption.GetAttribute("Value"));
                            }
                            else
                            {
                                Assert.Fail(inputFields.Count + " input fields found for " + searchDropDown.SelectedOption.GetAttribute("Value") + " - Should be 1");
                            }
                        }
                        break;

                    case "Email":
                    case "Phone":
                    case "Zip":
                        {
                            Assert.AreEqual(inputFields.Count, 3);
                            if (inputFields.Count == 3)
                            {
                                Logger.WriteDebugMessage(inputFields.Count + " input fields found for " + searchDropDown.SelectedOption.GetAttribute("Value"));
                            }
                            else
                            {
                                Assert.Fail(inputFields.Count + " input fields found for " + searchDropDown.SelectedOption.GetAttribute("Value") + " - Should be 3");
                            }
                        }
                        break;

                    default:
                        Assert.Fail("Invalid dropdown value " + searchDropDown.SelectedOption.GetAttribute("Value"));
                        break;
                }
            }
        }
    }
}
