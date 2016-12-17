using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Apostila09.Web.MVC.Models;
using Fiap.Apostila09.Web.MVC.DataAccess;

namespace Fiap.Apostila09.Web.MVC.Repositories
{
    public class ExameRepository : IExameRepository
    {
        private ConsultorioContext _context;

        public ExameRepository(ConsultorioContext context)
        {
            _context = context;
        }

        public void Cadastrar(Exame exame)
        {
            _context.Exames.Add(exame);
        }

        public List<Exame> Listar()
        {
            return _context.Exames.ToList();
        }
    }
}