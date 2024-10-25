using PeixariaProject.Data;
using PeixariaProject.Models;
using PeixariaProject.Repositories;
using PeixariaProject.DTOs;
using PeixariaProject.Parsers;
using PeixariaProject.Validators;
using System.Collections.Generic;
using System.Linq;

namespace PeixariaProject.Services
{
    public class VendaService
    {
        private readonly VendaRepository _vendaRepository;
        private readonly PeixeRepository _peixeRepository;
        private readonly VendaParser _vendaParser;
        private readonly VendaValidator _vendaValidator;

        public VendaService(ApplicationDbContext context)
        {
            _vendaRepository = new VendaRepository(context);
            _peixeRepository = new PeixeRepository(context);
            _vendaParser = new VendaParser();
            _vendaValidator = new VendaValidator(_peixeRepository);
        }

        public IEnumerable<VendaDTO> GetAllVendas()
        {
            var vendas = _vendaRepository.GetAll();
            return vendas.Select(v => _vendaParser.ToDTO(v));
        }

        public VendaDTO GetVendaById(int id)
        {
            var venda = _vendaRepository.GetById(id);
            return _vendaParser.ToDTO(venda);
        }

        public void AddVenda(VendaDTO vendaDto)
        {
            if (_vendaValidator.Validate(vendaDto))
            {
                var peixe = _peixeRepository.GetById(vendaDto.PeixeId);
                var venda = _vendaParser.ToEntity(vendaDto);
                venda.CalcularPrecoTotal(peixe);
                _vendaRepository.Add(venda);
            }
        }

        public void UpdateVenda(int id, VendaDTO vendaDto)
        {
            if (_vendaValidator.Validate(vendaDto))
            {
                var peixe = _peixeRepository.GetById(vendaDto.PeixeId);
                var venda = _vendaParser.ToEntity(vendaDto);
                venda.Id = id;
                venda.CalcularPrecoTotal(peixe);
                _vendaRepository.Update(venda);
            }
        }

        public void DeleteVenda(int id)
        {
            _vendaRepository.Delete(id);
        }
    }
}