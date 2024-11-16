using System.IO.Pipelines;
using PeixariaProject.DTOs;
using PeixariaProject.Models;

namespace PeixariaProject.Parsers
{
    // Essa classe é responsável por converter entre dois tipos diferentes de objetos: 
    // o modelo de dados (Peixe) e o objeto que usamos para transferir dados (PeixeDTO).
    public class PeixeParser
    {
        // Este método pega um objeto do tipo Peixe e transforma em um PeixeDTO.
        // Isso é útil porque o PeixeDTO geralmente é usado para enviar dados pela API.
        public PeixeDTO ToDTO(Peixe peixe)
        {
            return new PeixeDTO
            {
                Id = peixe.Id, // Copiamos o ID do peixe
                Nome = peixe.Nome, // Copiamos o nome do peixe
                LocalCaptura = peixe.LocalCaptura, // Onde o peixe foi capturado
                TipoCriacao = peixe.TipoCriacao, // Como o peixe foi criado (ex: Aquicultura)
                Conservacao = peixe.Conservacao, // Como o peixe é conservado
                Preco = peixe.Preco, // O preço do peixe
                Quantidade = peixe.Quantidade // A quantidade disponível
            };
        }

        // Este método faz o contrário do ToDTO: ele pega um PeixeDTO e transforma em um objeto Peixe.
        // Usamos isso quando queremos salvar os dados que recebemos da API no banco de dados.
        public Peixe ToEntity(PeixeDTO peixeDto)
        {
            return new Peixe
            {               
                Nome = peixeDto.Nome, // Copiamos o nome do DTO para o modelo
                LocalCaptura = peixeDto.LocalCaptura, // Copiamos o local de captura
                TipoCriacao = peixeDto.TipoCriacao, // Copiamos o tipo de criação
                Conservacao = peixeDto.Conservacao, // Copiamos a forma de conservação
                Preco = peixeDto.Preco, // Copiamos o preço
                Quantidade = peixeDto.Quantidade // Copiamos a quantidade
            };
        }
    }
}
