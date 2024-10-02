using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_task
{
    public class StudentLibraryContext : DbContext
    {
        public DbSet<Book> books { get; set; } = null!;
        public StudentLibraryContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=student_library.db");
        }
    }
}
