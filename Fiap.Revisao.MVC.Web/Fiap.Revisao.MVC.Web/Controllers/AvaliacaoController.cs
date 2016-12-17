using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.MVC.Web.Controllers
{
    public class AvaliacaoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Aprovar(int id)
        {
            _unit.AvaliacaoRepository.Aprovar(id);
            _unit.Salvar();
            TempData["msg"] = "Prova aprovada";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.AvaliacaoRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.DisciplinaRepository.Listar();
            ViewBag.disciplinas =
                new SelectList(lista,"DisciplinaId","Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Avaliacao avaliacao)
        {
            _unit.AvaliacaoRepository.Cadastrar(avaliacao);
            _unit.Salvar();
            TempData["msg"] = "Cadastro realizado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}