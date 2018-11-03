using Microsoft.EntityFrameworkCore;
using static ArticoliGratis.Models.Modelli;

namespace ArticoliGratis.Models
{
    public class ArticoliGratisContext : DbContext
    {
        public ArticoliGratisContext(DbContextOptions<ArticoliGratisContext> options)
                : base(options)
        {
        }

        public DbSet<Articolo> Articolo { get; set; }

        public DbSet<Autore> Autore{ get; set; }

    }
}