using Fiap.Apostila09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila09.Web.MVC.DataAccess
{
    public class ConsultorioContext : DbContext
    {
        public DbSet<Exame> Exames { get; set; }
    }
}