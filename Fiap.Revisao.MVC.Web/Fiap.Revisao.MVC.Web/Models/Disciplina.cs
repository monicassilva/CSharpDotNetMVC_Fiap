using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Revisao.MVC.Web.Models
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public string Nome { get; set; }
        public string Ementa { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }
    }
}