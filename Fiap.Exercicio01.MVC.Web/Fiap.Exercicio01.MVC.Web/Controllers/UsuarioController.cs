using Fiap.Exercicio01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio01.MVC.Web.Controllers
{
    public class UsuarioController : Controller
    {       
        [HttpGet] //Retorna a tela com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Receber as informações do formulário
        public ActionResult Cadastrar(Usuario usuario)
        {
            TempData["msg"] = "Cadastrado!";
            //Retorna para a página Resultado
            return View("Resultado",usuario); 
        }

    }
}