using E2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class Caminhao : IAutomovel
    {
        public string Modelo { get; set; }
        public double Valor { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public Combustivel TipoCombustivel { get; set; } // Alterado para usar a classe Combustivel

        public Caminhao(string modelo, double valor, int ano, string placa, Combustivel tipoCombustivel)
        {
            Modelo = modelo;
            Valor = valor;
            Ano = ano;
            Placa = placa;
            TipoCombustivel = tipoCombustivel;
        }

        // Implementação da void ExibirInformacoes()
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Valor: {Valor:C}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Placa: {Placa}");
            TipoCombustivel.ExibirInformacoes(); // Chama o método da classe Combustivel
        }
    }
}