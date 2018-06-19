using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOpenU.Model;

namespace TestOpenU.DAL
{
    public class TodoDB
    {
        private List<TodoItem> _items = new List<TodoItem>();

        public List<TodoItem> GetAllItems()
        {
            return _items;
        }

        public TodoItem GetItemById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void AddNewItem(TodoItem item)
        {
            _items.Add(item);
        }

        public void RemoveItemById(int id)
        {
            _items.Remove(GetItemById(id));
        }

    }
}
