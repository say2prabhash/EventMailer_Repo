using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office;
using Microsoft.Vbe.Interop;
using System.Runtime.InteropServices;
using Bytescout.Spreadsheet;
//using Excel = Microsoft.Office.Interop.Excel;
namespace EventMailer
{
   
    class DataRetriever
    {
        Dictionary<string, string> birthdayData;
        Dictionary<string, Dictionary<string,string>> anniversaryData;
        public DataRetriever()
        {
            birthdayData = new Dictionary<string, string>();
        }
        public Dictionary<string,string> RetrieveBirthdayData()
        {
            Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile(@"C:\\Users\\User\\Desktop\\EmployeeData.xls");
            Worksheet worksheet = sheet.Workbook.Worksheets.ByName("Sheet1");
            return birthdayData;
        }
        public Dictionary<string,Dictionary<string,string>> RetrieveAnniversaryData()
        {
            return anniversaryData;
        }
    }
}
