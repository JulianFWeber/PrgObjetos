using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class Combustivel
    {
        public string Tipo { get; set; }
        public double PrecoPorLitro { get; set; }

        // Construtor
        public Combustivel(string tipo, double precoPorLitro)
        {
            Tipo = tipo;
            PrecoPorLitro = precoPorLitro;
        }

        // Método para exibir informações sobre o combustível
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Tipo de Combustível: {Tipo}");
            Console.WriteLine($"Preço por Litro: {PrecoPorLitro:C}");
        }
    }
}
