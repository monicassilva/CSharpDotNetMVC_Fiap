using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Revisao.MVC.Web.Controllers
{
    public class DisciplinaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Disciplina disciplina)
        {
            _unit.DisciplinaRepository.Cadastrar(disciplina);
            _unit.Salvar();
            TempData["msg"] = "Disciplina cadastrada!";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}