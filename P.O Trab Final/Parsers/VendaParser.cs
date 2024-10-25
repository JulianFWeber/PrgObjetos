using PeixariaProject.DTOs;
using PeixariaProject.Models;

namespace PeixariaProject.Parsers
{
    // Essa classe é responsável por converter entre a entidade Venda e o objeto VendaDTO.
    // O DTO (Data Transfer Object) é uma forma simplificada de representar os dados,
    // que é útil para enviar informações pela rede ou entre diferentes partes do código.

    public class VendaParser
    {
        // Esse método transforma uma entidade Venda em um VendaDTO.
        // Isso é útil quando queremos enviar os dados da venda para o cliente, por exemplo.
        public VendaDTO ToDTO(Venda venda)
        {
            return new VendaDTO
            {
                Id = venda.Id, // Pegamos o Id da venda
                PeixeId = venda.PeixeId, // Pegamos o Id do peixe vendido
                QuantidadeVendida = venda.QuantidadeVendida, // A quantidade que foi vendida
                PrecoTotal = venda.PrecoTotal // O preço total da venda
            };
        }

        // Esse método faz o oposto: pega um VendaDTO e cria uma entidade Venda.
        // Isso é usado quando recebemos dados de uma requisição, por exemplo, e precisamos
        // salvar esses dados no banco.
        public Venda ToEntity(VendaDTO vendaDto)
        {
            return new Venda
            {
                Id = vendaDto.Id, // Usamos o Id do DTO
                PeixeId = vendaDto.PeixeId, // Pegamos o Id do peixe do DTO
                QuantidadeVendida = vendaDto.QuantidadeVendida, // A quantidade vendida do DTO
                PrecoTotal = vendaDto.PrecoTotal, // O preço total do DTO
            };
        }
    }
}