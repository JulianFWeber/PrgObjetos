namespace PeixariaProject.DTOs
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public int PeixeId { get; set; }
        public int QuantidadeVendida { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}