using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Mamifero : Animal
    {
        //Construtor
        public Mamifero(string nome):base(nome)
        {
               
        }

        //Propriedade
        public bool Voa { get; set; }

        //Sobrescrita do método abstrato
        public override void Comer()
        {
            Console.WriteLine("Jantando");
        }

        //Sobrecrever o método Dormir
        public override void Dormir()
        {
            Console.WriteLine("Mamifero nanando");
        }

    }
}
