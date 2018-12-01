using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using e_Shopping.EntityLayer;
using e_ShoppingDataLayer;

namespace e_ShoppingBuisnessLayer
{

    public class ProductsBuisnessLayer
    {
        DataTable dataTableObj;
        public int setproducts(Products product)
        {
            string query = string.Format("insert into Products(Productname, CategoriesId,            ProductQuantity,ProductWarranty,UnitPrice,ProductImage,productdetails) values ('{0}',{1},{2},{3},{4},'{5}','{6}')", 
                product.ProductName.ToUpper(), product.ProductCategoryId, product.ProductQuantity, product.ProductWarranty, product.ProductPrice, product.ProductImagePath, product.ProductDetails);
            int i = DataAccess.ExecuteSQL(query);
            Console.WriteLine(i);
            return i;
        }

       public List<Products> getAllProductsInList()
       {
           List<Products> ProductList = new List<Products>();
           dataTableObj = DataAccess.GetDataTable("select * from products order by(id) desc");
           foreach (DataRow row in dataTableObj.Rows)
           {
               ProductList.Add(new Products()
               {
                   ProductId = (int)row[0],
                   ProductName = (string)row[1],
                   ProductCategoryId = (int)row[2],
                   ProductQuantity = (int)row[3],
                   ProductWarranty = (int)row[4],
                   ProductPrice = (int)row[5],
                   ProductImagePath = (string)row[6],
                   ProductDetails = (string)row[7]
               });
               Console.WriteLine(row[6]);
           }
           return ProductList;
       }

       public List<Products> getAllProductsInListByCategory(int categoryid)
       {
           List<Products> ProductList = new List<Products>();
           SqlParameter[] objDataParams = new SqlParameter[1];
           objDataParams[0] = new SqlParameter("@Id", SqlDbType.Int);
           objDataParams[0].Value = categoryid;
           dataTableObj = DataAccess.GetDataTableSP("SpGetProductByCategory", objDataParams);
           foreach (DataRow row in dataTableObj.Rows)
           {
               ProductList.Add(new Products()
               {
                   ProductId = (int)row[0],
                   ProductName = (string)row[1],
                   ProductCategoryId = (int)row[2],
                   ProductQuantity = (int)row[3],
                   ProductWarranty = (int)row[4],
                   ProductPrice = (int)row[5],
                   ProductImagePath = (string)row[6],
                   ProductDetails = (string)row[7]
               });
             
           }
           return ProductList;
       }

       public List<Products> getProductlistSearch(string src,int cid)
       {
           List<Products> ProductList = new List<Products>();
           //dataTableObj = DataAccess.GetDataTable("select * from products");
           if (cid == 0)
           {
               dataTableObj = DataAccess.GetDataTable("select * from products where Productname like '" + src + "%'");
           }
           else
           {
               dataTableObj = DataAccess.GetDataTable("select * from products where Productname like '" + src + "%' and CategoriesId=" + cid + " order by(id) desc");
           }
           foreach (DataRow row in dataTableObj.Rows)
           {
               ProductList.Add(new Products()
               {
                   ProductId = (int)row[0],
                   ProductName = (string)row[1],
                   ProductCategoryId = (int)row[2],
                   ProductQuantity = (int)row[3],
                   ProductWarranty = (int)row[4],
                   ProductPrice = (int)row[5],
                   ProductImagePath = (string)row[6],
                   ProductDetails = (string)row[7]
               });

           }
           return ProductList;
       }

       public Products getProductById(int ProductId)
       {
           Products Product = new Products();
           SqlParameter[] objDataParams = new SqlParameter[1];
           objDataParams[0] = new SqlParameter("@Id", SqlDbType.Int);
           objDataParams[0].Value = ProductId;
           dataTableObj = DataAccess.GetDataTableSP("SpGetProducts",objDataParams);

           foreach (DataRow row in dataTableObj.Rows)
           {
              Product.ProductId=(int)row[0];
              Product.ProductName=(string)row[1];
              Product.ProductCategoryId=(int)row[2];
              Product.ProductQuantity=(int)row[3];
              Product.ProductWarranty=(int)row[4];
              Product.ProductPrice=(int)row[5];
              Product.ProductImagePath = (string)row[6];
              Product.ProductDetails=(string)row[7];
           }

           return Product;
       }

       public void UpdateProducts(Products Product)
       {
           SqlParameter[] objDataParams = new SqlParameter[6];

           objDataParams[0] = new SqlParameter("@name", SqlDbType.VarChar);
           objDataParams[0].Value =Product.ProductName;

           objDataParams[1] = new SqlParameter("@quantity", SqlDbType.Int);
           objDataParams[1].Value = Product.ProductQuantity;

           objDataParams[2] = new SqlParameter("@price", SqlDbType.Int);
           objDataParams[2].Value = Product.ProductPrice;

           objDataParams[3] = new SqlParameter("@imagepath", SqlDbType.VarChar);
           objDataParams[3].Value = Product.ProductImagePath;

           objDataParams[4] = new SqlParameter("@details", SqlDbType.Text);
           objDataParams[4].Value = Product.ProductDetails;

           objDataParams[5] = new SqlParameter("@id", SqlDbType.Int);
           objDataParams[5].Value = Product.ProductId;

           DataAccess.ExecuteSPSQL("SpUpdateProductData", objDataParams);
 
       }

       public void DeleteProductById(int id)
       {
           SqlParameter Parameter = new SqlParameter("@id",SqlDbType.Int);
           Parameter.Value = id;
           string sql = "delete from products where Id=@id";
           DataAccess.ExecuteSQL(sql,Parameter);
       }

       public List<BillInformation> GetBillIfo()
       {
           List<BillInformation> billInfoList = new List<BillInformation>();
           BillInformation billinfo;
           dataTableObj = DataAccess.GetDataTableSp("Billinfocust");
           foreach (DataRow row in dataTableObj.Rows)
           {
               billinfo = new BillInformation();
               billinfo.billId = (int)row[0];
               billinfo.orderId = (string)row[1];
               billinfo.customerName = (string)row[2];
               billinfo.customerContact = (string)row[3];
               billinfo.customerMail = (string)row[4];
               billinfo.customerAddress = (string)row[5];
               billinfo.deliveryStatus = (string)row[6];
               billInfoList.Add(billinfo);
           }

           foreach (var v in billInfoList)
           {
               SqlParameter[] objDataParams = new SqlParameter[1];
               v.productsNquantity = "";
               v.billPrice=0;
               objDataParams[0] = new SqlParameter("@bid", SqlDbType.Int);
               objDataParams[0].Value = v.billId;
               dataTableObj = DataAccess.GetDataTableSP("BillinfoProduct", objDataParams);
               foreach (DataRow row in dataTableObj.Rows)
               {
                   v.productsNquantity += (string)row[0] + "(" + (int)row[1] + "),";
                   v.billPrice += (int)row[1] * (int)row[2];
               }
           }
           return billInfoList;
       }

       public void billupdate(string bid, string ds)
       {
           SqlParameter[] objDataParams = new SqlParameter[2];

           objDataParams[0] = new SqlParameter("@bid", SqlDbType.Int);
           objDataParams[0].Value = Convert.ToInt32(bid);

           objDataParams[1] = new SqlParameter("@st", SqlDbType.VarChar);
           objDataParams[1].Value = ds;

           DataAccess.ExecuteSPSQL("SpUpdateBill", objDataParams);
 
       }
    }
}
