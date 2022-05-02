using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWarehouse
{
    public class ClientdbConnection
    {
        public string ServerName { get; set; }
        public string DatabasName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConnectonString { get; set; }
        public string ParentCompanyName { get; set; }
        public string CompanyName { get; set; }
    }    
}
