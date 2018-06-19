using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOpenU.DAL;
using TestOpenU.Model;

namespace TestOpenU.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private TodoDB _db;
        public TodoController(TodoDB db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return _db.GetAllItems();
        }

        [HttpGet("{id}")]
        public TodoItem Get(int id)
        {
            return _db.GetItemById(id);
        }

        public void Post([FromBody]TodoItem item)
        {
            _db.AddNewItem(item);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _db.RemoveItemById(id);
        }

    }
}
