using Microsoft.EntityFrameworkCore;
using Shopify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopify.Repository
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options):base(options)
        {

        }
        public DbSet<Customer> CustomerDetails { get; set; }
        
    }
}
