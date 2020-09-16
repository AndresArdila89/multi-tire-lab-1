using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //required for ADO.net object model


namespace Lab1_ConnectedMode2.DAL
{
    public static class UtilityDB
    {

        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = "server=192.168.50.138;database=EmployeeDB;user=sa;password=Ing753951;";
            connDB.Open();


            return connDB;
        }
    }
}
