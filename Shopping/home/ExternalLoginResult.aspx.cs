using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nemiro.OAuth;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;


namespace Shopping
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        CustomerBuisnessLayer customerbuisnesslayerObj = new CustomerBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

            var result = OAuthWeb.VerifyAuthorization();

            Response.Write(String.Format("Provider: {0}<br />", result.ProviderName));

            if (result.IsSuccessfully)
            {
                // successfully
                var user = result.UserInfo;
                Response.Write(String.Format("User ID:  {0}<br />", user.UserId));
                Response.Write(String.Format("Name:     {0}<br />", user.DisplayName));
                Response.Write(String.Format("Email:    {0}", user.Email));
                Customers customer = new Customers();
                customer.CustomerName = user.DisplayName;
                customer.CustomerEmail = user.Email;
                customer.Gender = user.Sex.ToString();
                customer=customerbuisnesslayerObj.GoogleAuthentication(customer);
                Session["Customer"] = customer;
                if (Session["o"] != null)
                {
                    Session["o"] = null;
                    Response.Redirect("orderplace.aspx");
                }
                else
                {
                    Response.Redirect("shop.aspx");
                }

            }
            else
            {
                // error
                Response.Write(result.ErrorInfo.Message);
            }
        }

        }
    }
