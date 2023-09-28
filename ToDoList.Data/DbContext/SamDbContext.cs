using System.Data.Entity;
using ToDoList.Data.Entities;

namespace ToDoList.Data
{
    public class SamDbContext : DbContext
    {
        public SamDbContext(): base("name = conn")
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
