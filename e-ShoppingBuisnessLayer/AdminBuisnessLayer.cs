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
    public class AdminBuisnessLayer
    {
        DataTable dataTableObj;
        public Admins Atuhentication(Admins admin)
        {
            SqlParameter[] objDataParams = new SqlParameter[2];
            objDataParams[0] = new SqlParameter("@email", SqlDbType.VarChar);
            objDataParams[0].Value = admin.email;
            objDataParams[1] = new SqlParameter("@password", SqlDbType.VarChar);
            objDataParams[1].Value = admin.password;
            int r = DataAccess.ExecuteSP("SpAdminLogin", objDataParams);
            if (r == 1)
            {
                SqlParameter[] objDataParam = new SqlParameter[1];
                objDataParam[0] = new SqlParameter("@email", SqlDbType.VarChar);
                objDataParam[0].Value = admin.email;
                dataTableObj = DataAccess.GetDataTableSP("SpGetAdminByMail", objDataParam);
                foreach (DataRow row in dataTableObj.Rows)
                {
                   admin.id = (int)row[0];
                    admin.username = (string)row[1];
                   admin.password=(string)row[2];
                    admin.email = (string)row[4];
                    admin.role = (string)row[3];
                   admin.address = (string)row[5];
                   admin.contact = (string)row[6];
                }
            }
            else
            {
                admin= null;
            }

            return admin;
        }
    }
}
