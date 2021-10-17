using ToDoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoAPI.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");
        
    }
}