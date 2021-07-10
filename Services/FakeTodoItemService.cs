using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem
            {
                Title = "Build awesome(?) apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var item3 = new TodoItem
            {
                Title = "Or at least something what will work",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            return Task.FromResult(new[] { item1, item2, item3 });
        }
    }
}
