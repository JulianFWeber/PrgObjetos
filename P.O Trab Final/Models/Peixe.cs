namespace PeixariaProject.Models
{
    // Esta classe representa um Peixe. Aqui, a gente define como um peixe deve ser.
    public class Peixe
    {
        public int Id { get; set; } // ID único para identificar cada peixe na nossa lista.
        public string Nome { get; set; }   // Nome do peixe, tipo "Salmão" ou "Tilápia".
        public string LocalCaptura { get; set; } // Onde o peixe foi capturado: água doce (como rios) ou água salgada (como o mar).
        public string TipoCriacao { get; set; } // Como o peixe foi criado: Aquicultura (cultivado), Lago, Rio ou Mar.
        public string Conservacao { get; set; } // Se o peixe está fresco ou congelado, importante para saber a qualidade.
        public decimal Preco { get; set; }  // O preço do peixe, em dinheiro, claro!
        public int Quantidade { get; set; } // Quantidade que temos desse peixe em estoque.

        // Este método calcula o preço com desconto, se aplicável.
        public decimal CalcularPrecoComDesconto()
        {
            // Se o peixe foi criado em Aquicultura, aplicamos um desconto de 20%.
            if (TipoCriacao == "Aquicultura")
            {
                return Preco * 0.8m; // Retorna o preço com desconto.
            }
            return Preco; // Se não for Aquicultura, retorna o preço normal.
        }
    }
}