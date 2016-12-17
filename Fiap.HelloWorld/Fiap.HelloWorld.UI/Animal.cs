using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    abstract class Animal
    {
        //Construtor
        public Animal(string nome)
        {
            this.Nome = nome;
        }

        //Campo (Field)
        private string _nome;

        //Propriedades (gets e sets)
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade { get; set; }

        //Métodos
        public abstract void Comer();

        //virtual -> permite a sobrescrita
        public virtual void Dormir()
        {
            Console.WriteLine("Dormindo muito");
        }
    }
}
