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
    public partial class WebForm2 : System.Web.UI.Page
    {
        CategoriesBuisnessLayer categoriesBuisnessLayerObj = new CategoriesBuisnessLayer();
        ProductsBuisnessLayer productsBuisnessLayerObj = new ProductsBuisnessLayer();
        Products product = new Products();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillCategoriesDropDownListAndSideBar();//fillcatagory...from data base

            }
        }

        protected void FillCategoriesDropDownListAndSideBar()
        {
            List<Categories> CategoryList = categoriesBuisnessLayerObj.getAllCategoriesInList();
            DropDownListCategory.DataSource = CategoryList;
            DropDownListCategory.DataTextField = "categoryName";
            DropDownListCategory.DataValueField = "id";
            DropDownListCategory.DataBind();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            HttpPostedFile productImagefileObj = FileUploadProductImage.PostedFile;
            string fileName = Path.GetFileName(productImagefileObj.FileName);
            string fileExtension = Path.GetExtension(productImagefileObj.FileName);
            string Imagepath = Server.MapPath("../App_Resource_Image/ProductImage/") + fileName;
            FileUploadProductImage.SaveAs(Imagepath);

            product.ProductName = TextBoxProductName.Text;
            product.ProductPrice =Convert.ToInt32 (TextBoxProductPrice.Text);
            product.ProductQuantity = Convert.ToInt32(TextBoxProductQuantity.Text);
            product.ProductDetails = TextBoxProductDetails.Text;
            product.ProductImagePath = "~/home/App_Resource_Image/ProductImage/" + fileName;
            product.ProductWarranty = 0;
            product.ProductCategoryId =Convert.ToInt32(DropDownListCategory.SelectedItem.Value);

            productsBuisnessLayerObj.setproducts(product);
            clear();

        }



        protected void clear() {
            TextBoxProductDetails.Text = "";
            TextBoxProductName.Text = "";
            TextBoxProductPrice.Text = "";
            TextBoxProductQuantity.Text = "";
            FileUploadProductImage = null;
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}