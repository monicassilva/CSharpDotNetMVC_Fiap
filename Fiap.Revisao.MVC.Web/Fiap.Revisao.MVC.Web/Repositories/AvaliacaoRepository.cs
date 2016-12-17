using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Revisao.MVC.Web.Models;
using Fiap.Revisao.MVC.Web.DataAccess;

namespace Fiap.Revisao.MVC.Web.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private EscolaContext _context;

        public AvaliacaoRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Aprovar(int id)
        {
            var prova = _context.Avaliacoes.Find(id);
            prova.Status = Status.Aprovado;
        }

        public void Cadastrar(Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
        }

        public List<Avaliacao> Listar()
        {
            return _context.Avaliacoes.Include("Disciplina").ToList();
        }
    }
}