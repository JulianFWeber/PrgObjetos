using P.O_Trab_Final.Exceptions;
using PeixariaProject.DTOs;
using PeixariaProject.Exceptions;



// Espaço criado para validar que novos posts atendam as regras do projeto,
// informações fora das aceitadas devem ser recusadas. (Infelizmente.. lago != Lago)
namespace PeixariaProject.Validators
{
    // Esta classe é responsável por validar se os dados do peixe estão certos.
    public class PeixeValidator
    {
        // Este método verifica se o peixe está dentro das regras que definimos.
        public bool Validate(PeixeDTO peixeDto)
        {
            // Aqui checamos se o nome do peixe foi preenchido. Se não, retorna falso (ou seja, inválido).
            if (string.IsNullOrWhiteSpace(peixeDto.Nome))
            {
                return false; // Nome vazio não é aceito.
            }

            // Aqui verificamos se o tipo de criação do peixe é um dos permitidos. Se não for, lança um erro.
            if (peixeDto.TipoCriacao != "Aquicultura" &&
                peixeDto.TipoCriacao != "Rio" &&
                peixeDto.TipoCriacao != "Mar" &&
                peixeDto.TipoCriacao != "Lago")
            {
                throw new InvalidLocal("Peixe pode somente ter sido criado em Lago, Rio, Mar ou via Aquicultura (Atente-se as casas maiúsculas)");
            }

            // Lembrando que como mencionado acima (lago != Lago) aqui também fresco != Fresco
            // Aqui estamos validando a conservação do peixe. Ele só pode ser 'Fresco' ou 'Congelado'.
            if (peixeDto.Conservacao != "Fresco" &&
                peixeDto.Conservacao != "Congelado")
            {
                throw new InvalidConservacao("Peixe pode somente ser Fresco ou conservado Congelado (Atente-se as casas maiúsculas)");
            }

            // Aqui checamos se a quantidade de peixes é maior que zero. Se for menor ou igual a zero, lança um erro.
            if (peixeDto.Quantidade <= 0)
            {
                throw new InvalidQty("Quantidade de peixes não pode ser 0 ou menos de 0");                
            }

            // E aqui verificamos se o preço do peixe é maior que zero. Preço negativo ou zero não é aceito.
            if (peixeDto.Preco <= 0)
            {
                throw new InvalidPrice("Preço do peixe não pode ser 0 ou negativo");
            }

            // Se tudo estiver certo, retorna verdadeiro, indicando que os dados do peixe estão válidos.
            return true;
        }
    }
}