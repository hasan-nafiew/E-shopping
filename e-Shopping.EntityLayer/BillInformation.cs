using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shopping.EntityLayer
{
    public class BillInformation
    {
        public int billId { set; get; }
        public string orderId { set; get; }
        public string customerName { set; get; }
        public string customerContact { set; get; }
        public string customerAddress { set; get; }
        public string customerMail { set; get; }
        public string productsNquantity { set; get; }
        public int billPrice { set; get; }
        public string deliveryStatus { set; get; }
    }
}
