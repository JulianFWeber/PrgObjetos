namespace E2.Interfaces
{
    public interface IResidencia
    {
        string TipoConstrucao { get; set; }
        double ValorCoberto { get; set; }

        public void ExibirInformacoes();
    }
}
