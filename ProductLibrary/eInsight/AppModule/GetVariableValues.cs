using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        public static string projectID = "";
        public static string hasSubjectLine = "";
        public static string subjectName = "";
        public static string defaultText = "Allow Edit Div";
        public static string newDivText = "Template changed to text - Test JS";
        public static string regionSelection = "";
        public static string iFrameManageCampaign = "//iframe[@name='ManageCampaign']";
        public static string iFrameTemplateBuilder = "//iframe[@name='TemplateBuilder']";
    }
}
