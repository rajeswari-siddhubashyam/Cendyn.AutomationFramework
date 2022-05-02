using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLoyaltyV3.Entity
{
    public class UserCredential
    {
        public string member_id { get; set; }
        public string login_id { get; set; }
        public string profile_password { get; set; }
        public string profile_email { get; set; }
    }
}
