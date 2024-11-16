using Microsoft.EntityFrameworkCore;
using P.O_Trab_Final.Models;

namespace P.O_Trab_Final.DTOs{
    public class PeixariaContext : DbContext
    {
        public PeixariaContext(DbContextOptions<PeixariaContext> options) : base(options) { }

        public DbSet<Peixe> Peixes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }

}
