using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.DataAccess;

namespace Fiap.Revisao.MVC.Web.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private EscolaContext _context;

        public DisciplinaRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Disciplina disciplina)
        {
            _context.Disciplinas.Add(disciplina);
        }

        public List<Disciplina> Listar()
        {
            return _context.Disciplinas.ToList();
        }
    }
}