using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Shopping.EntityLayer;
using e_ShoppingDataLayer;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace e_ShoppingBuisnessLayer
{
    public class CustomerBuisnessLayer
    {
        DataTable dataTableObj;
        public Customers Authentiacation(Customers Customer)
        {
            SqlParameter[] objDataParams = new SqlParameter[2];
            objDataParams[0] = new SqlParameter("@email", SqlDbType.VarChar);
            objDataParams[0].Value = Customer.CustomerEmail;
            objDataParams[1] = new SqlParameter("@password", SqlDbType.VarChar);
            objDataParams[1].Value = Customer.password;
            int r = DataAccess.ExecuteSP("SPlogin", objDataParams);
            if (r==1)
            {
                SqlParameter[] objDataParam = new SqlParameter[1];
                objDataParam[0] = new SqlParameter("@email", SqlDbType.VarChar);
                objDataParam[0].Value = Customer.CustomerEmail;
                dataTableObj = DataAccess.GetDataTableSP("SpGetCustomerByMail", objDataParam);
                foreach (DataRow row in dataTableObj.Rows)
                {
                    Customer.customerId = (int)row[0];
                    Customer.CustomerName = (string)row[1];
                    Customer.CustomerEmail = (string)row[2];
                    Customer.Address = (string)row[3];
                    Customer.Contact = (string)row[4];
                    Customer.Gender = (string)row[5];
                }
            }
            else
            {
                Customer = null;
            }
            return Customer;
        }

        public void UpdateCustomer(Customers customer)
        {
            SqlParameter[] objDataParams = new SqlParameter[5];

            objDataParams[0] = new SqlParameter("@name", SqlDbType.VarChar);
            objDataParams[0].Value = customer.CustomerName;

            objDataParams[1] = new SqlParameter("@email", SqlDbType.VarChar);
            objDataParams[1].Value = customer.CustomerEmail;

            objDataParams[2] = new SqlParameter("@address", SqlDbType.VarChar);
            objDataParams[2].Value = customer.Address;

            objDataParams[3] = new SqlParameter("@contact", SqlDbType.VarChar);
            objDataParams[3].Value = customer.Contact;

            objDataParams[4] = new SqlParameter("@id", SqlDbType.Int);
            objDataParams[4].Value = customer.customerId;
            int result= DataAccess.ExecuteSPSQL("SpupadateCustomer", objDataParams);
        }

        public void OrderConfirm(List<ProductsCart> productList, Customers customer)
        {
            string pid="";
            foreach (var p in productList)
            {
                SqlParameter[] objDataParams = new SqlParameter[4];

                objDataParams[0] = new SqlParameter("@oid", SqlDbType.VarChar);
                objDataParams[0].Value = p.orderid;
                pid=p.orderid;

                objDataParams[1] = new SqlParameter("@pid", SqlDbType.Int);
                objDataParams[1].Value = p.ProductId;

                objDataParams[2] = new SqlParameter("@pquantity", SqlDbType.Int);
                objDataParams[2].Value = p.ProductQuantity;

                objDataParams[3] = new SqlParameter("@cid", SqlDbType.Int);
                objDataParams[3].Value = customer.customerId;

                DataAccess.ExecuteSPSQL("SpInsertOrdernBill", objDataParams);

            }

            SqlParameter[] objDataParam = new SqlParameter[2];
            objDataParam[0] = new SqlParameter("@oid", SqlDbType.VarChar);
            objDataParam[0].Value = pid;
            objDataParam[1] = new SqlParameter("@cid", SqlDbType.Int);
            objDataParam[1].Value = customer.customerId;
            DataAccess.ExecuteSPSQL("SpInsertBill", objDataParam);
        }

        public Customers GoogleAuthentication(Customers Customer)
        {
            SqlParameter[] objDataParams = new SqlParameter[1];
            objDataParams[0] = new SqlParameter("@mail", SqlDbType.VarChar);
            objDataParams[0].Value = Customer.CustomerEmail;
            int result = DataAccess.ExecuteSP("SpmailCheck", objDataParams);
            if (result == 1)
            {
                dataTableObj = DataAccess.GetDataTable("select * from customers where email='" + Customer.CustomerEmail + "'");
                foreach (DataRow row in dataTableObj.Rows)
                {
                    Customer.customerId = (int)row[0];
                    Customer.CustomerName = (string)row[1];
                    Customer.CustomerEmail = (string)row[2];
                    Customer.Address = (string)row[3];
                    Customer.Contact = (string)row[4];
                    Customer.Gender = (string)row[5];
                }
            }
            else
            {
                SqlParameter[] objDataParam = new SqlParameter[7];

                objDataParam[0] = new SqlParameter("@name", SqlDbType.VarChar);
                objDataParam[0].Value = Customer.CustomerName;

                objDataParam[1] = new SqlParameter("@mail", SqlDbType.VarChar);
                objDataParam[1].Value = Customer.CustomerEmail;

                objDataParam[2] = new SqlParameter("@address", SqlDbType.VarChar);
                objDataParam[2].Value = "";

                objDataParam[3] = new SqlParameter("@contact", SqlDbType.VarChar);
                objDataParam[3].Value = "";

                objDataParam[4] = new SqlParameter("@gender", SqlDbType.VarChar);
                objDataParam[4].Value = Customer.Gender;

                objDataParam[5] = new SqlParameter("@password", SqlDbType.VarChar);
                objDataParam[5].Value ="";

                objDataParam[6] = new SqlParameter("@city", SqlDbType.VarChar);
                objDataParam[6].Value = "";

                result = DataAccess.ExecuteSPSQL("SpInsertCust", objDataParam);
                GoogleAuthentication(Customer);
 
            }
            return Customer;
        }
    }
}
