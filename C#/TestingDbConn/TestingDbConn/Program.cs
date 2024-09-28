using System;
using System.Data.SqlClient;

class DbProg
{
    public static void Main(string[] args)
    {
        //string ConnStr = "Server=batyr.db.elephantsql.com;Database=sosicetk;User ID=sosicetk;password=kY7FTnXP0R0ANle_7MiGcxaRxuFvndSg;";
        string ConnStr = "Server=DataSkeptic01;Database=DataSkeptic;integrated security=SSPI;";
        using (SqlConnection  DBConn = new SqlConnection (ConnStr)){
            DBConn.Open();
            Console.WriteLine("Connected to DB!");
            Console.WriteLine("Database: " + DBConn.Database); // DBConn.Database
            using (SqlCommand DBCmd = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", DBConn)) {
                using (SqlDataReader DBReader = DBCmd.ExecuteReader()) {
                    while (DBReader.Read()) {
                        Console.WriteLine(DBReader["TABLE_NAME"]);
                    }
                }
            }
            DBConn.Close();
        }
    }
}