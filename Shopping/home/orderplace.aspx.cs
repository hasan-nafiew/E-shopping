using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;
using System.Net.Mail;
using System.Configuration;

namespace Shopping
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        CustomerBuisnessLayer customerbuisnesslayerobj = new CustomerBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["shoppingCartProducts"] != null && Session["Customer"] != null)
            //{
                Control C = this.Master.FindControl("sidebar");
                C.Visible = false;
                confirm.Visible = false;
                
                if (!IsPostBack)
                {
                    if (Session["Customer"] != null && Session["ShoppingCartProducts"]!=null)
                    {
                        Customers customer = (Customers)Session["Customer"];
                        TextBoxName.Text = customer.CustomerName;
                        TextBoxMail.Text = customer.CustomerEmail;
                        TextBoxAddress.Text = customer.Address;
                        TextBoxCntact.Text = customer.Contact;
                    }
                    else if (Session["Customer"] == null && Session["ShoppingCartProducts"] != null)
                    {
                        Response.Redirect("login.aspx?view=%r%o%r%d%e%r");
                    }
                    else
                    {
                        Response.Redirect("login.aspx");
                    }
                }
            
        }

        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            List<ProductsCart> ProductList = new List<ProductsCart>();
            ProductList = (List<ProductsCart>)Session["shoppingCartProducts"];
            Customers customer = new Customers();
            customer.CustomerName = TextBoxName.Text;
            customer.CustomerEmail = TextBoxMail.Text;
            customer.Address = TextBoxAddress.Text;
            customer.Contact = TextBoxCntact.Text;
            Customers customerses = (Customers)Session["Customer"];
            customer.customerId = customerses.customerId;
            customerbuisnesslayerobj.UpdateCustomer(customer);

            customerbuisnesslayerobj.OrderConfirm(ProductList, customer);

            MailMessage mailmesaaage = new MailMessage("hasanseam37@gmail.com",customer.CustomerEmail+"");
            mailmesaaage.Subject = "Order Confirmed";
            mailmesaaage.Body = "Dear Customer,Thank you Purchasing From Us. You will get your product in 4 days";

            SmtpClient sc = new SmtpClient("smtp.gmail.com",587);
            sc.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "hasanseam37",
                Password = "1@5@6464mn"
            };
            sc.EnableSsl = true;
            sc.Send(mailmesaaage);

            Session["shoppingCartProducts"] = null;
            Session["shoppingCartprice"] = null;

            orderform.Visible = false;
            confirm.Visible = true;

        }
    }
}