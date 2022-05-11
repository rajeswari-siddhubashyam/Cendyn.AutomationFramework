using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CMS.Utility
{
    class ObjectRepository
    {


        #region[SignIn]
        public static string SignIn_Email { get; set; }
        public static string SignIn_Password { get; set; }
        public static string SignIn_Submit { get; set; }
        #endregion[SignIn]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements().ToDictionary(x => x.Attribute("key").Value, x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Login]

                if (nodeModule == Constants.SignIn)
                {
                    if (pair.Key == "SignIn_Email")
                        SignIn_Email = pair.Value;
                    else if (pair.Key == "SignIn_Password")
                        SignIn_Password = pair.Value;
                    else if (pair.Key == "SignIn_Submit")
                        SignIn_Submit = pair.Value;
                }

                #endregion[Login]

            }
            return obj;
        }
    }
}
