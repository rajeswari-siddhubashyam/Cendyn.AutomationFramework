using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_Profile : Setup
    {
        private static string PageName = Constants.Profile;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement Profile_Client()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_Client";
            return PageAction.Find_ElementId(ObjectRepository.Profile_Client);
        }

        public static IWebElement Profile_Sub_Client()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_Sub_Client";
            return PageAction.Find_ElementId(ObjectRepository.Profile_Sub_Client);
        }
        public static IWebElement Profile_Sub_Client_SearchField()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_Sub_Client";
            return PageAction.Find_ElementId(ObjectRepository.Profile_Sub_Client_SearchField);
        }

        public static IWebElement Profile_Company()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_Company";
            return PageAction.Find_ElementId(ObjectRepository.Profile_Company);
        }

        public static IWebElement Profile_SearchGuestsTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_SearchGuestsTab";
            return PageAction.Find_ElementId(ObjectRepository.Profile_SearchGuestsTab);
        }

        public static IWebElement Profile_AddGuestsTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsTab);
        }

        public static IWebElement Profile_UnsubscribesTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_UnsubscribesTab);
        }

        public static IWebElement Profile_MergeGuestRecordsTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_MergeGuestRecordsTab);
        }

        public static IWebElement Profile_SearchGuestsSearchExpression()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_SearchGuestsSearchExpression";
            return PageAction.Find_ElementId(ObjectRepository.Profile_SearchGuestsSearchExpression);
        }

        public static IWebElement Profile_SearchGuestsSearchBy()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_SearchGuestsSearchBy";
            return PageAction.Find_ElementId(ObjectRepository.Profile_SearchGuestsSearchBy);
        }

        public static IWebElement Profile_SearchGuestsSearchFor()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_SearchGuestsSearchFor";
            return PageAction.Find_ElementId(ObjectRepository.Profile_SearchGuestsSearchFor);
        }

        public static IWebElement Profile_SearchGuestsSearch()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_SearchGuestsSearch);
        }

        public static IWebElement Profile_SearchGuestsCancel()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_SearchGuestsCancel";
            return PageAction.Find_ElementId(ObjectRepository.Profile_SearchGuestsCancel);
        }

        public static IWebElement Profile_SearchByCustomerPresent(string value)
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_SearchByCustomerPresent.Replace("#CustomerID#", value));
        }

        public static IWebElement Profile_SearchGuestsFirstResult()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_SearchGuestsFirstResult);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileTab";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileTab);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestTab);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileCreateNewSourceRb()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileCreateNewSourceRb";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileCreateNewSourceRb);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileCreateNewSourceName()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileCreateNewSourceName";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileCreateNewSourceName);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileCreateNewSourceSubmit()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileCreateNewSourceSubmit";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileCreateNewSourceSubmit);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileCreateNewSourceReset()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileCreateNewSourceReset";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileCreateNewSourceReset);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileUpdateExistingSourceRb()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileUpdateExistingSourceRb";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsUploadNewFileUpdateExistingSourceRb);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileUpdateExistingSourceName()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileUpdateExistingSourceName";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileUpdateExistingSourceName);
        }
        public static IWebElement Profile_AddGuestsUploadNewFileUpdateExistingSourceName_SelectSource(string sourceID)
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileUpdateExistingSourceName";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsUploadNewFileUpdateExistingSourceName_SelectSource.Replace("#SourceID#", sourceID));
        }

        public static IWebElement Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit);
        }

        public static IWebElement Profile_AddGuestsUploadNewFileUpdateExistingSourceReset()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsUploadNewFileUpdateExistingSourceReset";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsUploadNewFileUpdateExistingSourceReset);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestPrefix()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestPrefix";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsManuallyAddGuestPrefix);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestFirstName()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestFirstName";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestFirstName);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestLastName()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestLastName";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestLastName);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestAddress1()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestAddress1";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestAddress1);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestAddress2()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestAddress2";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestAddress2);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestCity()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestCity";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestCity);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestState()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestState";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestState);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestZip()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestZip";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestZip);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestCountryCode()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestCountryCode";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestCountryCode);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestNewSourceNameRb()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestNewSourceNameRb";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsManuallyAddGuestNewSourceNameRb);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestNewSourceNameText()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestNewSourceNameText";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsManuallyAddGuestNewSourceNameText);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestExistingSourceRb()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestExistingSourceRb";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsManuallyAddGuestExistingSourceRb);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestExistingSourceDropdown()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestExistingSourceDropdown";
            return PageAction.Find_ElementId(ObjectRepository.Profile_AddGuestsManuallyAddGuestExistingSourceDropdown);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestEmail()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestEmail";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestEmail);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestCompany()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestCompany";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestCompany);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestTitle()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestTitle";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestTitle);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestWorkPhone()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestWorkPhone";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestWorkPhone);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestWorkExt()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestWorkExt";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestWorkExt);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestFax()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestFax";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestFax);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestMobile()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestMobile";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestMobile);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestHome()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestHome";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestHome);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestSourceOfBusiness()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestSourceOfBusiness";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestSourceOfBusiness);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestNext()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestNext";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestNext);
        }

        public static IWebElement Profile_AddGuestsManuallyAddGuestReset()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_AddGuestsManuallyAddGuestReset";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_AddGuestsManuallyAddGuestReset);
        }

        public static IWebElement Profile_UnsubscribesFileUploadTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesFileUploadTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_UnsubscribesFileUploadTab);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_UnsubscribesOneAtATimeTab);
        }

        public static IWebElement Profile_UnsubscribesFileUploadSearchUnsubscribedTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesFileUploadSearchUnsubscribedTab";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_UnsubscribesFileUploadSearchUnsubscribedTab);
        }

        public static IWebElement Profile_UnsubscribesFileUploadBrowse()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesFileUploadBrowse";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_UnsubscribesFileUploadBrowse);
        }

        public static IWebElement Profile_UnsubscribesFileUploadSubmit()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesFileUploadSubmit";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesFileUploadSubmit);
        }

        public static IWebElement Profile_UnsubscribesFileUploadCancel()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesFileUploadCancel";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesFileUploadCancel);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeEmail()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeEmail";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesOneAtATimeEmail);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeProjectId()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeProjectId";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesOneAtATimeProjectId);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeMethod()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeMethod";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesOneAtATimeMethod);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeComments()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeComments";
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_UnsubscribesOneAtATimeComments);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeSubmit()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeSubmit";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesOneAtATimeSubmit);
        }

        public static IWebElement Profile_UnsubscribesOneAtATimeCancel()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesOneAtATimeCancel";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesOneAtATimeCancel);
        }

        public static IWebElement Profile_UnsubscribesSearchUnsubscribedSearchExpression()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesSearchUnsubscribedSearchExpression";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesSearchUnsubscribedSearchExpression);
        }

        public static IWebElement Profile_UnsubscribesSearchUnsubscribedSearchBy()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesSearchUnsubscribedSearchBy";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesSearchUnsubscribedSearchBy);
        }

        public static IWebElement Profile_UnsubscribesSearchUnsubscribedSearchFor()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesSearchUnsubscribedSearchFor";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesSearchUnsubscribedSearchFor);
        }

        public static IWebElement Profile_UnsubscribesSearchUnsubscribedSearch()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesSearchUnsubscribedSearch";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesSearchUnsubscribedSearch);
        }

        public static IWebElement Profile_UnsubscribesSearchUnsubscribedCancel()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_UnsubscribesSearchUnsubscribedCancel";
            return PageAction.Find_ElementId(ObjectRepository.Profile_UnsubscribesSearchUnsubscribedCancel);
        }

        public static IWebElement Profile_MergeGuestRecordsManualMergeTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeTab";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeTab);
        }

        public static IWebElement Profile_MergeGuestRecordsPotentialMergeTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsPotentialMergeTab";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsPotentialMergeTab);
        }

        public static IWebElement Profile_MergeGuestRecordsMergeHistoryTab()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsMergeHistoryTab";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsMergeHistoryTab);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeFirstName()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeFirstName";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeFirstName);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeLastName()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeLastName";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeLastName);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeEmail()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeEmail";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeEmail);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeZipCode()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeZipCode";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeZipCode);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeCity()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeCity";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeCity);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeState()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeState";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeState);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeCompany()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeCompany";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeCompany);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeSalutation()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeSalutation";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeSalutation);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeSearchGuest()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeSearchGuest";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeSearchGuest);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeCancel()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeCancel";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeCancel);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeAddToMergeProcess()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeAddToMergeProcess";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeAddToMergeProcess);
        }
        public static IWebElement Profile_MergeGuestRecordsManualMergeRecordsToMerge()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeRecordsToMerge";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeRecordsToMerge);
        }

        public static IWebElement Profile_MergeGuestRecordsManualMergeCompare()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_MergeGuestRecordsManualMergeCompare";
            return PageAction.Find_ElementId(ObjectRepository.Profile_MergeGuestRecordsManualMergeCompare);
        }

        public static IWebElement Profile_CustomerProfileImage()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_CustomerProfileImage);
        }
        public static IWebElement Profile_CampaignHistory()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_CampaignHistory);
        }
        public static IWebElement Profile_StayTab(string customerID)
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_StayTab.Replace("#CustomerID#", customerID));
        }
        public static IWebElement Profile_StayTabReservationPresent(string customerID, string resNum)
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_StayTabReservationPresent.Replace("#CustomerID#", customerID).Replace("#ReservationNum#", resNum));
        }

        public static IWebElement Profile_RevenueDetails()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_RevenueDetails);
        }

        public static IWebElement Resend_Client()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = "Profile_Client";
            return PageAction.Find_ElementId(ObjectRepository.Profile_Select_CampaignName);
        }

        public static IWebElement Profile_Grid_ReservationNumber(string ResNum)
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_Grid_ReservationNumber.Replace("#ReservationNumber#",ResNum));
        }
        public static IWebElement Profile_Grid_CampaignHistory_NumberofRows(string customerID, string optionValue)
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_Grid_CampaignHistory_NumberofRows.Replace("#CustomerID#", customerID).Replace("#Option#", optionValue));
        }

    }
}