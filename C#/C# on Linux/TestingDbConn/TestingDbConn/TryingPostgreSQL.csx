using System;
using System.Data.OleDb;

string ConnStr = null;
ConnStr = "Provider=PostgreSQL OLE DB Provider;Data Source=localhost;location=analysis;User ID=postgres;password=postgres;timeout=1000;";
OleDbConnection DBConn = new OleDbConnection(ConnStr);
Console.WriteLine("Connected to DB!");
