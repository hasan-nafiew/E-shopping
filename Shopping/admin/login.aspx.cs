using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;

namespace Shopping.admin
{
    public partial class login : System.Web.UI.Page
    {
        AdminBuisnessLayer adminBuisnessLayerObj = new AdminBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Admins admin = new Admins();
            admin.email = TextBoxMail.Text;
            admin.password = TextBoxPassword.Text;
           admin = adminBuisnessLayerObj.Atuhentication(admin);

           if (admin != null)
           {
               Session["admin"] = admin;
               Response.Redirect("dashboard.aspx");
           }
           else
           {
               Response.Redirect("login.aspx");
           }
        }
    }
}