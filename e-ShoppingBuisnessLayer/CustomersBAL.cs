using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_ShoppingDataLayer;
using e_Shopping.EntityLayer;

namespace e_ShoppingBuisnessLayer
{
    public class CustomersBAL
    {
        //public Int16 _id { get; set; }
        //public string _CustName { get; set; }
        //public string _Email { get; set; }
        //public string _Address { get; set; }
        //public string _Contact { get; set; }
        //public string _Gender { get; set; }
        //public string _City { get; set; }
        //public string _Password { get; set; }

        public CustomerDAL objDataLayer = new CustomerDAL();


        public int AddNewCustomer(CustomerEntity customer)
        {

            return objDataLayer.AddNewCustomerDB(customer.CustName, customer.CustEmail, customer.CustAddress, customer.CustContact, customer.CustGender, customer.CustCity, customer.CustPassword);

        }

        public void UpdateCustomer(CustomerEntity customer)
        {
            objDataLayer.UpdateCustomerDB(customer.CustID, customer.CustName, customer.CustEmail, customer.CustAddress, customer.CustContact, customer.CustGender, customer.CustCity, customer.CustPassword);
        }

        public void DeleteCustomer(CustomerEntity customer)
        {
            objDataLayer.DeleteCustomerDB(customer.CustID);
        }

        public object LoadCustomer()
        {
            return objDataLayer.LoadCustomerDB();
        }

    }
}
