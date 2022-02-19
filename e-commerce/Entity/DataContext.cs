using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
//datainitializer ile aynı namespace içinde olduğu için using vermeye gerek yok
namespace e_commerce.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection") //webconfig string
        {
           
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet <OrderLine> OrderLines { get; set; }
    }
}