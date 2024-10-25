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
        private readonly VendaService _service; // Serviço que lida com a lógica das vendas.

        // Construtor que inicializa o serviço de vendas
        public VendaController(ApplicationDbContext context, ILogger<VendaController> logger)
        {
            _service = new VendaService(context); // Criamos o serviço passando o contexto do banco.
        }

        // Método pra pegar todas as vendas.
        [HttpGet]
        public ActionResult<IEnumerable<VendaDTO>> GetAll()
        {
            return Ok(_service.GetAllVendas());
        }

        // Método pra pegar uma venda específica pelo ID.
        [HttpGet("{id}")]
        public ActionResult<VendaDTO> GetById(int id)
        {
            var venda = _service.GetVendaById(id); // Chama o serviço pra buscar a venda.
            if (venda == null) // Se não encontrar a venda...
            {
                return NotFound(); // Retorna 404.
            }
            return Ok(venda); // Se encontrar, retorna a venda.
        }

        // Método pra adicionar uma nova venda.
        [HttpPost]
        public ActionResult Add(VendaDTO vendaDto)
        {
            _service.AddVenda(vendaDto); // Chama o serviço pra adicionar a venda.
            return CreatedAtAction(nameof(GetById), new { id = vendaDto.PeixeId }, vendaDto); // Retorna 201 com a nova venda.
        }

        // Método pra atualizar uma venda existente.
        [HttpPut("{id}")]
        public ActionResult Update(int id, VendaDTO vendaDto)
        {
            _service.UpdateVenda(id, vendaDto); // Chama o serviço pra atualizar a venda.
            return NoContent(); // Retorna 204, sem conteúdo.
        }

        // Método pra deletar uma venda pelo ID.
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.DeleteVenda(id); // Chama o serviço pra deletar a venda.
            return NoContent(); // Retorna 204, sem conteúdo.
        }
    }
}