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
    // A classe PeixeService é responsável por gerenciar as operações relacionadas aos peixes.
    public class PeixeService
    {
        // O repositório de Peixe é usado para interagir com a base de dados.
        private readonly PeixeRepository _peixeRepository;

        // O parser de Peixe converte entre o modelo de dados e o DTO (Data Transfer Object).
        private readonly PeixeParser _peixeParser;

        // O validador de Peixe verifica se os dados do peixe estão corretos antes de serem salvos.
        private readonly PeixeValidator _peixeValidator;

        // O construtor da classe PeixeService inicializa os repositórios, parsers e validadores.
        public PeixeService(ApplicationDbContext context)
        {
            // Inicializa o repositório de Peixe com o contexto do banco de dados.
            _peixeRepository = new PeixeRepository(context);
            // Inicializa o parser de Peixe.
            _peixeParser = new PeixeParser();
            // Inicializa o validador de Peixe.
            _peixeValidator = new PeixeValidator();
        }

        // Método para obter todos os peixes do repositório.
        public IEnumerable<PeixeDTO> GetAllPeixes()
        {
            // Chama o método GetAll do repositório para pegar todos os peixes.
            var peixes = _peixeRepository.GetAll();
            // Converte cada peixe para o formato DTO e retorna.
            return peixes.Select(p => _peixeParser.ToDTO(p));
        }

        // Método para obter um peixe específico pelo seu ID.
        public PeixeDTO GetPeixeById(int id)
        {
            // Busca o peixe pelo ID no repositório.
            var peixe = _peixeRepository.GetById(id);
            // Converte o peixe encontrado para o formato DTO e retorna.
            return _peixeParser.ToDTO(peixe);
        }

        // Método para adicionar um novo peixe.
        public void AddPeixe(PeixeDTO peixeDto)
        {
            // Valida os dados do peixe antes de adicionar.
            if (_peixeValidator.Validate(peixeDto))
            {
                // Converte o DTO para a entidade de Peixe.
                var peixe = _peixeParser.ToEntity(peixeDto);
                // Adiciona o peixe no repositório.
                _peixeRepository.Add(peixe);
            }
        }

        // Método para atualizar um peixe existente.
        public void UpdatePeixe(int id, PeixeDTO peixeDto)
        {
            // Valida os dados do peixe antes de atualizar.
            if (_peixeValidator.Validate(peixeDto))
            {
                // Converte o DTO para a entidade de Peixe.
                var peixe = _peixeParser.ToEntity(peixeDto);
                // Define o ID do peixe a ser atualizado.
                peixe.Id = id;
                // Atualiza o peixe no repositório.
                _peixeRepository.Update(peixe);
            }
        }

        // Método para deletar um peixe pelo seu ID.
        public void DeletePeixe(int id)
        {
            // Chama o método Delete do repositório para remover o peixe.
            _peixeRepository.Delete(id);
        }
    }
}