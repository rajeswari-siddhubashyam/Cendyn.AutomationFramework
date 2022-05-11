//using BaseUtility.Utility;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using System;
using eLoyaltyV3.PageObject.Admin;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_240447_Membership_Card

        public static void TC_112899()
        {
            if (TestCaseId == Constants.TC_112899)
            {
                string name, MemberShipId, MemberSinceDate;
                //Get user information
                Users data = new Users();
                Queries.GetActiveMemberMembershipCardInfo(data, ProjectName);


                name = data.firstName + " " + data.lastName;
                MemberShipId = data.MemberShipId;
                MemberSinceDate = data.MemberSinceDate;

                //Log in
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);

                //Access MembershipCard on Main Page
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to stays and check membership card
                Navigation.Click_Link_MyStays2();
                Logger.WriteInfoMessage("Landed on My Stays page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to Benefits and check membership card
                Navigation.Click_Link_Benefits();
                Logger.WriteInfoMessage("Landed on Benefits page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to Awards and check membership card
                Navigation.Click_Link_MyAward();
                Logger.WriteInfoMessage("Landed on Awards page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to Redeem and check membership card
                Navigation.Click_Link_Redeem();
                Logger.WriteInfoMessage("Landed on Redeem page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to Offers and check membership card
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteInfoMessage("Landed on Special Offers page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to Contact and check membership card
                Navigation.Click_Link_ContactUs(ProjectName);
                Logger.WriteInfoMessage("Landed on Contact page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to My Account/My Settings and check membership card
                Navigation.Click_Link_MyAccount();
                Logger.WriteInfoMessage("Landed on My Account page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                //Navigate to Invite Friends and check membership card
                Navigation.Click_Link_InviteFriends();
                Logger.WriteInfoMessage("Landed on Invite Friends page.");
                Summary.CheckMembershipCard(name, MemberShipId, MemberSinceDate);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User - Full Name: ", name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User - Membership ID: ", MemberShipId);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User - Member Since Date: ", MemberSinceDate, true);
            }
        }


        public static void TC_113079()
        {
            if (TestCaseId == Constants.TC_113079)
            {

            }
        }




        #endregion TP_218533
    }
}