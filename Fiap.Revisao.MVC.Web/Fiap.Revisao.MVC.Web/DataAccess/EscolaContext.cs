using Fiap.Revisao.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.DataAccess
{
    public class EscolaContext : DbContext
    {
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}