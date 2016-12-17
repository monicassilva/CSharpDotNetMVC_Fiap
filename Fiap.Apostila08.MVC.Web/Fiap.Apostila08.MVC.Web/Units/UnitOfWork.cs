using Fiap.Apostila08.MVC.Web.DataAccess;
using Fiap.Apostila08.MVC.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Units
{
    public class UnitOfWork : IDisposable
    {
        private PokemonContext _context = new PokemonContext();

        private IPokemonRepository _pokemonRepository;

        public IPokemonRepository PokemonRepository
        {
            get
            {
                if (_pokemonRepository == null)
                {
                    _pokemonRepository = 
                        new PokemonRepository(_context);
                }
                return _pokemonRepository;
            }
        }

        //propfull -> tab tab
        private ITreinadorRepository _treinadorRepository;

        public ITreinadorRepository TreinadorRepository
        {
            get
            {
                if (_treinadorRepository == null)
                {
                    _treinadorRepository = 
                            new TreinadorRepository(_context);
                }
                return _treinadorRepository;
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
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);//Fecha a conexão
            GC.SuppressFinalize(this); //Finaliza o UnitOfWork
        }
    }
}