using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Supplier.Entities;
namespace Eshop.Supplier.Repositories
{
    interface IItemRepository
    {
        void AddItem(Item item);
        void DeleteItem(string itemId);
        List<Item> GetItems();
        Item GetItem(string itemId);
        void UpdateItem(Item item);
    }
}
