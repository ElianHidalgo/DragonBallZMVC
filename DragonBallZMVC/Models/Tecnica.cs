using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DragonBallZMVC.Models
{
    public class Tecnica
    {
        [Key]
        public int TecnicaId { get; set; }

        [Required]
        public string NombreTecnica { get; set; }

        [Required]
        public string Tipo { get; set; }
        [Required]
        public int NivelDano { get; set; }


        public virtual ICollection<Guerrero> Guerreros { get; set; }
    }
}