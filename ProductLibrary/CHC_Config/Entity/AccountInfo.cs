using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Config.Entity
{
    public class AccountInfo
    {
        public string AccountID { set; get; }
        public string AccountParentID { set; get; }
        public string BillingReference { set; get; }
        public string ManagementCompany { set; get; }     
        public string Name { set; get; }
        public string PropertyType { set; get; }
        public string ReleaseMode { set; get; }
        public string Status { set; get; }

        public string Chain { set; get; }
        public string Brand { set; get; }
        public string Address { set; get; }
        public string DateAdded { set; get; }
      
    }
}
