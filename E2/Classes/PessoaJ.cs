using E2.Interfaces;

namespace E2.Classes
{
    public class PessoaJuridica : IPessoa
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Documento
        {
            get { return Cnpj; }
            set { Cnpj = value; }
        }

        public string Atividade { get; set; }

        public PessoaJuridica(string nome, string cnpj, string atividade)
        {
            Nome = nome;
            Cnpj = cnpj;
            Atividade = atividade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CNPJ: {Cnpj}, Atividade: {Atividade}");
        }
    }
}
