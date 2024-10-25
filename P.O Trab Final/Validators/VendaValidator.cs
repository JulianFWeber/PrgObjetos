using PeixariaProject.DTOs;
using PeixariaProject.Exceptions;
using PeixariaProject.Repositories;


namespace PeixariaProject.Validators
{
    // Esta classe é responsável por validar as informações de venda antes que elas sejam processadas.
    public class VendaValidator
    {
        // Aqui esta armazenando uma referência ao repositório de peixes, que nos permitirá acessar os dados dos peixes.
        private readonly PeixeRepository _peixeRepository;

        // O construtor da classe recebe um PeixeRepository como parâmetro e o armazena na variável _peixeRepository.
        // Isso permite que a classe use esse repositório para validar as vendas.
        public VendaValidator(PeixeRepository peixeRepository)
        {
            _peixeRepository = peixeRepository;
        }

        // Este método valida os dados da venda. Ele recebe um objeto VendaDTO que contém as informações da venda.
        public bool Validate(VendaDTO vendaDto)
        {
            // Aqui buscamos o peixe correspondente ao ID fornecido na venda.
            var peixe = _peixeRepository.GetById(vendaDto.PeixeId);

            // Verificamos se o ID do peixe é válido (maior que zero). Se não for, lançamos uma exceção.
            if (vendaDto.PeixeId <= 0)
            {
                throw new InvalidId("Id do peixe a ser Vendido não encontrado");
            }

            // Verificamos se a quantidade vendida é válida (maior que zero). Se não for, lançamos uma exceção.
            if (vendaDto.QuantidadeVendida <= 0)
            {
                throw new InvalidQty("Quantidade de peixes a serem vendidos não pode ser menor ou igual a zero!!");
            }

            // Verificamos se a quantidade vendida não é maior do que a quantidade disponível em estoque.
            // Se for, lançamos uma exceção com uma mensagem informativa.
            if (vendaDto.QuantidadeVendida > peixe.Quantidade)
            {
                throw new InvalidQtyVenda($"Quantidade de peixes a serem vendidos não pode ser mais do que a quantidade de peixes em estoque: {peixe.Quantidade}");
            }

            // Se todas as validações passarem, retornamos true, indicando que a venda é válida.
            return true;
        }
    }
}