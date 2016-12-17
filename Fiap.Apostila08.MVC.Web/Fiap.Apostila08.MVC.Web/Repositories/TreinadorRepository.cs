using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.DataAccess;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public class TreinadorRepository : ITreinadorRepository
    {
        private PokemonContext _context;

        //Construtor -> ctor -> tab tab
        public TreinadorRepository(PokemonContext context)
        {
            this._context = context;
        }

        public void Atualizar(Treinador treinador)
        {
            _context.Entry(treinador).State = System.Data.Entity.EntityState.Modified;
        }

        public List<Treinador> BuscarPor(Expression<Func<Treinador, bool>> filtro)
        {
            return _context.Treinadores.Where(filtro).ToList();
        }

        public Treinador BuscarPorId(int id)
        {
            return _context.Treinadores.Find(id);
        }

        public void Cadastrar(Treinador treinador)
        {
            _context.Treinadores.Add(treinador);
        }

        public List<Treinador> Listar()
        {
            return _context.Treinadores.ToList();
        }

        public void Remover(int id)
        {
            var treinador = BuscarPorId(id);
            _context.Treinadores.Remove(treinador);
        }
    }
}