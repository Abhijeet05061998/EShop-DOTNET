using Eshop.Supplier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Eshop.Supplier.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyShowDBContext db = new MyShowDBContext();
        public void AddCategroy(Category category)
        {
            db.Categories.Add(category); //add new category to table
            db.SaveChanges();
        }
    }
}
