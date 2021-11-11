using Eshop.Supplier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Supplier.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly MyShowDBContext db = new MyShowDBContext();
        public void AddItem(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
        }

        public void DeleteItem(string itemId)
        {
            Item item = db.Items.Find(itemId);
            db.Items.Remove(item); //remove item
            db.SaveChanges();

        }

        public Item GetItem(string itemId)
        {
            Item item = db.Items.Find(itemId);
            return item;
        }

        public List<Item> GetItems()
        {
            return db.Items.ToList();
        }

        public void UpdateItem(Item item)
        {
            db.Items.Update(item);
            db.SaveChanges();
        }
    }
}
