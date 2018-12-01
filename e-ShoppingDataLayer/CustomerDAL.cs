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
    public class CustomerDAL
    {
        private string conn = ConfigurationManager.ConnectionStrings["MyCon"].ToString();

        public int InsertUpdateDelete(string sqlstring)
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

        public int AddNewCustomerDB(string _CustName, string _Email, string _Address, string _Contact, string _Gender, string _City, string _Password)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Customers (CustName,Email,Address,Contact,Gender,City,Password) VALUES ('" + _CustName + "','" + _Email + "','" + _Address + "','" + _Contact + "','" + _Gender + "','" + _City + "','" + _Password + "')";
            return InsertUpdateDelete(sql);
        }

        public void UpdateCustomerDB(int _id, string _CustName, string _Email, string _Address, string _Contact, string _Gender, string _City, string _Password)
        {
            DataSet ds = new DataSet();
            string sql = "Update Customers set CustName='" + _CustName + "',Email = '" + _Email + "',Address= '" + _Address + "',Contact = '" + _Contact + "', Gender = '" + _Gender + "',City= '" + _City + "', Password'" + _Password + "'  Where Id = '" + _id + "' ";
            InsertUpdateDelete(sql);
        }

        public void DeleteCustomerDB(int _id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete From Customers Where id = '" + _id + "' ";
            InsertUpdateDelete(sql);
        }

        public object LoadCustomerDB()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT CustName, Email, Address, Contact, Gender, City from Customers";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
