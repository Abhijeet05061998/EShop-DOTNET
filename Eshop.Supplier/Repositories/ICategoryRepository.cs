using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Supplier.Entities;
namespace Eshop.Supplier.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategroy(Category category);
    }
}
