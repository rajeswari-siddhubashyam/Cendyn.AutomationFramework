using System;
using BaseUtility.Utility;
using eMenus.PageObject.UI;
using InfoMessageLogger;

namespace eMenus.AppModule.UI
{
    class HomePage
    {
        public static void Click_HotelOrigami_Logo()
        {
            Helper.ElementClick(PageObject_HomePage.Click_HotelOrogami_Logo());
        }
        public static void Click_HomePage_Filter()
        {
            Helper.ElementWait(PageObject_HomePage.Click_HomePage_Filter(), 120);
            Helper.ElementClick(PageObject_HomePage.Click_HomePage_Filter());
        }
        public static void HomePage_ClearFilter()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_ClearFilter());
        }
        public static void HomePage_ApplyFilter()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_ApplyFilter());
        }
        public static void HomePage_Search(string text)
        {
            Helper.ElementEnterText(PageObject_HomePage.HomePage_Search(), text);
        }
        public static void HomePage_FilterBy_GlutenFree()
        {
            Helper.ElementWait(PageObject_HomePage.HomePage_FilterBy_GlutenFree(), 120);
            Helper.ElementClick(PageObject_HomePage.HomePage_FilterBy_GlutenFree());
        }
        public static void HomePage_FilterBy_Egg()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_FilterBy_Egg());
        }
        public static void HomePage_FilterBy_Milk()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_FilterBy_Milk());
        }
        public static void HomePage_FilterBy_MostPopular()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_FilterBy_MostPopular());
        }
        public static void HomePage_DinnerDropdown()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_DinnerDropdown());
        }
        public static void HomePage_Select_DinnerTable()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_Select_DinnerTable());
        }
        public static void HomePage_DinnerTable_MenuInfoButton()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_DinnerTable_MenuInfoButton());
        }
        public static void HomePage_BreakfastDropdown()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_BreakfastDropdown());
        }
        public static void HomePage_Select_BreakfastBuffet()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_Select_BreakfastBuffet());
        }
        public static void HomePage_Select_ContinentalBreakfast()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_Select_ContinentalBreakfast());
        }
        public static void HomePage_BreakfastBuffet_MenuInfoButton()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_BreakfastBuffet_MenuInfoButton());
        }

        public static void HomePage_ReceptionDropdown()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_ReceptionDropdown());
        }
        public static void HomePage_Select_ActionStations()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_Select_ActionStations());
        }
        public static void HomePage_ActionStations_MenuInfoButton()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_ActionStations_MenuInfoButton());
        }
        public static void Click_HomePage_MoreButton()
        {
            Helper.ElementClick(PageObject_HomePage.Click_HomePage_MoreButton());
        }
        public static void HomePage_FilterBy_Favorite()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_FilterBy_Favorite());
        }
        public static void Click_HomePage_LessButton()
        {
            Helper.ElementClick(PageObject_HomePage.Click_HomePage_LessButton());
        }
        public static void HomePage_Filter(string glutenFreeMenu_Name)
        {
            Click_HotelOrigami_Logo();
            Logger.WriteDebugMessage("User should able to navigate to Home page");
            Click_HomePage_Filter();
            Logger.WriteDebugMessage("User should able to click on Filter button on the page");
            HomePage_FilterBy_GlutenFree();
            Logger.WriteDebugMessage("Gluten Free menu check box should get selected");
            HomePage_ApplyFilter();
            GlutenFree_Menu(glutenFreeMenu_Name);
            //Helper.AddDelay(5000);
            //Click_HomePage_Filter();
            //Common_Filter();
            //HomePage_FilterBy_Egg();
            //Logger.WriteDebugMessage("Egg menu check box should get selected");
            //HomePage_ApplyFilter();
            //Egg_Menu(glutenFreeMenu_Name);
            //Click_HomePage_Filter();
            //Common_Filter();
            //HomePage_FilterBy_MostPopular();
            //Logger.WriteDebugMessage("Most Popular menu check box should get selected");
            //HomePage_ApplyFilter();
            //MostPopular_Menu(mostPopularMenu_Name);
            //Commented code as More button is not present
            //Click_HomePage_Filter();
            //Helper.ScrollToElement(PageObject_HomePage.Click_HomePage_MoreButton());
            //Logger.WriteDebugMessage("More button should get display");
            //Click_HomePage_MoreButton();
            //HomePage_FilterBy_Favorite();
            //Logger.WriteDebugMessage("Favorite menu should get selected");
            //Click_HomePage_LessButton();
            //Common_Filter();
            //SearchOperation(mostPopularMenu_Name);

        }
        public static void GlutenFree_Menu(string glutenFreeMenu_Name)
        {
            HomePage_DinnerDropdown();
            HomePage_Select_DinnerTable();
            Helper.ScrollToElement(PageObject_HomePage.HomePage_DinnerTable_MenuInfoButton());
            Helper.AddDelay(3000);
            HomePage_DinnerTable_MenuInfoButton();
            string name = GlutenFree_MenuName();
            try
            {
                if (name.Equals(glutenFreeMenu_Name))
                {
                    Logger.WriteDebugMessage("Gluten Free menu should get displayed on the page and the name is : " + name);
                }
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Gluten Free menu not displayed on the page", e.InnerException);
            }

        }
        public static void Egg_Menu(string glutenFreeMenu_Name)
        {
            Helper.AddDelay(3000);
            HomePage_BreakfastDropdown();
            HomePage_Select_BreakfastBuffet();
            Helper.DynamicScroll(Helper.Driver, PageObject_HomePage.HomePage_BreakfastBuffet_MenuInfoButton());
            Helper.AddDelay(10000);
            HomePage_BreakfastBuffet_MenuInfoButton();
            string name = Egg_MenuName();
            try
            {
                if (name.Equals(glutenFreeMenu_Name))
                {
                    Logger.WriteDebugMessage("Gluten Free menu should get displayed on the page and the name is : " + name);
                }
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Gluten Free menu not displayed on the page", e.InnerException);
            }
        }
        public static void MostPopular_Menu(string mostPopularMenu_Name)
        {
            HomePage_ReceptionDropdown();
            HomePage_Select_ActionStations();
            Helper.DynamicScroll(Helper.Driver, PageObject_HomePage.HomePage_ActionStations_MenuInfoButton());
            Helper.AddDelay(3000);
            HomePage_ActionStations_MenuInfoButton();
            string name = MostPopular_MenuName();
            try
            {
                if (name.Equals(mostPopularMenu_Name))
                {
                    Logger.WriteDebugMessage("Most popular menu should get displayed on the page and the name is : " + name);
                }
            }
            catch (Exception e)
            {
                Logger.WriteErrorMessage("Most popular menu not displayed on the page", e.InnerException);
            }

        }
        public static void SearchOperation(string mostPopularMenu_Name)
        {
            HomePage_Search(mostPopularMenu_Name);
            HomePage_FilterBy_MostPopular();
            Logger.WriteDebugMessage("search result should get displayed");
            HomePage_ApplyFilter();
            MostPopular_Menu(mostPopularMenu_Name);
        }
        public static string GlutenFree_MenuName()
        {
            return PageObject_HomePage.GlutenFree_MenuName().GetAttribute("innerHTML");
        }
        public static string Egg_MenuName()
        {
            return PageObject_HomePage.Egg_MenuName().GetAttribute("innerHTML");
        }
        public static string MostPopular_MenuName()
        {
            return PageObject_HomePage.MostPopular_MenuName().GetAttribute("innerHTML");
        }
        public static void Common_Filter()
        {
            HomePage_ClearFilter();
            Click_HomePage_Filter();
            Logger.WriteDebugMessage("Filter should get cleared");
        }

        public static string Get_Continental_Menu_Price(string menuname)
        {
            return PageObject_HomePage.Get_Continental_brkfast_MenuPrice(menuname).GetAttribute("innerHTML");
        }

        public static void Select_Event_date(string date)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_HomePage.Select_Event_date());
            Helper.ElementClick(PageObject_HomePage.Select_Event_date());
            Helper.ElementEnterTextUsingJQuery(PageObject_HomePage.Select_Event_date(), date);
            PageObject_HomePage.Select_Event_date().SendKeys(OpenQA.Selenium.Keys.Enter);
            PageObject_HomePage.Select_Event_date().SendKeys(OpenQA.Selenium.Keys.Enter);
        }
        public static string First_Menu_Price_Frontend(string menuname)
        {
            return PageObject_HomePage.First_Menu_Price_Frontend(menuname).GetAttribute("innerHTML");
        }
        public static void Added_CategoryDropDown(string categoryName)
        {
            Helper.ElementClick(PageObject_HomePage.Added_CategoryDropDown(categoryName));
        }
        public static void Click_Category_Sub_Menu(string categoryName)
        {
            Helper.ElementClick(PageObject_HomePage.Click_Category_Sub_Menu(categoryName));
        }
        public static void Click_Category_Menu()
        {
            Helper.ElementClick(PageObject_HomePage.Click_Category_Menu());
        }

        public static void Click_Link_Home()
        {
            Helper.ElementClick(PageObject_HomePage.Click_Link_Home());
        }
        public static void HomePage_Filter(string category, string glutenFreeMenu_Name, string milkAvoidanceMenu_Name, string mostPopularMenu_Name)
        {
            Click_HotelOrigami_Logo();
            Helper.AddDelay(5000);
            Logger.WriteDebugMessage("User should able to navigate to Home page");
            Click_HomePage_Filter();
            Helper.AddDelay(5000);
            HomePage_ClearFilter();
            Click_HomePage_Filter();
            Logger.WriteDebugMessage("User should able to click on Filter button on the page");
            HomePage_FilterBy_GlutenFree();
            Logger.WriteDebugMessage("Gluten Free menu check box should get selected");
            HomePage_ApplyFilter();
            Admin.PropertyAdmin.Click_MyMenu_MainCategory(category);
            Helper.VerifyTextOnPageAndHighLight(glutenFreeMenu_Name);
            Logger.WriteInfoMessage("Dietary Restrictions filter showing matching item.");

            Click_HomePage_Filter();
            Helper.AddDelay(5000);
            HomePage_ClearFilter();
            Click_HomePage_Filter();
            Logger.WriteDebugMessage("User should able to click on Filter button on the page");
            HomePage_FilterBy_Milk();
            Logger.WriteDebugMessage("Milk avoidance check box should get selected");
            HomePage_ApplyFilter();
            Admin.PropertyAdmin.Click_MyMenu_MainCategory(category);
            if (Helper.VerifyTextNOTOnPage(milkAvoidanceMenu_Name))
                Logger.WriteFatalMessage("Item containing avoidance selected is showing when it should be filtered out.");
            else
                Logger.WriteInfoMessage("Item containing avoidance is filtered out");

            Click_HomePage_Filter();
            Helper.AddDelay(5000);
            HomePage_ClearFilter();
            Click_HomePage_Filter();
            Logger.WriteDebugMessage("User should able to click on Filter button on the page");
            HomePage_FilterBy_MostPopular();
            Logger.WriteDebugMessage("Most Popular check box should get selected");
            HomePage_ApplyFilter();
            Admin.PropertyAdmin.Click_MyMenu_MainCategory(category);
            Helper.VerifyTextOnPageAndHighLight(mostPopularMenu_Name);
            Logger.WriteInfoMessage("Most Popular filter showing matching item.");

        }
        public static void Click_PrintIcon()
        {
            Helper.ElementClick(PageObject_HomePage.Click_PrintIcon());
        }
        public static void HomePage_Breakfast()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_Breakfast());
        }
        public static void HomePage_Break()
        {
            Helper.ElementClick(PageObject_HomePage.HomePage_Break());
        }
    }
}
