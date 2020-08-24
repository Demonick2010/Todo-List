using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_List.Models;

namespace Todo_List.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetAllItems();
        void AddTodo(string todoName);
        void ValueChenged(TodoItem changedItem);
        void DeleteItem(int id);
    }
}
