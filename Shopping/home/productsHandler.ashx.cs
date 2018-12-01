using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;
using e_ShoppingDataLayer;
using System.Data;
using System.Data.Sql;
using System.Web.Script.Serialization;

namespace Shopping
{
    /// <summary>
    /// Summary description for productsHandler
    /// </summary>
    public class productsHandler : IHttpHandler
    {
        ProductsBuisnessLayer pbobj = new ProductsBuisnessLayer();
        public void ProcessRequest(HttpContext context)
        {

            string text = context.Request["term"] ?? "";
            List<string> Productname = new List<string>();
            DataTable dtaobj = DataAccess.GetDataTable("select Productname from products where Productname like '"+text+"%'");

            foreach (DataRow row in dtaobj.Rows)
            {
                Productname.Add((string)row[0]);
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(Productname));

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}