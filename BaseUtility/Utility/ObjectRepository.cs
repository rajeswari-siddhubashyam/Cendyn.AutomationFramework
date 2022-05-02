using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Automation.Base.Utility
{    
    public class ObjectRepository
    {
        public static string Navigation_Link_Facebook { get; set; }
        public static string Navigation_Link_Twitter { get; set; }

        /*public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements()
              .ToDictionary(x => x.Attribute("key").Value,
                  x => x.Value);
            foreach (KeyValuePair<string, string> pair in query)
            {
                if (pair.Key == "Navigation_Link_Facebook")
                    Navigation_Link_Facebook = pair.Value;
                else if (pair.Key == "Navigation_Link_Twitter")
                    Navigation_Link_Twitter = pair.Value;
            }
            return obj;
        }*/
    }
}
