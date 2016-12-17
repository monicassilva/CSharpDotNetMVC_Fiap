using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Nome { get; set; }
        public int Cp { get; set; }

        //Relacionamento
        public Treinador Treinador { get; set; }
        public int TreinadorId { get; set; }
    }
}