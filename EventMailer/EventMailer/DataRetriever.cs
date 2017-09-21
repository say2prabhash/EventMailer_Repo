using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Office;
using Microsoft.Vbe.Interop;
using System.Runtime.InteropServices;
using Bytescout.Spreadsheet;
using System.Data.SqlClient;
using System.Configuration;
//using Excel = Microsoft.Office.Interop.Excel;
namespace EventMailer
{
   
    public class DataRetriever
    {
        Dictionary<string, string> birthdayData;
        Dictionary<string, Dictionary<string,string>> anniversaryData;
        public DataRetriever()
        {
            birthdayData = new Dictionary<string, string>();
        }
        public Dictionary<string,string> RetrieveBirthdayData()
        {
            SqlConnection myConnection = new SqlConnection("Data Source=TAVDESK088;User Id=sa;Password=test123!@#;Initial Catalog=EmployeeData");
            try
            {
                myConnection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("select * from Employee", myConnection);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    birthdayData[reader["Employee Name"].ToString()] = reader["DOB"].ToString();
                }
            }
            catch(SqlException ex)
            {
                return null;
            }
            finally
            {
                myConnection.Close();
            }
            return birthdayData;
        }
        public Dictionary<string,Dictionary<string,string>> RetrieveAnniversaryData()
        {
            return anniversaryData;
        }
    }
}
