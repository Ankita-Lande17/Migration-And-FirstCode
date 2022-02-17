using Microsoft.EntityFrameworkCore;

namespace MigrationsAndCodeFirst.Entities
{
    public class SchoolDbContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder  optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-N0K161B\SQLEXPRESS;Database=SchoolDBCodeFirst;Trusted_Connection=True;");
        }
    }
}
