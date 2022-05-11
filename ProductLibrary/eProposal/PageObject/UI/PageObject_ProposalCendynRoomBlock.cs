using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_ProposalCendynRoomBlock : Setup
    {
        private static readonly string PageName = Constants.ProposalCendynRoomBlock;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static IWebElement Button_Back()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynRoomBlock_Button_Back);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCendynRoomBlock_Button_Next);
        }


        public static IWebElement CheckBox_IncludeRoomBlockInProposal()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_CheckBox_IncludeRoomBlockInProposal);
        }

        public static IWebElement CheckBox_AddIntroductionToRoomBlock()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_CheckBox_AddIntroductionToRoomBlock);
        }

        public static IWebElement Text_RoomBlockIntroductionText()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_RoomBlockIntroductionText);
        }

        public static IWebElement Text_RoomBlock_Category()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Category);
        }

        public static IWebElement Text_RoomBlock_RoomType1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_RoomType1);
        }

        public static IWebElement Text_RoomBlock_RoomType2()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_RoomType2);
        }

        public static IWebElement Text_RoomBlock_RoomType3()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_RoomType3);
        }

        public static IWebElement Text_RoomBlock_RoomType4()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_RoomType4);
        }

        public static IWebElement Text_RoomBlock_Qty1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Qty1);
        }

        public static IWebElement Text_RoomBlock_Qty2()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Qty2);
        }

        public static IWebElement Text_RoomBlock_Qty3()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Qty3);
        }

        public static IWebElement Text_RoomBlock_Qty4()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Qty4);
        }

        public static IWebElement Text_RoomBlock_Rate1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Rate1);
        }

        public static IWebElement Text_RoomBlock_Rate2()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Rate2);
        }

        public static IWebElement Text_RoomBlock_Rate3()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Rate3);
        }

        public static IWebElement Text_RoomBlock_Rate4()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Rate4);
        }

        public static IWebElement Button_RoomBlock_Copy1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_Copy1);
        }

        public static IWebElement Button_RoomBlock_Copy2()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_Copy2);
        }

        public static IWebElement Button_RoomBlock_Copy3()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_Copy3);
        }

        public static IWebElement Button_RoomBlock_Copy4()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_Copy4);
        }

        public static IWebElement Button_RoomBlock_ClearData1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_ClearData1);
        }

        public static IWebElement Button_RoomBlock_ClearData2()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_ClearData2);
        }

        public static IWebElement Button_RoomBlock_ClearData3()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_ClearData3);
        }

        public static IWebElement Button_RoomBlock_ClearData4()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_ClearData4);
        }

        public static IWebElement Button_RoomBlock_Submit()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_Submit);
        }

        public static IWebElement Button_RoomBlock_Cancel()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_Cancel);
        }

        public static IWebElement Button_RoomBlock_AddNewCategory()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(
                ObjectRepository.ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory);
        }

        public static IWebElement Button_RoomBlock_AddNewCategory_Copy()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Copy);
        }

        public static IWebElement Button_RoomBlock_AddNewCategory_ClearData()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_ClearData);
        }

        public static IWebElement Button_RoomBlock_AddNewCategory_Save()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Save);
        }

        public static IWebElement Button_RoomBlock_AddNewCategory_Cancel()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Cancel);
        }

        public static IWebElement Text_RoomBlock_AddNewCategory_Type()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Type);
        }

        public static IWebElement Text_RoomBlock_AddNewCategory_Qty()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Qty);
        }

        public static IWebElement Text_RoomBlock_AddNewCategory_Rate()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Rate);
        }

        public static IWebElement Button_AddAdditionalOptions()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Button_AddAdditionalOptions);
        }

        public static IWebElement Text_AddAdditionalOptions_DateRangeAdditionalHotel()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_AddAdditionalOptions_DateRangeAdditionalHotel);
        }

        public static IWebElement Text_AddAdditionalOptions_Category1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_AddAdditionalOptions_Category1);
        }

        public static IWebElement Text_AddAdditionalOptions_Rate1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(
                ObjectRepository.ProposalCendynRoomBlock_Text_AddAdditionalOptions_Rate1);
        }

        public static IWebElement Text_AddAdditionalOptions_Comments1()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Text_AddAdditionalOptions_Comments1);
        }

        public static IWebElement Button_AddAdditionalOptions_Submit()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Button_AddAdditionalOptions_Submit);
        }

        public static IWebElement Button_AddAdditionalOptions_Cancel()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .ProposalCendynRoomBlock_Button_AddAdditionalOptions_Cancel);
        }

        public static IWebElement Text_RoomBlock_Comments()
        {
            ScanPage(Constants.ProposalCendynRoomBlock);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCendynRoomBlock_Text_RoomBlock_Comments);
        }
    }
}