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
    public partial class WebForm4 : System.Web.UI.Page
    {
        ProductsBuisnessLayer productsBuisnessLayerObj = new ProductsBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["src"] != null && Request.QueryString["key"] != null)
                {
                    filldatalistpSearch();
 
                }

                else if (Request.QueryString["view"] != null)
                {
                    FillDataListProduct();
                    if (Session["shoppingCartprice"] == null)
                    {
                        Session["shoppingCartprice"] = 0;
                        Session["shoppingCartProducts"] = null;
                    }
                }
            }  

       
        }
        protected void filldatalistpSearch()
        {
            string s = Request.QueryString["src"];
                int id =Convert.ToInt32 (Request.QueryString["key"]);
                List<Products> productlist = productsBuisnessLayerObj.getProductlistSearch(s, id);
                DataList1.DataSource = productlist;
                DataList1.DataBind();
        }
        protected void FillDataListProduct()
        {
            string s = Request.QueryString["view"];
            string id = s.Substring(1, s.Length - 3);
            List<Products> ProductList = productsBuisnessLayerObj.getAllProductsInListByCategory(Convert.ToInt32(id));
            DataList1.DataSource = ProductList;
            DataList1.DataBind();

            int pCount = ProductList.Count;
            if (pCount < 2)
            {
                LabelProductCount.Text = pCount + " product is available";
            }
            else
            {
                LabelProductCount.Text = pCount + " products are available";
            }
        }

        protected void LinkButtonCart_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Products Product = productsBuisnessLayerObj.getProductById(Convert.ToInt32(id));
            ProductsCart ProductCart = new ProductsCart();
            ProductCart.ProductId = Product.ProductId;
            ProductCart.ProductPrice = Product.ProductPrice;
            ProductCart.ProductPriceTotal = Product.ProductPrice;
            ProductCart.ProductImagePath = Product.ProductImagePath;
            ProductCart.ProductQuantity = 1;
            ProductCart.orderid = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.ffffff").Trim(new Char[] { ' ', '-', '.', ':' });

            Response.Write(ProductCart.orderid);

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
                    p.orderid = ProductCart.orderid;
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