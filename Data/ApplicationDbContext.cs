using Microsoft.EntityFrameworkCore;
using RESTDemo.Model;

namespace RESTDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>op):base(op) { }  
        
        public DbSet<Book>? Books { get; set; }

        public DbSet<Student>? Students { get; set; }   

    }
}
