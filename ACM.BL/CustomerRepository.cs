using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <Summary>
        /// Retrieve one customer
        /// </Summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the customer class
            var customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        /// <Summary>
        /// Retrieve all customers
        /// </Summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
