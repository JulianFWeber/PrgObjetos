using E2.Classes;
using E2.Classes.E2.Classes;
using E2.Interfaces;
using System;
using System.Collections.Generic;


namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            var novaPessoaFisica = new PessoaFisica("Juca Felipe", "117.778.319-38", "Masculino");
            novaPessoaFisica.ExibirInformacoes();

            var novaPessoaJuridica = new PessoaJuridica("Weber Seg", "12.345.678/0001-90", "Corretora");
            novaPessoaJuridica.ExibirInformacoes();

            var gasolina = new Combustivel("Gasolina", 5.50);
            var carro = new Carro("Jeepão", 125700, 2018, "RYS8G49", gasolina);
            carro.ExibirInformacoes();

            var diesel = new Combustivel("Diesel", 6.00);
            var caminhao = new Caminhao("Constellation 24250", 178106, 2011, "XYZ-5678", diesel);
            caminhao.ExibirInformacoes();

            var apartamento = new Apartamento("Solido", 300000);
            apartamento.ExibirInformacoes();

            var casa = new Casa("Madeira", 70000);
            casa.ExibirInformacoes();
            
            

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
