using Fiap.Apostila07.MVC.Web.DataAccess;
using Fiap.Apostila07.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila07.MVC.Web.Controllers
{
    public class ItemPedidoController : Controller
    {
        private VendasContext _context = new VendasContext();

        [HttpGet]
        public ActionResult Buscar(int codigo)
        {
            var itens = _context
                .ItensPedido.Include("Pedido").Where(i => i.Codigo == codigo).ToList();

            CarregarPedidos();

            //Nome da View e a lista para preencher a tabela
            return View("Listar",itens);
        }

        //Listar os Itens!!!!!!
        [HttpGet]
        public ActionResult Listar()
        {
            CarregarPedidos();

            //include -> carrega o relacionamento na busca
            var itens = _context.ItensPedido.Include("Pedido").ToList();
            return View(itens);
        }

        private void CarregarPedidos()
        {
            var pedidos = _context.Pedidos.ToList();
            ViewBag.opcoes = new SelectList(pedidos, "Codigo", "Cliente");
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Carregar os pedidos do banco de dados
            var pedidos = _context.Pedidos.ToList();
            //Passar a lista para a View carregar o select
            ViewBag.opcoes = new SelectList(pedidos,"Codigo","Cliente");
            return View();
        }

        //Faz o POST!
        [HttpPost]
        public ActionResult Cadastrar(ItemPedido item)
        {
            _context.ItensPedido.Add(item);
            _context.SaveChanges();
            TempData["msg"] = "Item registrado!";
            //Redireciona para o GET para passar a lista de pedidos
            return RedirectToAction("Cadastrar");
        }

    }
}