using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeixariaProject.Services;
using PeixariaProject.DTOs;
using System.Collections.Generic;
using PeixariaProject.Data;

namespace PeixariaProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaService _service;
        private readonly ILogger<VendaController> _logger;

        public VendaController(ApplicationDbContext context, ILogger<VendaController> logger)
        {
            _service = new VendaService(context);
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VendaDTO>> GetAll()
        {
            _logger.LogInformation("Procurando todas as vendas");
            return Ok(_service.GetAllVendas());
        }

        [HttpGet("{id}")]
        public ActionResult<VendaDTO> GetById(int id)
        {
            _logger.LogInformation($"Procurando todas as vendas cujo id: {id}");
            var venda = _service.GetVendaById(id);
            if (venda == null)
            {
                return NotFound();
            }
            return Ok(venda);
        }

        [HttpPost]
        public ActionResult Add(VendaDTO vendaDto)
        {
            _logger.LogInformation("Adicionando nova venda");
            _service.AddVenda(vendaDto);
            return CreatedAtAction(nameof(GetById), new { id = vendaDto.PeixeId }, vendaDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, VendaDTO vendaDto)
        {
            _logger.LogInformation($"Atualizando venda qual id: {id}");
            _service.UpdateVenda(id, vendaDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation($"Remoção de venda com id: {id}");
            _service.DeleteVenda(id);
            return NoContent();
        }
    }
}