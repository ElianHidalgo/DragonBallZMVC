using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DragonBallZMVC.Models
{
    public class Guerrero
    {
        [Key]
        public int GuerreroId { get; set; }

        [Required]
        public string Nombre{ get; set; }

        [Required]
        public string Raza { get; set; }
        [Required]
        public int NivelPoder { get; set; }

        [Required]
        public string Transformacion { get; set; }

        public virtual ICollection<Tecnica> Tecnicas { get; set; }
    }
}