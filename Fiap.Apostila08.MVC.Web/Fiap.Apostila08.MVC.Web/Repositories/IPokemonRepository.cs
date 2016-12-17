using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public interface IPokemonRepository
    {

        void Cadastrar(Pokemon pokemon);
        List<Pokemon> Listar();
        Pokemon BuscarPorId(int id);
        void Atualizar(Pokemon pokemon);
        void Remover(int id);

    }
}
