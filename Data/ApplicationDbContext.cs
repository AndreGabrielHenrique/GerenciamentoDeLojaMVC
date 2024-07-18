using Microsoft.EntityFrameworkCore;
using GerenciamentoDeLojaMVC.Models;

namespace GerenciamentoDeLojaMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>().HasKey(c => c.Id);
        }
    }
}
