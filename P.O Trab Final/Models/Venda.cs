namespace PeixariaProject.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int PeixeId { get; set; }
        public int QuantidadeVendida { get; set; }
        public decimal PrecoTotal { get; set; }

        // Chama função para calcular peixe possio desconto e retorna o preço total para multiplicar com a quantidade a ser vendida
        public void CalcularPrecoTotal(Peixe peixe)
        {
            PrecoTotal = peixe.CalcularPrecoComDesconto() * QuantidadeVendida;
        }
    }
}