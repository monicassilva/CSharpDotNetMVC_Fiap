using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Pagamento
    {
        [Key]
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int Parcela { get; set; }

        //Relacionamento many-to-many
        public List<NotaFiscal> Notas { get; set; }

    }
}