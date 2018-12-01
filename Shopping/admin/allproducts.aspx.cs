using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;
using System.IO;
namespace Shopping.admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        ProductsBuisnessLayer productsBuisnessLayerObj = new ProductsBuisnessLayer();
        Products product = new Products();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillGridViewProduct();
            }  
        }

        protected void FillGridViewProduct()
        {
            List<Products> ProductList = productsBuisnessLayerObj.getAllProductsInList();
            GridView1.DataSource = ProductList;
            GridView1.DataBind();
        }


        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillGridViewProduct();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGridViewProduct();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillGridViewProduct();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lblId");
           product.ProductId = Convert.ToInt32(id.Text);

           FileUpload imageFile = (FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUploadImage");
           string path = "~/home/App_Resource_Image/ProductImage/";
           if (imageFile.HasFile)
           {
               path += imageFile.FileName;    
               imageFile.SaveAs(MapPath(path));
           }
           else
           {
               Image img = (Image)GridView1.Rows[e.RowIndex].FindControl("ImageEdit");
               path = img.ImageUrl;
           }
           product.ProductImagePath = path;

           TextBox txtProductName = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
           product.ProductName = txtProductName.Text;

           TextBox txtProductQuantity = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
           product.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);

           TextBox txtProductPrice = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
           product.ProductPrice = Convert.ToInt32(txtProductPrice.Text);

           TextBox txtDetails = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBoxDetails");
           product.ProductDetails = txtDetails.Text;

           productsBuisnessLayerObj.UpdateProducts(product);

           GridView1.EditIndex = -1;
           FillGridViewProduct();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("lblId");
            productsBuisnessLayerObj.DeleteProductById(Convert.ToInt32(id.Text));
            FillGridViewProduct();
        }

    }
}