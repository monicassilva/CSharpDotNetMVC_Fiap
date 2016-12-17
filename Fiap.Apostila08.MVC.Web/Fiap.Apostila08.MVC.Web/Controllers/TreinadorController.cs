using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class TreinadorController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Treinador treinador)
        {
            _unit.TreinadorRepository.Cadastrar(treinador);
            _unit.Salvar();
            TempData["msg"] = "Treinador cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        //Liberar a conexão do banco
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}