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

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(c => c.Id);
        }
    }
}
