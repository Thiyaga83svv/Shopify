using Shopify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopify.Repository
{
    interface ICustomersRepository
    {
        IEnumerable<Customer> AllCustomer { get; }

        Customer GetCustomer(int customerId);
    }
}
