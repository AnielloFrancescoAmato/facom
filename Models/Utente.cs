using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArticoliGratis.Models
{
    public class Utente
    {
        [Key]
        public int idUtente { get; set; }
        [Required(ErrorMessage = "Il campo User Name è richiesto")]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Il campo Password è richiesto")]
        [DisplayName("Password")]
        public string Password { get; set; }
        public virtual DatiAnagraficiUtente DatiAnagraficiUtnte { get; set; }
        public virtual DatiAziendali DatiAziendali { get; set; }

    }
    public class CategoriaAzienda
    {
        [Key]
        public int idCategoriaAzienda { get; set; }
        [Required(ErrorMessage = "Il campo nome è richiesto")]
        [DisplayName("Nome Categoria")]
        public string NomeCategoria { get; set; }
        [DisplayName("Descrizione Categoria")]
        public string DescrizioneCategoria { get; set; }

    }

    public class TitoloDiStudio
    {
        [Key]
        public int idTitoloDiStudio { get; set; }
        [Required(ErrorMessage = "Il campo nome è richiesto")]
        [DisplayName("Nome Titolo di Studio")]
        public string NomeTitolodiStudio { get; set; }
        [DisplayName("Descrizione Titolo di Studio")]
        public string DescrizioneTitolodiStudio { get; set; }
    }

    public class Settore
    {
        [Key]
        public int idSettore { get; set; }
        [Required(ErrorMessage = "Il campo nome è richiesto")]
        [DisplayName("Nome Settore")]
        public string NomeSettore { get; set; }
        [DisplayName("Descrizione Settore")]
        public string DescrizioneSettore { get; set; }
    }
    public class Lavoro
    {
        [Key]
        public int idLavoro { get; set; }
        [Required(ErrorMessage = "Il campo nome è richiesto")]
        [DisplayName("Nome Lavoro")]
        public string NomeLavoro { get; set; }
        [DisplayName("Descrizione Lavoro")]
        public string DescrizioneLavoro { get; set; }
    }
    public class Sesso
    {
        [Key]
        public int idSesso { get; set; }
        [Required(ErrorMessage = "Il campo Nome Sesso è richiesto")]
        [DisplayName("Sesso")]
        public string NomeSesso { get; set; }
        public string DescrizioneSesso { get; set; }
    }

    public class DatiAnagraficiUtente
    {
        [Key]
        public int idAnagraficiUtente { get; set; }
        [Required(ErrorMessage = "Il campo Nome è richiesto")]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Il campo Cognome è richiesto")]
        [DisplayName("Cognome")]
        public string Cognome { get; set; }
        [Required(ErrorMessage = "Il campo Cognome è richiesto")]
        [DisplayName("Email Personale")]
        public string EmailPersonale { get; set; }

        [DisplayName("Data Di Nascita")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DataDiNascita { get; set; }
        [Required(ErrorMessage = "Il campo Telefono Fisso è richiesto")]
        [DisplayName("Telefono Fisso")]
        public string TelefonoFisso { get; set; }
        [Required(ErrorMessage = "Il campo Telefono Cellulare è richiesto")]
        [DisplayName("Telefono Cellulare")]
        public string TelefonoCellulare { get; set; }
        [Required(ErrorMessage = "Il campo Sito Web Personale è richiesto")]
        [DisplayName("Sito Web Personale")]
        public string SitoWebPersonale { get; set; }
        
        [DisplayName("Sesso")]
        public virtual Sesso sesso { get; set; }
        
        [DisplayName("Lavoro")]
        public virtual Lavoro lavoro { get; set; }
        
        [DisplayName("Titolo Di Studio")]
        public virtual TitoloDiStudio titolodiStudio { get; set; }
        public bool LiberoProfessionista { get; set; }
        [DisplayName("Settore")]
        public virtual Settore settore { get; set; }
        
        public virtual Comune comune{ get; set; }

    }
    public class DatiAziendali
    {
        [Key]
        public int idDatiAziendali { get; set; }
        public bool Azienda { get; set; }
        public string NomeAzienda { get; set; }
        public string DescrizioneAzienda { get; set; }
        public virtual CategoriaAzienda CategoriaAzienda { get; set; }
        public string EmailAzienda { get; set; }

    }

    public class Regione{
        [Key]
        public int idRegione { get; set; }
        [Required(ErrorMessage = "Il campo Nome Regione è richiesto")]
        [DisplayName("Nome Regione")]
        public string NomeRegione { get; set; }
        public string DescrizioneRegione { get; set; }
    }


    public class Provincia{
        [Key]
        public int idProvincia { get; set; }
        [Required(ErrorMessage = "Il campo Nome Provincia è richiesto")]
        [DisplayName("Nome Provincia")]
        public string NomeProvincia { get; set; }
        public string DescrizioneProvincia { get; set; }
        public virtual Regione Regione{ get; set; }
    }


    public class Comune{
        [Key]
        public int idComune { get; set; }
        [Required(ErrorMessage = "Il campo Nome Comune è richiesto")]
        [DisplayName("Nome Comune")]
        public string NomeComune { get; set; }
        public string DescrizioneComune { get; set; }
        public virtual Provincia Provincia{ get; set; }
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