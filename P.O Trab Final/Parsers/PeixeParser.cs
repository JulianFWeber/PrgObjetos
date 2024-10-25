using System.IO.Pipelines;
using PeixariaProject.DTOs;
using PeixariaProject.Models;

namespace PeixariaProject.Parsers
{
    public class PeixeParser
    {
        public PeixeDTO ToDTO(Peixe peixe)
        {
            return new PeixeDTO
            {
                Id = peixe.Id,
                Nome = peixe.Nome,
                LocalCaptura = peixe.LocalCaptura,
                TipoCriacao = peixe.TipoCriacao,
                Conservacao = peixe.Conservacao,
                Preco = peixe.Preco,
                Quantidade = peixe.Quantidade
            };
        }

        public Peixe ToEntity(PeixeDTO peixeDto)
        {
            return new Peixe
            {               
                Nome = peixeDto.Nome,
                LocalCaptura = peixeDto.LocalCaptura,
                TipoCriacao = peixeDto.TipoCriacao,
                Conservacao = peixeDto.Conservacao,
                Preco = peixeDto.Preco,
                Quantidade = peixeDto.Quantidade
            };
        }
    }
}
