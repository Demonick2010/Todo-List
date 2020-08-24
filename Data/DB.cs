using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_List.Models;

namespace Todo_List.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) {}

        public DbSet<TodoItem> todoItems { get; set; }
    }
}
