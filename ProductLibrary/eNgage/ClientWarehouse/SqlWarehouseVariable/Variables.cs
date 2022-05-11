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
    
    public class PromptsRules
    {
        public string HotelName { get; set; }
        public string Category { get; set; }
        public string CendynPropertyID { get; set; }
        public string RuleSetName { get; set; }
        public string RuleSetPriority { get; set; }
        public string RuleSetActive { get; set; }
        public string PromptText { get; set; }
        public string DisplayType { get; set; }
        public string RuleName { get; set; }
        public string ParseTree { get; set; }
        public string RulePriority { get; set; }
        public string RuleActive { get; set; }
    }
    public class PromptsResponses
    {
        public string PromptText { get; set; }
        public string CendynProfileID { get; set; }
        public string SourceProfileID { get; set; }
        public string Reaction { get; set; }
        public string Response { get; set; }
        public string DateCreated { get; set; }
        public string LastUpdated { get; set; }
        public string SSOUserID { get; set; }
    }

}
