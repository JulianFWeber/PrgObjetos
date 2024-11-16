using P.O_Trab_Final.Exceptions;
using PeixariaProject.DTOs;
using PeixariaProject.Exceptions;



// Espaço criado para validar que novos posts atendam as regras do projeto, informações fora das aceitadas devem ser recusadas. (Infelizmente.. lago != Lago)
namespace PeixariaProject.Validators
{
    public class PeixeValidator
    {
        public bool Validate(PeixeDTO peixeDto)
        {
            if (string.IsNullOrWhiteSpace(peixeDto.Nome))
            {
                return false;
            }

            /*
             * if (peixeDto.TipoCriacao != "Aquicultura" || peixeDto.TipoCriacao != "Rio" || peixeDto.TipoCriacao != "Mar" || peixeDto.TipoCriacao != "Lago")
            {
                throw new InvalidLocal("Peixe pode somente ter sido criado em Lago, Rio, Mar ou via Aquicultura (Atente-se as casas maiúsculas)");
            }

            // Lembrando que como mencionado acima (lago != Lago) aqui também fresco != Fresco
            if (peixeDto.Conservacao != "Fresco" || peixeDto.TipoCriacao != "Congelado")
            {
                throw new InvalidConservacao("Peixe pode somente ser Fresco ou conservado Congelado (Atente-se as casas maiúsculas)");
            }
            */
            if (peixeDto.Quantidade <= 0)
            {
                throw new InvalidQty("Quantidade de peixes não pode ser 0 ou menos de 0");                
            }

            if (peixeDto.Preco <= 0)
            {
                throw new InvalidPrice("Preço do peixe não pode ser 0 ou negativo");
            }

            return true;
        }
    }
}