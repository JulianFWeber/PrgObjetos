using E2.Interfaces;

namespace E2.Classes
{
    public class PessoaFisica : IPessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Documento
        {
            get { return Cpf; }
            set { Cpf = value; }
        }

        public string Sexo { get; set; }

        public PessoaFisica(string nome, string cpf, string sexo)
        {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {Cpf}, Sexo: {Sexo}");
        }
    }
}
