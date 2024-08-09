using E2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace E2.Classes
{
    public class Apartamento : IResidencia
    {
        public string TipoConstrucao { get; set; }
        public double ValorCoberto { get; set; }

        public Apartamento(string tipoConstrucao, double valor)
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
