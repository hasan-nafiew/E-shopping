using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_ShoppingBuisnessLayer;
using e_Shopping.EntityLayer;




namespace Shopping
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        CustomersBAL objLogic=new CustomersBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogic = new CustomersBAL();
            Control C = this.Master.FindControl("sidebar");
            C.Visible = false;
            if (Session["customer"] != null)
            {
                Response.Redirect("shop.aspx");
            }

            if (!IsPostBack)
            {
                if (Session["mail"] != null)
                {
                    txtUserEmail.Text = (string)Session["mail"];
                    Session.Remove("mail");
                }
            }
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            int result = 0;
            CustomerEntity customer = new CustomerEntity();
            customer.CustName = txtUserFullName.Text;
            customer.CustEmail = txtUserEmail.Text;
            customer.CustGender = rbtnGender.Text;
            customer.CustContact = txtUserContactNo.Text;
            customer.CustAddress = txtUserAddress.Text;
            customer.CustCity = txtUserCity.Text;
            customer.CustPassword = txtUserConfirmPassword.Text;
            result = objLogic.AddNewCustomer(customer);
            txtUserFullName.Text = "";
            txtUserEmail.Text = "";
            txtUserCity.Text = "";
            txtUserAddress.Text = "";
            txtUserPassword.Text="";
            txtUserConfirmPassword.Text = "";
            txtUserContactNo.Text = "";
            Response.Redirect("login.aspx?view=%s%u%c%c%e%s%s");
            //objLogic.AddNewCustomer(_CustName, _Email, _Address, _Contact, _Gender, _City, _Password);
        }

    }
}