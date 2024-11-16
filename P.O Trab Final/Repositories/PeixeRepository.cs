using System.Collections.Generic;
using System.Linq;
using PeixariaProject.Data;
using PeixariaProject.Models;

namespace PeixariaProject.Repositories
{
    public class PeixeRepository : IRepository<Peixe>
    {
        private readonly ApplicationDbContext _context;

        public PeixeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Peixe peixe)
        {
            _context.Peixes.Add(peixe);
            _context.SaveChanges();
        }

        public Peixe GetById(int id)
        {
            return _context.Peixes.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Peixe> GetAll()
        {
            return _context.Peixes.ToList();
        }

        public void Update(Peixe peixe)
        {
            _context.Peixes.Update(peixe);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var peixe = GetById(id);
            if (peixe != null)
            {
                _context.Peixes.Remove(peixe);
                _context.SaveChanges();
            }
        }
    }
}