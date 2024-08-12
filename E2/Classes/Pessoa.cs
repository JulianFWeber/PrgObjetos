namespace E2.Classes
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }

        protected Pessoa(string nome, string cpfCnpj)
        {
            Nome = nome;
            CPF_CNPJ = cpfCnpj;
        }
        public abstract void ExibirInformacoes();
    }

}
