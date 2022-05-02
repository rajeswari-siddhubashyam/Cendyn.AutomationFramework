using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Config.Entity
{
    public class AccountLocalization
    {
        public string AccountID { set; get; }
        public string TimeZone { set; get; }
        public string DefaultDateFormat { set; get; }
        public string CurrencyCode { set; get; }
        public string CurrencySymbol { set; get; }
        public string DefaultLanguage { set; get; }
    }
   
}
