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
    class Prompts
    {
        public static void checkPromptsLoad(IWebDriver d, WebDriverWait w)
        {
            Helper.AddDelay(100);
            try
            {
                w.Until(x => (bool)(x as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));

                IList<IWebElement> prompts = PageObject_Prompts.Prompts_Container().FindElements(By.ClassName("portlet-title"));
                Assert.NotZero(prompts.Count);
                if (prompts.Count != 0)
                    Logger.WriteDebugMessage("Prompts loaded successfully");
                else
                    Logger.WriteFatalMessage("No Prompts found");
            }
            catch(WebDriverTimeoutException e)
            {
                TestHandling.TestFailed(e);
            }
        }
        public static string addPromptsResponse(IWebDriver d)
        {
            WaitTillLoaderhideForPrompts();
            IList<IWebElement> prompts = PageObject_Prompts.Prompts_Div();
            IList<IWebElement> Responses = PageObject_Prompts.Prompts_Responses(prompts[0]);
            Random r = new Random();
            int i = r.Next(0, Responses.Count-1);
            Responses[i].Click();
            return Responses[i].GetAttribute("val");
        }
        public static void checkSavedResponse(string ProfileID, string ResponseClicked, Dictionary<string,string> ResponseFromDb)
        {
            WaitTillLoaderhideForPrompts();
            IList<IWebElement> prompts = PageObject_Prompts.Prompts_Div();
            IList<IWebElement> Responses = PageObject_Prompts.Prompts_Responses(prompts[0]);
            
            foreach(IWebElement r in Responses)
            {
                if(r.GetAttribute("val").Trim()== ResponseClicked.Trim())
                {
                    Assert.IsTrue(r.GetAttribute("class").Contains("selected"));
                    if (r.GetAttribute("class").Contains("selected"))
                    {
                        Logger.WriteDebugMessage("Response Saved");
                    }
                    else
                    {
                        if(ProfileID== ResponseFromDb.Keys.ElementAt(0) && ResponseClicked== ResponseFromDb[ResponseFromDb.Keys.ElementAt(0)])
                        {
                            Logger.WriteWarnMessage("Response saved in DB but not displayed in UI");
                        }
                        else
                        {
                            Logger.WriteFatalMessage("Response not saved in DB");
                        }
                    }
                }
            }
        }
        public static string FindRule(string RuleName, List<PromptsRules> pr)
        {
           string promptText= null;
           for(int i = 0; i < pr.Count; i++)
           {
                if (pr[i].RuleName.Contains(RuleName))
                {
                    promptText = pr[i].PromptText;
                    i = pr.Count;
                }
             
           }
           return promptText;
        }
        public static string GetDisplayPrompt(string text)
        {
            string displayPrompt= null;
            string promptText = null;
            IList<IWebElement> prompts = PageObject_Prompts.Prompts_Div();
            foreach(IWebElement i in prompts)
            {
                IWebElement PromptDiv = PageObject_Prompts.Prompts_Div2(i);
                promptText = PageObject_Prompts.Prompts_Text(PromptDiv);
                    //Prompts_Text(i).Text;
                if (promptText.ToLower().Contains(text))
                {
                    displayPrompt = promptText;
                }
            }
            return displayPrompt;
        }
        public static IWebElement GetDisplayPromptDiv(string text)
        {
            IWebElement displayPrompt = null;
            string promptText = null;
            IList<IWebElement> prompts = PageObject_Prompts.Prompts_Div();
            foreach (IWebElement i in prompts)
            {
                IWebElement PromptDiv = PageObject_Prompts.Prompts_Div2(i);
                promptText = PageObject_Prompts.Prompts_Text(PromptDiv);
                //Prompts_Text(i).Text;
                if (promptText.ToLower().Contains(text))
                {
                    displayPrompt = PromptDiv;
                }
            }
            return displayPrompt;
        }
        public static void VerifyPromptMatch(string promptFromDb,string promptFromUI,string email="noemail")
        {
            if (promptFromDb.Contains("%HotelName%"))
            {
                string hotelname = PageObject_Home.Home_SelectedHotel().Text;
                promptFromDb = promptFromDb.Replace("%HotelName%",hotelname.Trim());
            }
            else if (promptFromDb.Contains("%Email%"))
            {
                promptFromDb = promptFromDb.Replace("%Email%", email.Trim());
            }
            else if (promptFromDb.Contains("\n"))
            {
                promptFromDb = promptFromDb.Replace("\n", " ");
            }

            Assert.AreEqual(promptFromDb.Trim(), promptFromUI.Trim());
            if(promptFromDb.Trim()== promptFromUI.Trim())
            {
                Logger.WriteDebugMessage("Prompts Match - Prompt displayed -"+promptFromUI);
            }
            else
            {
                Logger.WriteFatalMessage("Prompts dont match UI- " + promptFromUI+ " DB -"+ promptFromDb);
            }
        }
        public static void enterEmail(IWebElement promptDiv,string text)
        {
            IWebElement textfield = PageObject_Prompts.Prompts_inputText(promptDiv);
            if(textfield==null)
            {
                Logger.WriteFatalMessage("No text box to enter email ");
            }
            else
            {
                textfield.SendKeys(text);
                PageObject_Prompts.Prompts_submit(promptDiv).Click();
            }
        }
        public static void VerifyPromptsResponseSavedDB(string email, PromptsResponses responsefromDB)
        {
            Assert.AreEqual(responsefromDB.Response.Trim(), email.Trim());
             if (responsefromDB.Response.Trim() == email.Trim())
             {
                Logger.WriteDebugMessage("Email saved in Prompts DB");
             }
             else
             {
                Logger.WriteFatalMessage("Email NOT saved in Prompts DB");
             }
        }

        public static void WaitTillLoaderhideForPrompts()
        {
            string loaderStatus = Helper.Driver.FindElement(By.XPath(PageObject_Prompts.Prompts_Loader())).GetAttribute("style");
            while (String.IsNullOrEmpty(loaderStatus))
            {
                Helper.AddDelay(1000);
                loaderStatus = Helper.Driver.FindElement(By.XPath(PageObject_Prompts.Prompts_Loader())).GetAttribute("style");
            }
        }

     }
}
