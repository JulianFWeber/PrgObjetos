using E2.Interfaces;


namespace E2.Classes
{
    public class Casa : IResidencia
    {
        public string TipoConstrucao { get; set; }
        public double ValorCoberto { get; set; }

        public Casa(string tipoConstrucao, double valor)
        {
            TipoConstrucao = tipoConstrucao;
            ValorCoberto = valor;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Tipo de Construção: {TipoConstrucao}");
            Console.WriteLine($"Valor Coberto: {ValorCoberto}");
        }
    }
}
