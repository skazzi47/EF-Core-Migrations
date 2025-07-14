using Microsoft.EntityFrameworkCore;

namespace AtividadeEF_Core.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }
        // DbSets personalizados, se quiser adicionar depois
        // public DbSet<Algo> Algos { get; set; }
    }
}

class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
}