using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila07.MVC.Web.DataAccess
{
    public class VendasContext : DbContext
    {
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<NotaFiscal> Notas { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}