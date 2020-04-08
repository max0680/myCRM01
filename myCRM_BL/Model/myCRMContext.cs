using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCRM_BL.Model
{
   public class myCRMContext:DbContext
    {
       public myCRMContext() : base("myCRMConnection") {  }
        
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Seller> Sellers { get; set; }
        public DbSet< Sell> Sells { get; set; }
        public DbSet<Check> Checks { get; set; }




    }
}
