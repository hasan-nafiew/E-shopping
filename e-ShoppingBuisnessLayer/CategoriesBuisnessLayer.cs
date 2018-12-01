using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using e_Shopping.EntityLayer;
using e_ShoppingDataLayer;
namespace e_ShoppingBuisnessLayer
{
   public class CategoriesBuisnessLayer
    {
       
       DataTable dataTableObj;
       public List<Categories> getAllCategoriesInList()
       {
           List<Categories> CategoryList = new List<Categories>();
           dataTableObj = DataAccess.GetDataTable("select * from categories");
           foreach (DataRow row in dataTableObj.Rows)
           {
              CategoryList.Add(new Categories() { id = (int)row[0], categoryName=(string)row[1] });
              Console.WriteLine(row[0]);
           }
           return CategoryList;
       }
    }
}
