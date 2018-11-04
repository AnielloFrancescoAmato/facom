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
        public DbSet<Sezione> Sezioni{ get; set; }
        public DbSet<Categoria> Categorie {get; set; }
        public DbSet<MetaTag> MetaTag {get; set; }
        public DbSet<Utente> Utenti{ get; set; }
        public DbSet<DatiAnagraficiUtente> DatiAnagraficiUtenti{ get; set; }
        public DbSet<DatiAziendali> DatiAziende{ get; set; }
        public DbSet<CategoriaAzienda> CategorieAziende{ get; set; }
        public DbSet<TitoloDiStudio> TitoliDiStudio{  get; set; }
        public DbSet<Settore> Settori{  get; set; }
        public DbSet<Lavoro> Lavori{  get; set; }
        public DbSet<Sesso> Sessi{  get; set; }
    }
}

