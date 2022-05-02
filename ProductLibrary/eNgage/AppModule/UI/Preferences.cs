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

namespace eNgage.AppModule.UI
{
    class Preferences
    {
        public static void addPreferences(IWebDriver d)
        {
            try
            {
                if (PageObject_Preferences.Nav_Preferences().Displayed==true)
                {
                    PageObject_Preferences.Nav_Preferences().Click();
                    Helper.AddDelay(2000);
                    IWebElement Preferences_Div = PageObject_Preferences.Preferences_Div();
                    IList<IWebElement> Preferences_SelectElements = PageObject_Preferences.Preferences_SelectElements();
                    IList<IWebElement> Preferences_CheckBox = PageObject_Preferences.Preferences_CheckBox();

                    Random r = new Random();
                    var index = 0;
                    Random r2 = new Random();
                    var selectindex = 0;
                    
                    if (Preferences_SelectElements.Count>0 || Preferences_CheckBox.Count>0)
                    {
                        Logger.WriteInfoMessage("Preferences found");
                        if(Preferences_SelectElements.Count > 0)
                        {
                            foreach (IWebElement i in Preferences_SelectElements)
                            {
                                selectindex = r2.Next(0, 2);
                                Console.WriteLine("select index "+selectindex);

                                if ( selectindex== 1)
                                {
                                    var preference = new SelectElement(i);
                                    index = r.Next(0, preference.Options.Count - 1);
                                    preference.SelectByIndex(index);
                                }                                
                            }
                        }
                        index = 0;
                        if(Preferences_CheckBox.Count > 0)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                               index = r.Next(1, Preferences_CheckBox.Count);
                               Preferences_CheckBox[index].Click();
                            }
                        }
                    }
                    else
                    {
                        Logger.WriteFatalMessage("No Preferences displayed in Preferences tab");
                    }
                }
                else
                {
                    Logger.WriteFatalMessage("No Preferences found");
                }
                
            }
            catch(Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        public static void savePreferences(IWebDriver d)
        {
            PageObject_Preferences.Preferences_Save().Click();
            Helper.AddDelay(2000);
            var display = PageObject_Preferences.Preferences_SavedText();
            Assert.AreEqual(display.Displayed, true);
            if(display.Displayed == true)
            {
                Logger.WriteDebugMessage("Preference Saved");
            }
            else
            {
                Logger.WriteDebugMessage("Preference Not Saved");
            }
        }

        public static void removePreferences(IWebDriver d)
        {
            try
            {
                if (PageObject_Preferences.Nav_Preferences().Displayed == true)
                {
                    PageObject_Preferences.Nav_Preferences().Click();
                    Helper.AddDelay(500);
                    IWebElement Preferences_Div = PageObject_Preferences.Preferences_Div();
                    IList<IWebElement> Preferences_SelectElements = PageObject_Preferences.Preferences_SelectElements();
                    IList<IWebElement> Preferences_CheckBox = PageObject_Preferences.Preferences_CheckBox();
                    
                    if (Preferences_SelectElements.Count > 0 || Preferences_CheckBox.Count > 0)
                    {
                        Logger.WriteInfoMessage("Removing preferences");
                        if (Preferences_SelectElements.Count > 0)
                        {
                            foreach (IWebElement i in Preferences_SelectElements)
                            {
                                //i.Clear();
                                var preference = new SelectElement(i);
                                preference.SelectByText("No Preference");
                            }

                            
                        }
                        
                        if (Preferences_CheckBox.Count > 0)
                        {
                            foreach (IWebElement i in Preferences_CheckBox)
                            {
                                if(i.Selected==true)
                                    i.Click();
                               // Preferences_CheckBox[index].Click();
                            }
                        }
                    }
                    else
                    {
                        Logger.WriteFatalMessage("No Preferences displayed in Preferences tab");
                    }
                }
                else
                {
                    Logger.WriteFatalMessage("No Preferences found");
                }

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        public static int savePreferencesCount(IWebDriver d)
        {
            int count = 0;
            IWebElement Preferences_Div = PageObject_Preferences.Preferences_Div();
            IList<IWebElement> Preferences_SelectElements = PageObject_Preferences.Preferences_SelectElements();
            IList<IWebElement> Preferences_CheckBox = PageObject_Preferences.Preferences_CheckBox();
            for (int i = 0; i < Preferences_SelectElements.Count; i++)
            {
                var preference = new SelectElement(Preferences_SelectElements[i]);
                if (preference.SelectedOption.Text != "No Preference")
                    count++;
            }
            for (int j = 0; j < Preferences_CheckBox.Count; j++)
            {
                if (Preferences_CheckBox[j].GetAttribute("checked") != null)
                {
                    count++;
                }
            }
            return count;
        }

        public static void verifyPreferencesSaved(IWebDriver d, int beforeSaveCount, int afterSaveCount)
        {
            Assert.AreEqual(beforeSaveCount, afterSaveCount);
            if (beforeSaveCount == afterSaveCount)
            {
                Logger.WriteDebugMessage("Preferences saved correctly");
            }
            else
            {
                Logger.WriteFatalMessage("Preferences are not added to the DB");
            }
        }
    }
}
