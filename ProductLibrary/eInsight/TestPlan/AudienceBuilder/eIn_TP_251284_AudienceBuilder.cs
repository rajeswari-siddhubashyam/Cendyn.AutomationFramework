//using System;
//using NUnit.Framework;
//using eInsight.AppModule.MainAdminApp;
//using BaseUtility.Utility;
//using eInsight.AppModule.UI;
//using System.Text.RegularExpressions;
//using InfoMessageLogger;
//using Constants = eInsight.Utility.Constants;
//using LegacyTestData = eInsight.Utility.LegacyTestData;

//namespace eInsightAudienceBuilder
//{
//    [TestFixture]
//    public class eIn_TP_251284_AudienceBuilder : eInsight.Utility.Setup
//    {
//        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;

//        [OneTimeSetUp]
//        public static void Initialize()
//        {
//            TestPlanId = Constants.TP_251284;

//            //Initialize the test case set up.
//            InitializeSetup(TestPlanId,GetProjectName);

//            //Assign the test data test plan file location
//            //TestDataFile = TestDataLocation.TP_251284;

//            AddDelay(8000);
//        }
		
//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_247443()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_247443);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_247443);
				
//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_247441()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_247441);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_247441);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_247442()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_247442);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_247442);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_248180()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_248180);

//                Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_248180);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_247444()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_247444);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_247444);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_235577()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_235577);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_235577);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_240348()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_240348);

//                Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_240348);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_240349()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_240349);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_240349);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_240351()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_240351);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_240351);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_240346()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_240346);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_240346);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//        public static void TC_236448()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_236448);

//                Logger.DeleteOldFolder();

//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_236448);

//					RenewDriver();
//				}


//				/**Test execution - End**/
//				TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243205()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243205);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243205);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243206()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243206);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243206);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243208()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243208);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243208);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243209()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243209);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243209);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243213()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243213);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243213);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243216()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243216);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243216);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_243217()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_243217);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_243217);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_246131()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_246131);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_246131);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_246065()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_246065);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_246065);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_246066()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_246066);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_246066);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_246067()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_246067);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_246067);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		[Category("Regression")]
//		[Test, Category("eInsight TP_251284")]
//		public static void TC_246068()
//		{
//			try
//			{
//				/**Test execution - Start**/
//				Legacy_SetupTestCase(Constants.TC_246068);

//				Logger.DeleteOldFolder();
//				string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
//				foreach (string frontendURL in eachFrontEndURL)
//				{
//					Login.CommonLogin(frontendURL);

//					//Start
//					MainAdminApp.TP_251284(Constants.TC_246068);

//					RenewDriver();
//				}

//				/**Test execution - End**/
//				TestHandling.TestEnd();
//			}
//			catch (Exception e)
//			{
//				TestHandling.TestFailed(e);
//				throw;
//			}
//		}

//		/// <summary>
//		/// Method is executed after every Test Script.
//		/// </summary>
//		[TearDown]
//        public void Close()
//        {
//            TestHandling.TearDown();
//        }
//    }
//}
