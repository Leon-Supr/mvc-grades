using mvc_grades.Models;
using Microsoft.EntityFrameworkCore;

namespace mvc_grades.Data
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext(
            DbContextOptions<MySQLDbContext> options) : base(options) { }
            public DbSet<Act> Activities { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        // }
    }
}
