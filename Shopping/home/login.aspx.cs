using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;
using Nemiro.OAuth;
using Nemiro.OAuth.Clients;

namespace Shopping
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        CustomerBuisnessLayer customerbuisnesslayerObj = new CustomerBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer"] != null)
            {
                Response.Redirect("shop.aspx");
            }
            else
            {
                if (Request.QueryString["view"] == "%f%a%i%l")
                {
                    LabelLStaus.Text = "Login Failed";
                }
                else if (Request.QueryString["view"] == "%s%u%c%c%e%s%s")
                {
                    LabelLStaus.Text = "Registration Successful. Now Login";
                    LabelLStaus.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.CustomerEmail = TextBoxLoginMail.Text;
            customer.password = TextBoxPassword.Text;
            customer = customerbuisnesslayerObj.Authentiacation(customer);

            if (customer != null)
            {
                Session["Customer"] = customer;
                if (Request.QueryString["view"] == "%r%o%r%d%e%r")
                {
                    Response.Redirect("orderplace.aspx");
                }
                else
                {
                    Response.Redirect("shop.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx?view=%f%a%i%l");

            }
        }

        protected void RedirectToLogin_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["view"] == "%r%o%r%d%e%r")
            {
                Session["o"] = 1;
            }
            // gets a provider name from the data-provider
            string provider = ((LinkButton)sender).Attributes["data-provider"];
            // build the return address
            string returnUrl = new Uri(Request.Url, "ExternalLoginResult.aspx").AbsoluteUri;
            // redirect user into external site for authorization
            OAuthWeb.RedirectToAuthorization(provider, returnUrl);
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Session["mail"] = TextBoxEmailRegister.Text;
            Response.Redirect("register.aspx");
        }
    }
}