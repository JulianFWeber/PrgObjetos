using Microsoft.AspNetCore.Mvc;
using P.O_Trab_Final.DTOs;
using P.O_Trab_Final.Models;
using System.Collections.Generic;

namespace P.O_Trab_Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly PeixariaContext _context;

        public VendasController(PeixariaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddVenda(int peixeId)
        {
            var peixe = _context.Peixes.Find(peixeId);
            if (peixe == null) return NotFound();

            var venda = new Venda { PeixeVendido = peixe };
            venda.CalcularDesconto();
            _context.Vendas.Add(venda);
            _context.SaveChanges();

            return Ok(venda);
        }

        [HttpGet]
        public IEnumerable<Venda> GetVendas() => _context.Vendas.Include(v => v.PeixeVendido).ToList();
    }

}
