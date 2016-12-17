using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila09.Web.MVC.Models
{
    public class Exame
    {
        public int ExameId { get; set; }

        [Required(ErrorMessage = "Preencha a descrição")]
        [StringLength(255)]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        [Range(0,5)]
        public int Gravidade { get; set; }

        public decimal Preco { get; set; }
    }
}
