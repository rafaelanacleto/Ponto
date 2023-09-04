using Microsoft.EntityFrameworkCore;
using Ponto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Persistence.Context
{
    public class ColaboradorContext : DbContext
    {
        public ColaboradorContext(DbContextOptions<ColaboradorContext> options) : base(options)
        {            
        }

        public DbSet<Colaborador> Colaboradors { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
