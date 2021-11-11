using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Eshop.Supplier.Entities
{
    public class MyShowDBContext:DbContext
    {
        //Entity set
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        //Add DB String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OIKH9AV\SQLEXPRESS;Initial Catalog=NewDB;Integrated Security=True");
        }

    }
}
