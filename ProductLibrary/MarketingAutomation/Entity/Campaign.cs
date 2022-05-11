using System.Collections.Generic;

namespace MarketingAutomation.Entity
{
    public class Campaign
    {
        public IList<string> clientCards = new List<string>();
        
        //Campaign preview
        public string CampaignId;
        public string CampaignsCount;
        public string AudienceName;
        public string AudienceDescription;
        public string AudienceId;
        public IList<string> AudienceTagNames = new List<string>();
        public string AudienceTags;
        public string CriteriaCount;
        public string AudienceCount;
        public string AudienceUpdateDate;
        public string TemplateName;
        public string TemplateStatus;
        public string TemplateId;
        public string UpdateById;
        public IList<string> DesignTagNames = new List<string>();
        public string UserFirstName;
        public string UserLastName;
        public string CreateDate;
        public string UpdateDate;
        public string CampaignName;
        public string Status;
        public string CampaignFrequency;
        public string AudienceStatus;
    }

    public class Template
    {
        
        public string TemplateId;
        public string Unsubscribe;
        public string BrowserLink;


    }
}
