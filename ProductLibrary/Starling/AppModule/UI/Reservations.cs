using BaseUtility.PageObject;
using BaseUtility.Utility;
using CHC.Entity;
using CHC.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CHC.AppModule.UI
{
    public class Reservations : Helper
    {
        //public static void Enter_ReservationID_On_serachbox()
        //{
        //    //ElementClick(PageObject_Reservations.Search_ReservationID());
        //    //Logger.WriteDebugMessage("View Profile page should display");
        //    //Helper.WaitForAjaxControls(30);
        

        public static void Enter_txt_on_Filter_ReservationID_On_searchbox(Reservation_DB reservation)
        {
            int reservationid = reservation.ExternalResID1;
            Helper.WaitForAjaxControls(30);
            WaittillElementDisplay(PageObject_Reservations.Search_ReservationID());
            ElementEnterText(PageObject_Reservations.Search_ReservationID(), reservationid.ToString());
            Logger.WriteDebugMessage("User enter the " + reservationid + " in Search text box");
            ElementClick(PageObject_Profiles.Btn_SearchIcon());
            Logger.WriteDebugMessage("User entered the " + reservationid + " and Click on Search icon");
            Helper.WaitForAjaxControls(30);
        }
    }
}

