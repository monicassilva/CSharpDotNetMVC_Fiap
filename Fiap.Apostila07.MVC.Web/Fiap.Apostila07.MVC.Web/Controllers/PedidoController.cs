using Fiap.Apostila07.MVC.Web.DataAccess;
using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila07.MVC.Web.Controllers
{
    public class PedidoController : Controller
    {
        private VendasContext _context = new VendasContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pedido pedido)
        {
            //Cadastra no Banco
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Pedido registrado!";
            return Redirect("Cadastrar");
        }
    }
}