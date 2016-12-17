using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.DataAccess
{
    public class PokemonContext : DbContext
    {
        public DbSet<Treinador> Treinadores { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}