using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Treinador
    {
        public int TreinadorId { get; set; }
        public string Nome { get; set; }
        public int Level { get; set; }

        //Relacionamento
        public List<Pokemon> Pokemon { get; set; }
    }
}