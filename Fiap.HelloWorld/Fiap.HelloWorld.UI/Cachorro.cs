using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Cachorro : Mamifero
    {
        public Cachorro(string nome):base(nome)
        {

        }

        public DateTime DataVenda { get; set; }
        public string Raca { get; set; }
        public decimal Preco { get; set; }
        public Sexo Sexo { get; set; }
    }
}
