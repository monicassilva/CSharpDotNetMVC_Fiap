using Fiap.Apostila09.Web.MVC.DataAccess;
using Fiap.Apostila09.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila09.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private ConsultorioContext _context = new ConsultorioContext();

        private IExameRepository _exameRepository;

        public IExameRepository ExameRepository
        {
            get
            {
                if (_exameRepository == null)
                {
                    _exameRepository = new ExameRepository(_context);
                }
                return _exameRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        private void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}