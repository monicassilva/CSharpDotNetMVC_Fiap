using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public interface ITreinadorRepository
    {
        void Cadastrar(Treinador treinador);
        List<Treinador> Listar();
        void Atualizar(Treinador treinador);
        void Remover(int id);
        Treinador BuscarPorId(int id);

        List<Treinador> BuscarPor(Expression<Func<Treinador, bool>> filtro);
    }
}
