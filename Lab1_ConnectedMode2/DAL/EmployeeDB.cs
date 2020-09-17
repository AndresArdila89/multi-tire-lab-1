using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Required for SqlServer Database
using System.Windows.Forms;
using Lab1_ConnectedMode2.BLL;

namespace Lab1_ConnectedMode2.DAL
{
    public static class EmployeeDB
    {
       public static void SaveRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = $"INSERT INTO Employees VALUES('{emp.EmployeeId}', '{emp.FirstName}','{emp.LastName}','{emp.JobTitle}')";
            cmd.ExecuteNonQuery();
            connDB.Close();
        }
    }
}
