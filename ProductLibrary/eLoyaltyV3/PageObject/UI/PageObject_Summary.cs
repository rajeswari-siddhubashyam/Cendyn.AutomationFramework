
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_Summary : Utility.Setup
    {
        
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.Summary;

        public static IWebElement Text_MembershipNo(string ProjectName)
        {
            if( ProjectName.Equals("MyStay") || ProjectName.Equals("Iberostar") || ProjectName.Equals("NYLO"))
            {
                ScanPage(Constants.Summary);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//*[@id='collapseOne']/div/div/p[1]/strong");
            }
            else if(ProjectName.Equals("Bartell"))
            {
                ScanPage(Constants.Summary);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//span[text()='Membership No']/following-sibling::span");
                
            }
            else if(ProjectName.Equals("MyPlace")|| ProjectName.Equals("HotelOrigami"))
            {
                ScanPage(Constants.Summary);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//div[@class='member-info member-id']/span[@class='value']");
            }
            else if (ProjectName.Equals("Sarova")|| ProjectName.Equals("WoodLoch"))
            {
                ScanPage(Constants.Summary);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//span[@class='info-label']/following-sibling::span");
            }
            else if (ProjectName.Equals("EHPC"))
            {
                ScanPage(Constants.Summary);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//div[@class='member-info member-id']/div[1]/span");
            }
            else
            {
                ScanPage(Constants.Summary);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.Summary_Text_MembershipNo);
            }          

        }

        public static IWebElement Text_MembershipType()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Summary_Text_MembershipType);
        }
        public static IWebElement Summary_Click_MembershipCard()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Summary_Click_MembershipCard);
        }
        public static IWebElement Summary_MembershipCard_Name()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Summary_MembershipCard_Name);
        }
        public static IWebElement Summary_MembershipCard_Number()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Summary_MembershipCard_Number);
        }
        public static IWebElement Summary_MembershipCard_SinceDate()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Summary_MembershipCard_SinceDate);
        }
        public static IWebElement Summary_MembershipCard_Close()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Summary_MembershipCard_Close);
        }
    }
}
