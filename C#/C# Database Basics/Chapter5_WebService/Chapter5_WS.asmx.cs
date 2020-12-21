using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace Chapter5_WebService
{
    /// <summary>
    /// Summary description for Chapter5_WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Chapter5_WS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public System.Collections.ObjectModel.Collection<string> listTest(string thisList)
        {
            System.Collections.ObjectModel.Collection<string> holder = new System.Collections.ObjectModel.Collection<string>();
            switch (thisList)
            {
                case "First":
                    holder.Add("one");
                    holder.Add("two");
                    holder.Add("three");
                    return holder;

                case "Second":
                    holder.Add("four");
                    holder.Add("five");
                    holder.Add("six");
                    holder.Add("seven");
                    return holder;

                default:
                    holder.Add("Invalid");
                    return holder;
            }
        }
        [WebMethod]
        public DataTable getProducts(string Category)
        {
            SqlConnection sqlcn = new SqlConnection(ConfigurationManager.ConnectionStrings["WS_Data"].ConnectionString);
            DataSet ds = new DataSet();
            string sqlstr = "SELECT Product FROM tbl_Products WHERE Category = @Category";
            SqlDataAdapter ws_sql_adapter = new SqlDataAdapter(sqlstr, sqlcn);
            SqlParameter param = ws_sql_adapter.SelectCommand.Parameters.Add("@Category", SqlDbType.Char, 10);
            param.Value = Category;
            ws_sql_adapter.Fill(ds, "Products");
            DataTable dt = ds.Tables["Products"];
            return dt;
        }
    }
}
