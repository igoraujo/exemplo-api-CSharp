using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Grupo> Grupo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Indica que a tatebela no banco corresponde a classe no C#
            modelBuilder.Entity<Produto>().ToTable("produto");
            modelBuilder.Entity<Grupo>().ToTable("grupo");
        }
    }

}
