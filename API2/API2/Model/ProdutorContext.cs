using Microsoft.EntityFrameworkCore;

namespace API2.Model
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }
        //tem q ser exatamente o mesmo nome no banco
        public DbSet<Produto> produto { get; set; }
    }
}
