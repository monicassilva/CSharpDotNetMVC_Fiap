using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class PokemonController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Remover(int id)
        {
            _unit.PokemonRepository.Remover(id);
            _unit.Salvar();
            TempData["msg"] = "Removido";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            CarregarTreinadores();
            var pokemon = _unit.PokemonRepository.BuscarPorId(id);
            return View(pokemon);
        }

        [HttpPost]
        public ActionResult Editar(Pokemon pokemon)
        {
            _unit.PokemonRepository.Atualizar(pokemon);
            _unit.Salvar();
            TempData["msg"] = "Atualizado";
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            return View(_unit.PokemonRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarTreinadores();
            return View();
        }

        private void CarregarTreinadores()
        {
            //Carregar as informações para o combobox
            //Buscar todos os treinadores
            var lista = _unit.TreinadorRepository.Listar();
            //Passar o selectlist para a view
            ViewBag.treinadores = new SelectList(lista, "TreinadorId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Pokemon pokemon)
        {
            _unit.PokemonRepository.Cadastrar(pokemon);
            _unit.Salvar();
            TempData["msg"] = "Pokemon capturado";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}