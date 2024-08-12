namespace E2.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string Sexo { get; set; }
        public PessoaFisica(string nome, string cpfCnpj, String sexo)
            : base(nome, cpfCnpj)
        {
            Sexo = sexo;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {CPF_CNPJ}, Sexo: {Sexo}");
        }
    }
}
