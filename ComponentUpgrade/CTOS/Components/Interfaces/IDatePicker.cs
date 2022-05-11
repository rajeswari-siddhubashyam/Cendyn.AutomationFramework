using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CTOS.Models
{
    public interface IDatePicker
    {
        void OpenCalendar();
        bool IsCalendarOpen();
        void SetDateByInput(DateTime datetime);
        void SetDateByGUI(DateTime datetime);
    }
}
