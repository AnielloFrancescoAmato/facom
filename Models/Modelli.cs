using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArticoliGratis.Models
{
   
    public class Utente
    {
        [Key]
        public int idUtente{ get; set; }
        public string Nome{ get; set; }
        public string Cognome{ get; set; }

    }
    public class Articolo
    {
       [Key]
       public int idArticolo { get; set; }
       public string titolo{ get; set; }
       public string testo{ get; set; }
       public virtual Utente autore{ get; set; }
    

    }
}