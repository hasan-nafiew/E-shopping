using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shopping.EntityLayer
{
   public class Products
    {
        public string ProductName { set; get; }
        public int ProductId { set; get; }
        public int ProductPrice { set; get; }
        public int ProductQuantity { set; get; }
        public int ProductCategoryId { set; get; }
        public string ProductDetails { set; get; }
        public string ProductImagePath { set; get; }
        public int ProductWarranty { set; get; }
    }
}
