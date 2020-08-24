using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_List.Data;
using Todo_List.Models;

namespace Todo_List.Data.Repository
{
    public class SQLRepository : IRepository
    {
        private readonly DB _context;

        public SQLRepository(DB context)
        {
            _context = context;
        }

        public void AddTodo(string todoName)
        {
            TodoItem newItem = new TodoItem()
            {
                Title = todoName,
                IsDone = false
            };
            _context.todoItems.Add(newItem);
            _context.SaveChanges();
        }

        public IEnumerable<TodoItem> GetAllItems()
        {
            return _context.todoItems;
        }

        public void ValueChenged(TodoItem changedItem)
        {
            var item = _context.todoItems.Attach(changedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var deletedItem = _context.todoItems.Find(id);

            if (deletedItem != null)
            {
                _context.todoItems.Remove(deletedItem);
                _context.SaveChanges();
            }
        }
    }
}
