using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lojas_soul.Models;

namespace lojas_soul.Data
{
    public class lojas_soulContext : DbContext
    {
        public lojas_soulContext (DbContextOptions<lojas_soulContext> options)
            : base(options)
        {
        }

        public DbSet<lojas_soul.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<lojas_soul.Models.DadosPag>? DadosPag { get; set; }

        public DbSet<lojas_soul.Models.Fornecedor>? Fornecedor { get; set; }

        public DbSet<lojas_soul.Models.Produto>? Produto { get; set; }

        public DbSet<lojas_soul.Models.Venda>? Venda { get; set; }
    }
}
