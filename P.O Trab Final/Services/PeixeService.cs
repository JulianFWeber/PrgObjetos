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
    public class PeixeService
    {
        private readonly PeixeRepository _peixeRepository;
        private readonly PeixeParser _peixeParser;
        private readonly PeixeValidator _peixeValidator;

        public PeixeService(ApplicationDbContext context)
        {
            _peixeRepository = new PeixeRepository(context);
            _peixeParser = new PeixeParser();
            _peixeValidator = new PeixeValidator();
        }

        public IEnumerable<PeixeDTO> GetAllPeixes()
        {
            var peixes = _peixeRepository.GetAll();
            return peixes.Select(p => _peixeParser.ToDTO(p));
        }

        public PeixeDTO GetPeixeById(int id)
        {
            var peixe = _peixeRepository.GetById(id);
            return _peixeParser.ToDTO(peixe);
        }

        public void AddPeixe(PeixeDTO peixeDto)
        {
            if (_peixeValidator.Validate(peixeDto))
            {
                var peixe = _peixeParser.ToEntity(peixeDto);
                _peixeRepository.Add(peixe);
            }
        }

        public void UpdatePeixe(int id, PeixeDTO peixeDto)
        {
            if (_peixeValidator.Validate(peixeDto))
            {
                var peixe = _peixeParser.ToEntity(peixeDto);
                peixe.Id = id;
                _peixeRepository.Update(peixe);
            }
        }

        public void DeletePeixe(int id)
        {
            _peixeRepository.Delete(id);
        }
    }
}