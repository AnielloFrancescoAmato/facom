using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArticoliGratis.Models
{
    
   public class Articolo
    {
       [Key]
       public int idArticolo { get; set; }
       public string titolo{ get; set; }
       public string testo{ get; set; }
       public virtual Utente autore{ get; set; }
       public virtual Categoria categoria{ get; set; }
       public virtual MetaTag metaTag{ get; set; }

    }

    public class Categoria
    {
        [Key]
        public int idCategoria{ get; set; }
        public string nome{ get; set; }
        public string descrizione{ get; set; }
        public virtual Categoria categoriaPadre{ get; set; }
        //Articoli o Direcotory web
        public virtual Sezione sezione{ get; set; }
        public virtual MetaTag metaTag{ get; set; }

    } 

    public class Sezione
    {
        [Key]
        public int idSezione{ get; set; }
        public string descrizione{ get; set; }
        public string nome{ get; set; }
        public virtual MetaTag metaTag{ get; set; }
    }

  public class MetaTag
  {
      [Key]
      public int idMetaTag{ get; set; }
      public string title{ get; set; }
      public string description{ get; set; }
      public string keywords{ get; set; }
  }

}
