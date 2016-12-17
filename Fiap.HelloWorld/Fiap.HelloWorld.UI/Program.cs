using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Mamifero
            Mamifero m = new Mamifero("Morcego");
            //m.Nome = "Morcego";
            m.Idade = 1;

            Console.WriteLine(m.Nome);

            Cachorro dog = new Cachorro("Duke")
            {
                Raca = "Pug",
                Voa = false
            };

            Console.ReadLine();
        }
    }
}
