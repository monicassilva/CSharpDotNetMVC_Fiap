using Fiap.Revisao.MVC.Web.DataAccess;
using Fiap.Revisao.MVC.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.Units
{
    public class UnitOfWork : IDisposable
    {
        private EscolaContext _context = new EscolaContext();

        private IDisciplinaRepository _disciplinaRepository;

        public IDisciplinaRepository DisciplinaRepository
        {
            get
            {
                if (_disciplinaRepository == null)
                {
                    _disciplinaRepository =
                        new DisciplinaRepository(_context);
                }
                return _disciplinaRepository;
            }
        }

        private IAvaliacaoRepository _avaliacaoRepository;

        public IAvaliacaoRepository AvaliacaoRepository
        {
            get
            {
                if (_avaliacaoRepository == null)
                {
                    _avaliacaoRepository =
                        new AvaliacaoRepository(_context);
                }
                return _avaliacaoRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        public void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}