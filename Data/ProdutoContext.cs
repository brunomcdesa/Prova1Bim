using Microsoft.EntityFrameworkCore;
using Prova1Bim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1Bim.Data
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> produtos { get; set; }

        public ProdutoContext(DbContextOptions<ProdutoContext> opt) : base(opt) { }

    }
}
