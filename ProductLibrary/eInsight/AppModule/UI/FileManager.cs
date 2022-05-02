using System;
using System.Collections.Generic;
using System.Linq;
using AutoIt;
using Common;
using BaseUtility.Utility;
using eInsight.PageObject.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using SqlWarehouse;
using System.IO;
using System.Reflection;
using ClosedXML.Excel;
using OpenQA.Selenium.Remote;
using Microsoft.Office.Interop.Excel;

namespace eInsight.AppModule.UI
{
    class FileManager : Helper
    {
        public static void converttoCSV()
        {
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "");

            string filelocation = @"\TestData\csv\GuestProfile.xlsx";
            string toFileLocation = @"\TestData\csv\GuestProfile.csv";
            string location = rootPath + filelocation;
            string Tolocation = rootPath + toFileLocation;

            Application app = new Application();
            Workbook wb = app.Workbooks.Open(location, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // this does not throw exception if file doesnt exist
            if (File.Exists(Tolocation))
            {
                File.Delete(Tolocation);
            }

            wb.SaveAs(Tolocation, XlFileFormat.xlCSVWindows, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlExclusive, XlSaveConflictResolution.xlLocalSessionChanges, false, Type.Missing, Type.Missing, Type.Missing);

            wb.Close(false, Type.Missing, Type.Missing);

            app.Quit();
        }
        public static void UploadDummyData(string pathfile, AnnonymizedData dummydata)
        {
            XLWorkbook workbook = new XLWorkbook(pathfile);
            IXLWorksheet worksheet = workbook.Worksheet("GuestProfile");

            int lastrow = worksheet.LastRowUsed().RowNumber();

            worksheet.Cell(String.Format("B{0}", lastrow)).Value = dummydata.FirstName;
            worksheet.Cell(String.Format("C{0}", lastrow)).Value = dummydata.LastName;
            worksheet.Cell(String.Format("D{0}", lastrow)).Value = dummydata.Address1;
            worksheet.Cell(String.Format("E{0}", lastrow)).Value = dummydata.Address2;
            worksheet.Cell(String.Format("F{0}", lastrow)).Value = dummydata.City;
            worksheet.Cell(String.Format("G{0}", lastrow)).Value = dummydata.StateProvinceCode;
            worksheet.Cell(String.Format("H{0}", lastrow)).Value = dummydata.ZipCode;
            worksheet.Cell(String.Format("I{0}", lastrow)).Value = dummydata.Country;
            worksheet.Cell(String.Format("J{0}", lastrow)).Value = dummydata.HomePhone;
            worksheet.Cell(String.Format("L{0}", lastrow)).Value = dummydata.HomePhone;
            worksheet.Cell(String.Format("M{0}", lastrow)).Value = dummydata.CellPhone;
            worksheet.Cell(String.Format("T{0}", lastrow)).Value = dummydata.Email;
            worksheet.Cell(String.Format("U{0}", lastrow)).Value = dummydata.Country;

            workbook.Save();
            converttoCSV();
        }
    }
}
