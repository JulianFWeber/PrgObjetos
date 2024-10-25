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
    public class PeixeController : ControllerBase
    {
        private readonly PeixeService _service;
        private readonly ILogger<PeixeController> _logger;

        public PeixeController(ApplicationDbContext context, ILogger<PeixeController> logger)
        {
            _service = new PeixeService(context);
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PeixeDTO>> GetAll()
        {
            _logger.LogInformation("Buscando todos os peixes");
            return Ok(_service.GetAllPeixes());
        }

        [HttpGet("{id}")]
        public ActionResult<PeixeDTO> GetById(int id)
        {
            _logger.LogInformation($"Buscando todos os peixes com id: {id}");
            var peixe = _service.GetPeixeById(id);
            if (peixe == null)
            {
                return NotFound();
            }
            return Ok(peixe);
        }

        [HttpPost]
        public ActionResult Add(PeixeDTO peixeDto)
        {
            _logger.LogInformation("Adição de peixe novo");
            _service.AddPeixe(peixeDto);
            return CreatedAtAction(nameof(GetById), new { id = peixeDto.Id }, peixeDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, PeixeDTO peixeDto)
        {
            _logger.LogInformation($"Atualização de peixe cujo id: {id}");
            _service.UpdatePeixe(id, peixeDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation($"Exclusão de peixe com id: {id}");
            _service.DeletePeixe(id);
            return NoContent();
        }
    }
}