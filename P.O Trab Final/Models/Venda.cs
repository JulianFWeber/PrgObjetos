namespace P.O_Trab_Final.Models
{    public class Venda
    {
        public int Id { get; set; }
        public Peixe PeixeVendido { get; set; }
        public decimal PrecoFinal { get; set; }

        public void CalcularDesconto()
        {
            if (PeixeVendido.TipoCriacao == "Aquicultura")
            {
                PrecoFinal = PeixeVendido.Preco * 0.80m;
            }
            else
            {
                PrecoFinal = PeixeVendido.Preco;
            }
        }
    }

}
