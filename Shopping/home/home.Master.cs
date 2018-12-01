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
    public partial class home : System.Web.UI.MasterPage
    {
        CategoriesBuisnessLayer categoriesBuisnessLayerObj = new CategoriesBuisnessLayer();
        CustomerBuisnessLayer customerbuisnesslayerObj = new CustomerBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillCategoriesDropDownListAndSideBar();
                if (Session["customer"] != null)
                {
                    Customers customer = (Customers)Session["customer"];
                    login.Visible = false;
                    loginbutton.Visible = false;
                    LinkButtonLogout.Visible = true;
                    Labeluser.Text = customer.CustomerName;
                }
                else
                {
                    login.Visible = true;
                    loginbutton.Visible = true;
                    LinkButtonLogout.Visible = false;
                    Labeluser.Text = "User";
                }
                if (Session["shoppingCartProducts"] != null && Session["shoppingCartprice"] != null)
                {
                    List<ProductsCart> ProductList = (List<ProductsCart>)Session["shoppingCartProducts"];
                    string cartPrice = Convert.ToString((int)Session["shoppingCartprice"]);
                    String cartItemCount = Convert.ToString(ProductList.Count);
                    LabelCartItemCount1.Text = LabelCartItemCount2.Text = cartItemCount;
                    LabelCartPrice.Text = LabelCartPrice2.Text = cartPrice;
                }  
            }

        }

        protected void FillCategoriesDropDownListAndSideBar()
        {
            List<Categories> CategoryList = categoriesBuisnessLayerObj.getAllCategoriesInList();

            DropDownListCatagory.DataSource=CategoryList;
            DropDownListCatagory.DataTextField = "categoryName";
            DropDownListCatagory.DataValueField = "id";
            DropDownListCatagory.DataBind();
            DropDownListCatagory.Items.Insert(0, new ListItem("All", "0"));

            DatalistSideBar.DataSource = CategoryList;
            DatalistSideBar.DataBind();
        }

        protected void ButtonCatagory_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("products.aspx?view=%21"+e.CommandArgument+"%217");
        }

        public Label LabelCartItemCount1OnMasterPage
        {
            get
            {
                return LabelCartItemCount1;
            }
        }
        public Label LabelCartItemCount2OnMasterPage
        {
            get
            {
                return LabelCartItemCount2;
            }
        }
        public Label LabelCartPriceOnMasterPage
        {
            get
            {
                return LabelCartPrice;
            }
        }

        public Label LabelCartPrice2OnMasterPage
        {
            get
            {
                return LabelCartPrice2;
            }
        }


        protected void ButtonSignIn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.CustomerEmail = TextBoxLoginMail.Text;
            customer.password = TextBoxPassword.Text;
            customer = customerbuisnesslayerObj.Authentiacation(customer);

            if (customer != null)
            {
                login.Visible = false;
                loginbutton.Visible = false;
                Labeluser.Text = customer.CustomerName;
                Session["Customer"] = customer;
                LinkButtonLogout.Visible = true;
            }
            else
            {
                Response.Redirect("login.aspx?view=%f%a%i%l");
               
            }
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session["customer"] = null;
            LinkButtonLogout.Visible = false;
            login.Visible = true;
            loginbutton.Visible = true;
            Labeluser.Text = "User";
            Response.Redirect("shop.aspx");
        }

        protected void RedirectToLogin_Click(object sender, EventArgs e)
        {
            // gets a provider name from the data-provider
            string provider = ((Button)sender).Attributes["data-provider"];
            // build the return address
            string returnUrl = new Uri(Request.Url, "ExternalLoginResult.aspx").AbsoluteUri;
            // redirect user into external site for authorization
            OAuthWeb.RedirectToAuthorization(provider, returnUrl);
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string s = TextBoxSearch.Text;
             string c = DropDownListCatagory.SelectedItem.Value;
            Response.Redirect("products.aspx?src="+s+"&key="+c);
        }
    }
}
