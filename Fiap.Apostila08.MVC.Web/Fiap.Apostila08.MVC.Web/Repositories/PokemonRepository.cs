using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.DataAccess;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private PokemonContext _context;

        public PokemonRepository(PokemonContext context)
        {
            _context = context;
        }

        public void Atualizar(Pokemon pokemon)
        {
            _context.Entry(pokemon).State = 
                System.Data.Entity.EntityState.Modified;
        }

        public Pokemon BuscarPorId(int id)
        {
            return _context.Pokemon.Find(id);
        }

        public void Cadastrar(Pokemon pokemon)
        {
            _context.Pokemon.Add(pokemon);
        }

        public List<Pokemon> Listar()
        {
            return _context.Pokemon.Include("Treinador").ToList();
        }

        public void Remover(int id)
        {
            var pokemon = BuscarPorId(id);
            _context.Pokemon.Remove(pokemon);
        }
    }
}