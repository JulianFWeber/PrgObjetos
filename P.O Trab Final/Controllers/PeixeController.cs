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

        // Construtor que recebe o contexto do banco e o logger.
        public PeixeController(ApplicationDbContext context, ILogger<PeixeController> logger)
        {
            _service = new PeixeService(context); // Inicializa o serviço com o contexto do banco.
        }

        // Método que pega todos os peixes.
        [HttpGet]
        public ActionResult<IEnumerable<PeixeDTO>> GetAll()
        {
            return Ok(_service.GetAllPeixes()); // Retorna todos os peixes com status 200.
        }

        // Método que pega um peixe pelo ID.
        [HttpGet("{id}")]
        public ActionResult<PeixeDTO> GetById(int id)
        {
            var peixe = _service.GetPeixeById(id); // Busca o peixe pelo ID.
            if (peixe == null) // Se não encontrar...
            {
                return NotFound(); // Retorna 404.
            }
            return Ok(peixe); // Se encontrar, retorna o peixe com status 200.
        }

        // Método que adiciona um novo peixe.
        [HttpPost] 
        public ActionResult Add(PeixeDTO peixeDto)
        {
            _service.AddPeixe(peixeDto); // Adiciona o peixe usando o serviço.
            return CreatedAtAction(nameof(GetById), new { id = peixeDto.Id }, peixeDto); // Retorna 201 e o novo recurso.
        }

        // Método que atualiza um peixe existente.
        [HttpPut("{id}")]
        public ActionResult Update(int id, PeixeDTO peixeDto)
        {
            _service.UpdatePeixe(id, peixeDto); // Atualiza o peixe.
            return NoContent(); // Retorna 204 (sem conteúdo).
        }

        // Método que deleta um peixe pelo ID.
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.DeletePeixe(id); // Deleta o peixe.
            return NoContent(); // Retorna 204 (sem conteúdo).
        }
    }
}