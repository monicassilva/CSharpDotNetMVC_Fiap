using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Apostila06.MVC.Web.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Ingredientes { get; set; }

        [Column("BORDA_RECHEADA")]
        [Display(Name ="Pode ter borda recheada?")]
        public bool BordaRecheada { get; set; }

        [Required]
        public decimal Valor { get; set; }
    }
}