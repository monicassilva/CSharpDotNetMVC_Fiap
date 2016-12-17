using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila04.MVC.Web.Models
{
    public class Aniversariante
    {
        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public bool Festa { get; set; }

        [Display(Name ="Número de Convidados")]
        public int Convidados { get; set; }

        [Display(Name ="Orçamento")]
        public decimal Orcamento { get; set; }

        public string Bolo { get; set; }
    }
}