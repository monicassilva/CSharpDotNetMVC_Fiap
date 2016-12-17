using Fiap.Aula01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Aula01.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Calcular
        [HttpGet]
        public ActionResult Calcular()
        {
            return View();
        }

        // POST: Home/Calcular
        [HttpPost]
        public ActionResult Calcular(Soma churros)
        {
            var soma = churros.Numero1 + churros.Numero2;
            //return Content("A soma é " + soma); //Retorna um texto
            //Passar valores para a View
            ViewBag.resultado = soma;
            TempData["msg"] = "Soma realizada!";
            return View();
        }

    }
}