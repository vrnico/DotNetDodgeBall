using Microsoft.EntityFrameworkCore;

namespace DodgeBall.Models
{
    public class DodgeBallDbContext : DbContext
    {
        public DodgeBallDbContext()
        {
        }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=DodgeBall;uid=root;pwd=root;");
        }

        public DodgeBallDbContext(DbContextOptions<DodgeBallDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}