using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Data
{
    public interface ITodoService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
    }
}
