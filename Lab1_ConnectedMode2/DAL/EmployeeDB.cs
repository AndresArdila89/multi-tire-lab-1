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
        static SqlConnection connDB;

        //The prepareQuery function establishes the connection to the database, recives the query and returns and SqlCommand Object.
        private static SqlCommand prepareQuery(string query)
        {
            connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = query;

            return cmd;
        }


       public static void SaveRecord(Employee emp)
        {

            //string query = $"INSERT INTO Employees (FirstName, LastName, JobTitle) VALUES('{emp.FirstName}','{emp.LastName}','{emp.JobTitle}')";
            //SqlCommand cmd = prepareQuery(query);
            // ExecuteNonQuery method is used when no value is return from the database for example inserting a row.

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Employees(EmployeeId, FirstName, LastName,JobTitle) VALUES (@EmployeeId,@FirstName,@LastName,@JobTitle)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmdInsert.Connection = conn;
            cmdInsert.ExecuteNonQuery();

            connDB.Close();
        }



        public static void DeleteRecord(Employee emp)
        {
            string query = $"DELETE FROM Employees WHERE EmployeeId = {emp.EmployeeId} ";
            SqlCommand cmd = prepareQuery(query);

            cmd.ExecuteNonQuery();
            connDB.Close();

        }

        public static void UpdateRecord(Employee emp)
        {
            string query = $"UPDATE Employees SET FirstName = '{emp.FirstName}', LastName = '{emp.LastName}', JobTitle = '{emp.JobTitle}' WHERE EmployeeId = {emp.EmployeeId}";
            SqlCommand cmd = prepareQuery(query);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

   


        public static List<Employee> LoadAllRecords(string extQuery)
        {
            string query = $"SELECT * FROM Employees" + extQuery;
            SqlCommand cmd = prepareQuery(query);
            
            // ExecuteReader is used to execute the query, it returns a SqlDataReader object which contains the data from the table employees inside the database.
            SqlDataReader result = cmd.ExecuteReader();
            List<Employee> empList = new List<Employee>();

            // The read metod is use to look inside the SqlDataReader object and assign its values to and object employee
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
