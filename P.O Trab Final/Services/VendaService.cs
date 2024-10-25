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
    // Esta classe é responsável por gerenciar as operações relacionadas às vendas.
    public class VendaService
    {
        // Repositórios usados para acessar os dados de vendas e peixes.
        private readonly VendaRepository _vendaRepository; // Repositório para gerenciar vendas.
        private readonly PeixeRepository _peixeRepository; // Repositório para gerenciar peixes.
        private readonly VendaParser _vendaParser; // Classe para converter entre entidades e DTOs de venda.
        private readonly VendaValidator _vendaValidator; // Classe para validar os dados da venda.

        // Construtor da classe VendaService. Recebe o contexto do banco de dados e inicializa os repositórios e validadores.
        public VendaService(ApplicationDbContext context)
        {
            _vendaRepository = new VendaRepository(context); // Inicializa o repositório de vendas.
            _peixeRepository = new PeixeRepository(context); // Inicializa o repositório de peixes.
            _vendaParser = new VendaParser(); // Inicializa o parser de vendas.
            _vendaValidator = new VendaValidator(_peixeRepository); // Inicializa o validador de vendas, passando o repositório de peixes.
        }

        // Método para obter todas as vendas. Retorna uma lista de DTOs de vendas.
        public IEnumerable<VendaDTO> GetAllVendas()
        {
            var vendas = _vendaRepository.GetAll(); // Obtém todas as vendas do repositório.
            return vendas.Select(v => _vendaParser.ToDTO(v)); // Converte cada venda em um DTO e retorna.
        }

        // Método para obter uma venda específica pelo ID. Retorna um DTO de venda.
        public VendaDTO GetVendaById(int id)
        {
            var venda = _vendaRepository.GetById(id); // Obtém a venda pelo ID.
            return _vendaParser.ToDTO(venda); // Converte a venda em um DTO e retorna.
        }

        // Método para adicionar uma nova venda. Recebe um DTO de venda.
        public void AddVenda(VendaDTO vendaDto)
        {
            // Valida os dados da venda. Se forem válidos, prossegue.
            if (_vendaValidator.Validate(vendaDto))
            {
                var peixe = _peixeRepository.GetById(vendaDto.PeixeId); // Obtém o peixe relacionado à venda.
                var venda = _vendaParser.ToEntity(vendaDto); // Converte o DTO em uma entidade de venda.
                venda.CalcularPrecoTotal(peixe); // Calcula o preço total da venda com base no peixe.
                _vendaRepository.Add(venda); // Adiciona a venda ao repositório.
            }
        }

        // Método para atualizar uma venda existente. Recebe o ID e um DTO de venda.
        public void UpdateVenda(int id, VendaDTO vendaDto)
        {
            // Valida os dados da venda. Se forem válidos, prossegue.
            if (_vendaValidator.Validate(vendaDto))
            {
                var peixe = _peixeRepository.GetById(vendaDto.PeixeId); // Obtém o peixe relacionado à venda.
                var venda = _vendaParser.ToEntity(vendaDto); // Converte o DTO em uma entidade de venda.
                venda.Id = id; // Define o ID da venda a ser atualizada.
                venda.CalcularPrecoTotal(peixe); // Calcula o preço total da venda com base no peixe.
                _vendaRepository.Update(venda); // Atualiza a venda no repositório.
            }
        }

        // Método para deletar uma venda pelo ID.
        public void DeleteVenda(int id)
        {
            _vendaRepository.Delete(id); // Remove a venda do repositório pelo ID.
        }
    }
}