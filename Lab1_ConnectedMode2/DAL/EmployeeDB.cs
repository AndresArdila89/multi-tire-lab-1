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
            cmd.CommandText = $"INSERT INTO Employees (FirstName, LastName, JobTitle) VALUES('{emp.FirstName}','{emp.LastName}','{emp.JobTitle}')";
            cmd.ExecuteNonQuery();
      
            connDB.Close();
        }

        public static List<Employee> LoadAllRecords()
        {
            List<Employee> empList = new List<Employee>();
            

            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = $"SELECT * FROM Employees";
            
            SqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                Employee empTemp = new Employee();
                empTemp.EmployeeId = (int)result[0];
                empTemp.FirstName = (string)result[1];
                empTemp.LastName = (string)result[2];
                empTemp.JobTitle = (string)result[3];


                empList.Add(empTemp);
            }

            connDB.Close();

            return empList;
        }
    }
} 
