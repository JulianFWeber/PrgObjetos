using System.Collections.Generic;
using System.Linq;
using PeixariaProject.Data;
using PeixariaProject.Models;

namespace PeixariaProject.Repositories
{
    public class VendaRepository : IRepository<Venda>
    {
        private readonly ApplicationDbContext _context;

        public VendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Venda venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }

        public Venda GetById(int id)
        {
            return _context.Vendas.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Venda> GetAll()
        {
            return _context.Vendas.ToList();
        }

        public void Update(Venda venda)
        {
            _context.Vendas.Update(venda);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var venda = GetById(id);
            if (venda != null)
            {
                _context.Vendas.Remove(venda);
                _context.SaveChanges();
            }
        }
    }
}