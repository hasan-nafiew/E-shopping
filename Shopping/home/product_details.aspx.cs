using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;

namespace Shopping
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        ProductsBuisnessLayer productsBuisnessLayerObj = new ProductsBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["view"] != null)
            {
                showProduct();
            }
            else
            {
                Response.Redirect("shop.aspx");
            }

            if (!Page.IsPostBack)
            {

                if (Session["shoppingCartprice"] == null)
                {
                    Session["shoppingCartprice"] = 0;
                    Session["shoppingCartProducts"] = null;
                }
            }  
            
        }

        protected void showProduct()
        {
            
            string s = Request.QueryString["view"];
            string id = s.Substring(1, s.Length - 2);
          
            Products Product = productsBuisnessLayerObj.getProductById(Convert.ToInt32(id));

            LabelProductName.Text = Product.ProductName;
            LabelProductPrice.Text =Convert.ToString(Product.ProductPrice);
            LabelItemQuantity.Text = Convert.ToString(Product.ProductQuantity);
            TextBoxQuantity.Text = Convert.ToString(Product.ProductQuantity);
            LabelProductDetails.Text = Product.ProductDetails;
            ImageProduct.ImageUrl = Product.ProductImagePath;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string s = Request.QueryString["view"];
            string id = s.Substring(1, s.Length - 2);
            Products Product = productsBuisnessLayerObj.getProductById(Convert.ToInt32(id));

            ProductsCart ProductCart = new ProductsCart();
            ProductCart.ProductId = Product.ProductId;
            ProductCart.ProductPrice = Product.ProductPrice;
            ProductCart.ProductPriceTotal = Product.ProductPrice;
            ProductCart.ProductImagePath = Product.ProductImagePath;
            ProductCart.ProductQuantity = 1;

            Session["shoppingCartprice"] = (int)Session["shoppingCartprice"] + Product.ProductPrice;
            string cartPrice = Convert.ToString((int)Session["shoppingCartprice"]) + " Tk";
            ((home)Master).LabelCartPriceOnMasterPage.Text = cartPrice;
            ((home)Master).LabelCartPrice2OnMasterPage.Text = cartPrice;

            List<ProductsCart> ProductList = new List<ProductsCart>();
            if (Session["shoppingCartProducts"] != null)
            {
                ProductList = (List<ProductsCart>)Session["shoppingCartProducts"];
                bool add = true;
                foreach (var p in ProductList)
                {
                    if (ProductCart.ProductId == p.ProductId)
                    {
                        p.ProductQuantity += ProductCart.ProductQuantity;
                        p.ProductPriceTotal += ProductCart.ProductPrice;
                        add = false;
                    }

                }
                if (add)
                {
                    ProductList.Add(ProductCart);
                }
                Session["shoppingCartProducts"] = ProductList;
            }
            else
            {
                ProductList.Add(ProductCart);
                Session["shoppingCartProducts"] = ProductList;
            }

            ProductList = (List<ProductsCart>)Session["shoppingCartProducts"];
            String cartItemCount = Convert.ToString(ProductList.Count);
            ((home)Master).LabelCartItemCount1OnMasterPage.Text = cartItemCount;
            ((home)Master).LabelCartItemCount2OnMasterPage.Text = cartItemCount;

        }

    }
}