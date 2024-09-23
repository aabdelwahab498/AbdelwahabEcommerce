using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = Ecommerce.Domain.User;

namespace Ecommerce.infrastructure.presentice
{
    public class DBContextApplication : DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options)
            : base(options)
        {

        }
       public DbSet <User> Users { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> orderItems { get; set; }











    }
}
