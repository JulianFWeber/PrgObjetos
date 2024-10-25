using PeixariaProject.DTOs;
using PeixariaProject.Exceptions;
using PeixariaProject.Repositories;

// Espaço criado para validar que novos posts atendam as regras do projeto, informações fora das aceitadas devem ser recusadas. (Infelizmente.. lago != Lago)
namespace PeixariaProject.Validators
{
    public class VendaValidator
    {
        private readonly PeixeRepository _peixeRepository;
        public VendaValidator(PeixeRepository peixeRepository)
        {
            _peixeRepository = peixeRepository;
        }

        public bool Validate(VendaDTO vendaDto)
        {
            var peixe = _peixeRepository.GetById(vendaDto.PeixeId);
            if (vendaDto.PeixeId <= 0)
            {
                throw new InvalidId("Id do peixe a ser Vendido não encontrado");
            }

            if (vendaDto.QuantidadeVendida <= 0)
            {
                throw new InvalidQty("Quantidade de peixes a serem vendidos não pode ser menor ou igual a zero!!");
            }

            if (vendaDto.QuantidadeVendida > peixe.Quantidade)
            {
                throw new InvalidQtyVenda("Quantidade de peixes a serem vendidos não pode ser mais do que a quantidade de peixes em estoque:");
            }

            return true;
        }
    }
}