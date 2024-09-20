namespace E2.Interfaces
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Documento { get; set; }

        void ExibirInformacoes();
    }
}
