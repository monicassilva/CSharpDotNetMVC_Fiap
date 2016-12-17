using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.Models
{
    [Table("Item_Pedido")]
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        //Relacionamento bi-direcional many-to-one
        public Pedido Pedido { get; set; }

        public int Codigo { get; set; } //FK

    }
}