using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREADS2021.Models.Dominio;

namespace WEBCOREADS2021.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }
        //injeção de dependencia.

        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Peixe> Peixes { get; set; }
        public DbSet<Premiacao> Premiacoes { get; set; }
        public DbSet<Pescador> Pescadores { get; set; }

    }
}
