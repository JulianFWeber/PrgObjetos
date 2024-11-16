namespace PeixariaProject.DTOs
{
    public class PeixeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string LocalCaptura { get; set; }
        public string TipoCriacao { get; set; } // Ex: Aquicultura, Lago, Rio, Mar
        public string Conservacao { get; set; } // Ex: Fresco ou Congelado
        public int Quantidade{ get; set; }
        public decimal Preco { get; set; }
    }
}
