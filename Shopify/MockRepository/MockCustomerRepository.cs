using Shopify.Model;
using Shopify.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Shopify.MockRepository
{
    public class MockCustomerRepository : ICustomersRepository
    {
        public IEnumerable<Customer> AllCustomer => new List<Customer> 
        {  
           new Customer
            {   
                CustomerId = 1, 
                Firsname ="Thiyaga", 
                Lastname="Raj", 
                Address="23/64, one street", 
                State="NSW", City="Parramatta", 
                DateOfBirth = Convert.ToDateTime("20/11/2021 11:05:01"), 
                PhoneNumber= 001545154,
                Postcode=2150 
            },
           new Customer
            {
                CustomerId = 1,
                Firsname ="Johon",
                Lastname="Raj",
                Address="21/66, one street",
                State="NSW", City="Parramatta",
                DateOfBirth = Convert.ToDateTime("20/11/2021 11:05:01"),
                PhoneNumber= 001545154,
                Postcode=2150
            },
        };

        public Customer GetCustomer(int customerId)
        {
            return AllCustomer.FirstOrDefault(e => e.CustomerId == customerId);
        }
    }
}
