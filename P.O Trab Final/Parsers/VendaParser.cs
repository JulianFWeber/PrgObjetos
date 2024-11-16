using PeixariaProject.DTOs;
using PeixariaProject.Models;

namespace PeixariaProject.Parsers
{
    public class VendaParser
    {
        public VendaDTO ToDTO(Venda venda)
        {
            return new VendaDTO
            {
                Id = venda.Id,
                PeixeId = venda.PeixeId,
                QuantidadeVendida = venda.QuantidadeVendida,
                PrecoTotal = venda.PrecoTotal
            };
        }
        public Venda ToEntity(VendaDTO vendaDto)
        {
            return new Venda
            {
                Id = vendaDto.Id,
                PeixeId = vendaDto.PeixeId,
                QuantidadeVendida = vendaDto.QuantidadeVendida,
                PrecoTotal = vendaDto.PrecoTotal,
            };
        }
    }
}