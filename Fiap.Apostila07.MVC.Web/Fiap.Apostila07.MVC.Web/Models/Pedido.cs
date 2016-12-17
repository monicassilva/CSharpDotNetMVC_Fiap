using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    public class Pedido
    {
        [Key]
        public int Codigo { get; set; }
        [Display(Name = "Data Pedido")]
        [Column("Dt_Pedido")]
        public DateTime DataPedido { get; set; }
        public string Cliente { get; set; }
        public bool Internet { get; set; }

        //Relacionamento one-to-one
        public NotaFiscal Nota { get; set; }

        //Relacionamento one-to-many
        public virtual List<ItemPedido> Itens { get; set; }
    }
}