using Microsoft.AspNetCore.Mvc;
using P.O_Trab_Final.DTOs;
using P.O_Trab_Final.Models;
using System.Collections.Generic;

namespace P.O_Trab_Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeixesController : ControllerBase
    {
        private readonly PeixariaContext _context;

        public PeixesController(PeixariaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Peixe> GetPeixes() => _context.Peixes.ToList();

        [HttpPost]
        public IActionResult AddPeixe(Peixe peixe)
        {
            _context.Peixes.Add(peixe);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPeixes), new { id = peixe.Id }, peixe);
        }
    }

}
