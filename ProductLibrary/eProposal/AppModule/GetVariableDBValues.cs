using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlWarehouse;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp
    {
        private static string userName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "userName");
        private static string year = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "year");
        private static string startMonth = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "startMonth");
        private static string startYear = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "startYear");
        private static string startDate = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "startDate");
        private static string endMonth = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "endMonth");
        private static string endYear = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "endYear");
        private static string endDate = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "endDate");
        private static string propertyLevel = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "PropertyLevel");
        private static string loginEmail = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "LoginEmail");
        private static string loginPassword = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "LoginPassword");
        private static string searchName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "SearchName");
        private static string propertyName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "PropertyName");
        private static string eproposalName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "eProposalName");
        private static string singleLanguageProperty = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "SingleLanguageProperty");
        private static string linkName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "LinkName");
        private static string employeeEmail = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EmployeeEmail");
        private static string emailSubject = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EmailSubject");
        private static string password = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Password");
        private static string skinName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Skinname");
        private static string clientSearch = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ClientSearch");
        private static string uniqueEmail = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "UniqueEmail");
        private static string firstName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "FirstName");
        private static string lastName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "LastName");
        private static string company = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Company");
        private static string email = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Email");
        private static string phone = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Phone");
        private static string address = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Address,");
        private static string city = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "City");
        private static string state = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "State");
        private static string zip = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Zip");
        private static string country = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Country");
        private static string Hilton1 = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Hilton1");
        private static string ClientLogin = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ClientLogin");
        private static string ClientPassword = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ClientPassword");

    }
}
