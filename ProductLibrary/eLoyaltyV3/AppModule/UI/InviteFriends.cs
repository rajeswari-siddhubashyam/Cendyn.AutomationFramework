using eLoyaltyV3.PageObject.UI;
using BaseUtility.Utility;

namespace eLoyaltyV3.AppModule.UI
{
    public class InviteFriends
    {
        public static void Button_SendMyInvitation()
        {
            Helper.ElementClick(PageObject_InviteFriends.Button_SendMyInvitation());
        }
        public static string InviteFriendValidation_Error()
        {
            return Helper.GetText(PageObject_InviteFriends.GetInviteMYFriend_Error());
        }
        public static void EnterText_SendInvitation(string text)
        {
            Helper.ElementEnterText(PageObject_InviteFriends.EnterText_SendInvitation(), text);
        }        
        public static string InviteFriendValidation_CaptchaError()
        {
            return Helper.GetText(PageObject_InviteFriends.InviteFriendValidation_CaptchaError());
        }

        public static string InviteFriendEmailValidation_Error()
        {
            return Helper.GetText(PageObject_InviteFriends.InviteFriendEmailValidation_Error());
        }

        public static void EnterText_SendInvitationMailContent(string text)
        {
            Helper.ElementEnterText(PageObject_InviteFriends.EnterText_SendInvitationMailContent(), text);
        }

        public static string EnterText_SendInvitationMailContent_Error()
        {
            return Helper.GetText(PageObject_InviteFriends.EnterText_SendInvitationMailContent_Error());
        }

    }
}
