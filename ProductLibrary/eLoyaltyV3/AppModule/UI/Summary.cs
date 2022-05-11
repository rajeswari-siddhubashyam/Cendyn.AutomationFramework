using BaseUtility.Utility;
using eLoyaltyV3.PageObject.UI;
using NUnit.Framework;

namespace eLoyaltyV3.AppModule.UI
{
    public class Summary
    {
        public static string Get_MembershipNo(string ProjectName)
        {
            string membershipNo = PageObject_Summary.Text_MembershipNo(ProjectName).GetAttribute("innerHTML");
            return membershipNo;
        }

        public static string Get_MembershipType()
        {
            string membershipType = PageObject_Summary.Text_MembershipType().GetAttribute("innerHTML");
            return membershipType;
        }
        public static void CheckMembershipCard(string name, string membershipId, string memberSince)
        {
            //Navigation.Click_MembershipCard();

            if (PageObject_Summary.Summary_MembershipCard_Name().GetAttribute("innerHTML") != name)
                Assert.Fail("Membership Card Name does not match user");
            else
                InfoMessageLogger.Logger.WriteInfoMessage("Name displayed on Membership Card matches name from DB (" + name + ").");

            if (PageObject_Summary.Summary_MembershipCard_Number().GetAttribute("innerHTML") != membershipId)
                Assert.Fail("Membership Card Number does not match user");
            else
                InfoMessageLogger.Logger.WriteInfoMessage("Membership Card Number displayed on Membership Card matches number from DB (" + membershipId + ").");

            if (PageObject_Summary.Summary_MembershipCard_SinceDate().GetAttribute("innerHTML").Substring(14) != (memberSince.Substring(0, memberSince.IndexOf(" "))))
                Assert.Fail("Membership Card Member Since Date does not match user");
            else
                InfoMessageLogger.Logger.WriteInfoMessage("Member Since date displayed on Membership Card matches date from DB (" + memberSince + ").");
            Helper.ScrollDownUsingJavaScript(Helper.Driver, 600);
            InfoMessageLogger.Logger.WriteDebugMessage("All Membership Card information matches user data.");

         //   Navigation.Click_MembershipCard_Close();
        }


    }
}
