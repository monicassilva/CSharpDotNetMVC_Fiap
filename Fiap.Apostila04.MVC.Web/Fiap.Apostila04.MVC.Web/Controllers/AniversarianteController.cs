using Fiap.Apostila04.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila04.MVC.Web.Controllers
{
    public class AniversarianteController : Controller
    {
        //Simular o Banco de Dados
        private static List<Aniversariante> _lista = new List<Aniversariante>();

        [HttpGet] //Abre a página com o formulário
        public ActionResult Cadastrar()
        {
            //Criar uma lista para preencher o "select"
            List<string> sabores = new List<string>();
            sabores.Add("Morango");
            sabores.Add("Leite ninho com chocolte branco");
            sabores.Add("Prestigio");
            sabores.Add("Churros");

            //Passar a lista pra tela
            ViewBag.bolo = new SelectList(sabores);

            return View();
        }

        [HttpPost] //Recebe as informações do formulário
        public ActionResult Cadastrar(Aniversariante niver)
        {
            //cadastra
            _lista.Add(niver);
            //mensagem de sucesso
            TempData["msg"] = "Cadastrado!";
            return Redirect("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passa a lista para a view
            return View(_lista);
        }
    }
}