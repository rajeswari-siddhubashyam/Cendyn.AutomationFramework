using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLoyaltyV3.Entity
{
    public class UserSignUpCRMAPI
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string login_id { get; set; }
        public string Password { get; set; }
        public string Salutation { get; set; }
        public string language { get; set; }
        public string date_of_birth { get; set; }
        public string HasMembership { get; set; }
        public string NeedActivate { get; set; }
        public string NewsletterSubscription { get; set; }
    }
}
