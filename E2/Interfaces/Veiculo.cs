using E2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Interfaces
{
    public interface IAutomovel
    {
        string Modelo { get; set; }
        double Valor { get; set; }
        int Ano { get; set; }
        string Placa { get; set; }
        Combustivel TipoCombustivel { get; set; } // Adicione esta linha

        void ExibirInformacoes();
    }
}