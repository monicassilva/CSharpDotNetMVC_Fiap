using Fiap.Apostila09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila09.Web.MVC.Repositories
{
    public interface IExameRepository
    {
        void Cadastrar(Exame exame);
        List<Exame> Listar();
    }
}
