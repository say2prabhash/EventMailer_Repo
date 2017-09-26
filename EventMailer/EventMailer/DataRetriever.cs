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
        Dictionary<string, Dictionary<string,string>> birthdayData;
        Dictionary<string, Dictionary<string,string>> anniversaryData;
        public DataRetriever()
        {
            birthdayData = new Dictionary<string, Dictionary<string, string>>();
            anniversaryData = new Dictionary<string, Dictionary<string,string>>();
        }
        public Dictionary<string, Dictionary<string,string>> RetrieveBirthdayData()
        {
            Dictionary<string, string> birthdayTemp = new Dictionary<string, string>();
            SqlConnection myConnection = new SqlConnection("Data Source=TAVDESK088;User Id=sa;Password=test123!@#;Initial Catalog=EmployeeData");
            try
            {
                myConnection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("select [Employee Name],DOB,Email from Employee", myConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    char[] separator = { ' ' };
                    string[] str = reader["DOB"].ToString().Split(separator);
                    birthdayTemp[reader["Employee Name"].ToString()] = reader["Email"].ToString();
                    birthdayData[str[0]] = birthdayTemp;
                }
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                myConnection.Close();
            }
            return birthdayData;
        }
        public Dictionary<string, Dictionary<string,string>> RetrieveAnniversaryData()
        {
            Dictionary<string, string> anniversaryTemp = new Dictionary<string, string>();
            SqlConnection myConnection = new SqlConnection("Data Source=TAVDESK088;User Id=sa;Password=test123!@#;Initial Catalog=EmployeeData");
            try
            {
                myConnection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("select [Employee Name],DOJ,Email from Employee", myConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    char[] separator = { ' ' };
                    string[] str = reader["DOJ"].ToString().Split(separator);
                    anniversaryTemp[reader["Employee Name"].ToString()] =reader["Email"].ToString();
                    anniversaryData[str[0]] = anniversaryTemp;
                }
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                myConnection.Close();
            }
            return anniversaryData;
        }
    }
}
