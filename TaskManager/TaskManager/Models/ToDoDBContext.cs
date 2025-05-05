using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoData.Models
{
    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options) 
        {
            //var optionsBuilder = new DbContextOptionsBuilder<ToDoDBContext>();
            //optionsBuilder.UseSqlite("Data Source=TaskDB.db");
        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}
