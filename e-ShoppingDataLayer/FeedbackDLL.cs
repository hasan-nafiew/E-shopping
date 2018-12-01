using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace e_ShoppingDataLayer
{
   public class FeedbackDLL
    {
        private string conn = ConfigurationManager.ConnectionStrings["MyCon"].ToString();
        public int InsertFeedBack(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            SqlCommand objCmd = new SqlCommand(sqlstring, objsqlconn);
            return objCmd.ExecuteNonQuery();
        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            DataSet ds = new DataSet();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }
        public int AddFeedBack(string _Name, string _Email, string _Feedback)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into CustomerFeedback (Name,Email,Feedback) VALUES ('" + _Name + "','" + _Email + "','" + _Feedback + "')";
            return InsertFeedBack(sql);
        }
        public object LoadFeedbackDB()
        {
            DataSet ds = new DataSet();
            string sql = "select *from CustomerFeedback";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
