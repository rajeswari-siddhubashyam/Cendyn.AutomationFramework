using System;
using System.IO;
using System.Net;
using System.Text;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Interactions;
using Common;
using NUnit.Framework;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.UI
{
    class CRMAPI
    {

        public static void PostAPIRequest(string togglePoint, string postJSON, string casetype)
        {
            dynamic result;
            CRMAPIInfo cred = new CRMAPIInfo();
            Queries.GetCredentialsAndMasterPropertyCode(cred);

            //string getPropertyCode = ExcelData.ExcelDataReader.GetMasterPropertyCode(projectName);
            
            switch (togglePoint)
            {
                case "Login":
                    {
                        cred.CRMAPIURL = cred.CRMAPIURL.Replace("/Register", "/Login");
                        WebRequest myReq = WebRequest.Create(cred.CRMAPIURL);
                        myReq.Method = "POST";
                        myReq.ContentLength = postJSON.Length;
                        myReq.ContentType = "application/json; charset=UTF-8";

                        UTF8Encoding enc = new UTF8Encoding();

                        myReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(enc.GetBytes(cred.Credentials)));

                        using (Stream ds = myReq.GetRequestStream())
                        {
                            ds.Write(enc.GetBytes(postJSON), 0, postJSON.Length);
                        }

                        WebResponse wr = myReq.GetResponse();
                        Stream receiveStream = wr.GetResponseStream();
                        StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
                        string content = reader.ReadToEnd();
                        result = JObject.Parse(content);
                        Logger.WriteInfoMessage("Case type: " + casetype +"\n Sign for \n" + postJSON + "\n was " + result.result_code + " - " + result.result_text);
                        break;
                    }
                case "Register":
                    {
                        WebRequest myReq = WebRequest.Create(cred.CRMAPIURL);
                        myReq.Method = "POST";
                        myReq.ContentLength = postJSON.Length;
                        myReq.ContentType = "application/json; charset=UTF-8";

                        UTF8Encoding enc = new UTF8Encoding();

                        myReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(enc.GetBytes(cred.Credentials)));

                        using (Stream ds = myReq.GetRequestStream())
                        {
                            ds.Write(enc.GetBytes(postJSON), 0, postJSON.Length);
                        }

                        WebResponse wr = myReq.GetResponse();
                        Stream receiveStream = wr.GetResponseStream();
                        StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
                        string content = reader.ReadToEnd();
                        result = JObject.Parse(content);

                        Logger.WriteInfoMessage("Case type: " + casetype +"\n Signed Up with \n" + postJSON + "\n with  response body " +  result.result_code + " " + result.result_text);
                        if (result.result_code != 200)
                        {
                            Assert.Fail("Did not signed up successfully for \n" + postJSON );
                        }
                        break;
                    }
            }
        }

        private static void Click_Explore()
        {
            Helper.ElementClick(PageObject_CRMAPI.CRMAPI_btnExplore());
        }
        public static void CRMAPI_AccLogin(int functiontype, string Casetype_Email, string Casetype_Password, string caseType)
        {
            UserCredential data = new UserCredential();
            Queries.ReturnLoyaltyUserLoginCredentials(data, Casetype_Email, Casetype_Password);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            PostAPIRequest("Login", json, caseType);
            string ReturnResult;
        }

         public static string FormatJsonData(UserSignUpCRMAPI lstCustData)
        {
            string json;
            json = JsonConvert.SerializeObject(lstCustData, Formatting.Indented);
            return json;
        }
    }
}
