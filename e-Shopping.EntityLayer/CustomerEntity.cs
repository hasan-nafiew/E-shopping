using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shopping.EntityLayer
{
    public class CustomerEntity
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustAddress { get; set; }
        public string CustContact { get; set; }
        public string CustGender { get; set; }
        public string CustCity { get; set; }
        public string CustPassword { get; set; }
    }
}
