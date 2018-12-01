using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;

namespace Shopping
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<ProductsCart> ProductList = (List<ProductsCart>)Session["shoppingCartProducts"];
                DataList1.DataSource = ProductList;
                DataList1.DataBind();
                if(ProductList!=null){
                    LabelCartItemCount.Text = ProductList.Count + "";
                    LabelTotalPrice.Text = (int)Session["shoppingCartprice"]+"";
                }
            }     
        }

        protected void LinkButtonCart_Command(object sender, CommandEventArgs e) {
            List<ProductsCart> ProductList = (List<ProductsCart>)Session["shoppingCartProducts"];
            int cartPrice = (int)Session["shoppingCartprice"];
            int i = 0;int id=Convert.ToInt32((string)e.CommandArgument);
            foreach (var p in ProductList)
            {
                if (p.ProductId ==id)
                {
                    //Collection was modified; enumeration operation may not execute.
                    cartPrice -= p.ProductPriceTotal;
                    Session["shoppingCartprice"] = cartPrice;
                    ((home)Master).LabelCartPriceOnMasterPage.Text = cartPrice+"";
                    ((home)Master).LabelCartPrice2OnMasterPage.Text = cartPrice+"";
                    break;
                }
                i++;
            }
            ProductList.RemoveAt(i);
            DataList1.DataSource = ProductList;
            DataList1.DataBind();
            LabelCartItemCount.Text = ProductList.Count + "";
            LabelTotalPrice.Text = cartPrice + "";
            ((home)Master).LabelCartItemCount1OnMasterPage.Text = ((home)Master).LabelCartItemCount2OnMasterPage.Text = ProductList.Count+"";

        }

    }
}