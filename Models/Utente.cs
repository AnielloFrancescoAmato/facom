using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArticoliGratis.Models
{
     public class Utente
    {
        [Key]
        public int idUtente{ get; set; }
        public string UserName{ get; set; }
        public string Password{ get; set; }
        public virtual DatiAnagraficiUtente DatiAnagraficiUtnte{ get; set; }
        public virtual DatiAziendali DatiAziendali{ get; set; }
     
    }
    public class CategoriaAzienda{
      [Key]
      public int idCategoriaAzienda{ get; set; }
      public string NomeCategoria{ get; set; }
      public string DescrizioneCategoria{ get; set; }
 
  }

  public class TitoloDiStudio{
      [Key]
      public int idTitoloDiStudio{ get; set; }
      public string NomeTitolodiStudio{ get; set; }
      public string DescrizioneTitolodiStudio{ get; set; }
  }

  public class Settore{
      [Key]
      public int idSettore{ get; set; }
      public string NomeSettore{ get; set; }
      public string DescrizioneSettore{ get; set; }
  }
 public class Lavoro{
      [Key]
      public int idLavoro{ get; set; }
      public string NomeLavoro{ get; set; }
      public string DescrizioneLavoro{ get; set; }
  }
 public class Sesso{
      [Key]
      public int idSesso{ get; set; }
      public string NomeSesso{ get; set; }
      public string DescrizioneSesso{ get; set; }
  }

  public class DatiAnagraficiUtente{
      [Key]
      public int idAnagraficiUtente{ get; set; }
       
        public string Nome{ get; set; }
        public string Cognome{ get; set; }
        public string EmailPersonale{ get; set; }
        public string Regione{ get; set; }
        public string Provincia{ get; set; }
        public string Comune{ get; set; }
        public DataType DataDiNascita{ get; set; }
        public string TelefonoFisso{ get; set; }
        public string TelefonoCellulare{ get; set; }
        public string SitoWebPersonale{ get; set; }
        public virtual Sesso sesso{ get; set; }
        public virtual Lavoro lavoro { get; set; }
        public virtual TitoloDiStudio titolodiStudio{ get; set; }
        public bool LiberoProfessionista{ get; set; }
        public virtual Settore settore{get; set;}
        
  }
  public class DatiAziendali{
        [Key]
        public int idDatiAziendali{ get; set; }
        public bool Azienda{ get; set; }
        public string NomeAzienda{ get; set; } 
        public string DescrizioneAzienda{ get; set; }
        public virtual CategoriaAzienda CategoriaAzienda{ get; set; }
        public string EmailAzienda{ get; set; }      
           
  }

  /* 
    public class TipologiaUtente
    {
        [Key]
        public int idTipologiaUtente{ get; set; }
        public string descrizione{ get; set; }
        public bool? leggiArticolo{ get; set; }
        public bool? creaArticolo{ get; set; }
        public bool? modificaArticolo{ get; set; }
        public bool? votaArticolo{ get; set; }
        public bool? eliminaArticolo{ get; set; }
        public bool? creaCategoriaArticoli{ get; set; }
        public bool? modificaCategoriaArticoli{ get; set; }
        public bool? eliminaCategoriaArticoli{ get; set; }
        public bool? votaCategoriaArticoli{ get; set; }
        public bool? creaCategoriaDirecoty{ get; set; }
        public bool? modificaCategoriaDirecoty{ get; set; }
        public bool? eliminaCategoriaDirecoty{ get; set; }
        public bool? votaCategoriaDirectory{ get; set; }
        public bool? segnalaSito{ get; set; }

    }

*/ 

}