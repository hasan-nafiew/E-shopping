using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shopping.EntityLayer
{
   public class ProductsCart
    {   
        public int ProductId { set; get; }
        public int ProductPrice { set; get; }
        public int ProductQuantity { set; get; }
        public string ProductImagePath { set; get; }
        public int ProductPriceTotal { set; get; }
        public string orderid { set; get; }
    }
}
