using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_ShoppingBuisnessLayer;

namespace Shopping.admin
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        CustomersBAL objlogic;
        protected void Page_Load(object sender, EventArgs e)
        {
            objlogic = new CustomersBAL();
            GridView1.DataSource = objlogic.LoadCustomer();
            GridView1.DataBind();
        }
    }
}