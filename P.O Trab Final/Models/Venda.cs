namespace PeixariaProject.Models
{
    // Essa classe representa uma venda. Aqui a gente guarda tudo que precisamos sobre uma venda de peixes.
    public class Venda
    {
        // O ID da venda, que é tipo um número de identificação único. Cada venda vai ter um ID diferente.
        public int Id { get; set; }

        // ID do peixe vendido. Assim a gente sabe qual peixe foi vendido nessa venda.
        public int PeixeId { get; set; }

        // Essa é a quantidade de peixes que foram vendidos. Pode ser 1, 2, 10... o que for!
        public int QuantidadeVendida { get; set; }

        // O preço total da venda. Aqui a gente vai guardar quanto custou tudo no final.
        public decimal PrecoTotal { get; set; }

        // Essa função calcula o preço total da venda. 
        // Ela pega o preço do peixe (já com desconto, se tiver) e multiplica pela quantidade vendida.
        public void CalcularPrecoTotal(Peixe peixe)
        {
            // Aqui a gente chama a função do peixe que calcula o preço com desconto e multiplica pela quantidade.
            PrecoTotal = peixe.CalcularPrecoComDesconto() * QuantidadeVendida;
        }
    }
}