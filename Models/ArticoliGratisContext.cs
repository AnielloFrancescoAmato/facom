using Microsoft.EntityFrameworkCore;


namespace ArticoliGratis.Models
{
    public class ArticoliGratisContext : DbContext
    {
        public ArticoliGratisContext(DbContextOptions<ArticoliGratisContext> options)
                : base(options)
        {
        }

        public DbSet<Articolo> Articoli { get; set; }

        public DbSet<Utente> Autori{ get; set; }

    }
}

