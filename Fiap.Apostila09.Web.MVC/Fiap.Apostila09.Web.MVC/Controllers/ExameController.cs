using Fiap.Apostila09.Web.MVC.Models;
using Fiap.Apostila09.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila09.Web.MVC.Controllers
{
    public class ExameController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Exame exame)
        {
            if (ModelState.IsValid)
            {
                //Cadastrar
                _unit.ExameRepository.Cadastrar(exame);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                //Erro de validação
                return View(exame);
            }            
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}