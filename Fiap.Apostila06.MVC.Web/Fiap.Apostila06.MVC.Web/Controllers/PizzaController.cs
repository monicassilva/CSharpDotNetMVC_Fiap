using Fiap.Apostila06.MVC.Web.DataAccess;
using Fiap.Apostila06.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila06.MVC.Web.Controllers
{
    public class PizzaController : Controller
    {
        private PizzariaContext _context = new PizzariaContext();

        [HttpGet]                  //mesmo nome do name do input
        public ActionResult Buscar(string nomeBusca)
        {
            //Buscar as pizzas usando o nomeBusca
            var pizzas = _context.Pizzas.Where(churros =>
                churros.Nome.Contains(nomeBusca)).ToList();
            //Retornar para a view Listar passando a lista de pizzas
            return View("Listar",pizzas);
        }

        [HttpPost]
        public ActionResult Remover(int id)
        {
            //Busca a pizza no banco de dados
            var pizza = _context.Pizzas.Find(id);
            //Remove a pizza
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();
            //Mensagem de sucesso 
            TempData["msg"] = "Pizza removida com sucesso!";
            //Retorna para a página de lista
            return RedirectToAction("Listar");
        }

        [HttpGet] //Abre a tela para a atualização
        public ActionResult Editar(int id)
        {
            //Busca a pizza no banco de dados
            var pizza = _context.Pizzas.Find(id);
            //Passar a pizza para a View
            return View(pizza);
        }

        [HttpPost] //Atualiza no banco de dados
        public ActionResult Editar(Pizza pizza)
        {
            //Atualiza no banco de dados
            _context.Entry(pizza).State = EntityState.Modified;
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Atualizado!";
            //Retorna para a listagem
            return RedirectToAction("Listar");
        }

        //Abre a tela de cadastro
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        //Cadastro da pizza
        [HttpPost]
        public ActionResult Cadastrar(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();
            TempData["msg"] = "Pizza cadastrada!";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Manda a lista de pizzas para a tela
            return View(_context.Pizzas.ToList());
        }
    }
}