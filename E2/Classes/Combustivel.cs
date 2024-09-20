namespace E2.Classes
{
    public class Combustivel
    {
        public string Tipo { get; private set; }
        public double PrecoPorLitro { get; private set; }

        public Combustivel(string tipo, double precoPorLitro)
        {
            Tipo = tipo;
            PrecoPorLitro = precoPorLitro;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Tipo de Combustível: {Tipo}");
            Console.WriteLine($"Preço por Litro: {PrecoPorLitro:C}");
        }
    }
}
