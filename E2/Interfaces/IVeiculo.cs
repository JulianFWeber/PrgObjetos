using E2.Classes;

namespace E2.Interfaces
{
    public interface IAutomovel
    {
        string Modelo { get; set; }
        double Valor { get; set; }
        int Ano { get; set; }
        string Placa { get; set; }
        Combustivel TipoCombustivel { get; set; }

        void ExibirInformacoes();
    }
}