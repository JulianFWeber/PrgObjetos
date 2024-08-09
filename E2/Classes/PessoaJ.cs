using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    namespace E2.Classes
    {
        public class PessoaJuridica : Pessoa
        {
            public string Atividade { get; set; }

            public PessoaJuridica(string nome, string cpfCnpj, string atividade)
                : base(nome, cpfCnpj)
            {
                Atividade = atividade;
            }   
            public override void ExibirInformacoes()
            {
                Console.WriteLine($"Nome: {Nome}, CNPJ: {CPF_CNPJ}, Atividade: {Atividade}");
            }
        }
    }
}
