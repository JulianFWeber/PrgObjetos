namespace PeixariaProject.Models
{
    public class Peixe
    {
        public int Id { get; set; }
        public string Nome { get; set; }   // Nome do peixe
        public string LocalCaptura { get; set; } // Agua doce ou Agua Salgada
        public string TipoCriacao { get; set; } // Aquicultura, Lago, Rio, Mar
        public string Conservacao { get; set; } // Fresco ou Congelado
        public decimal Preco { get; set; }  // Preço
        public int Quantidade { get; set; } // Quantidade a ser salva

        public decimal CalcularPrecoComDesconto()
        {
            if (TipoCriacao == "Aquicultura")
            {
                return Preco * 0.8m; // Aplica 20% de desconto caso o peixe seja criado em Aquicultura (açude e afins) parte dos pre requisitos
            }
            return Preco;
        }
    }
}