using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    [Table("Nota_Fiscal")]
    public class NotaFiscal
    {
        public int NotaFiscalId { get; set; }
        public decimal Valor { get; set; }
        [Column("Dt_Emissao")]
        public DateTime DataEmissao { get; set; }

        //Relacionamento many-to-many
        public List<Pagamento> Pagamentos { get; set; }
    }
}