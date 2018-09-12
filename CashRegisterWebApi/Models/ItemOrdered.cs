namespace CashRegisterWebApi.Models
{
    public class ItemOrdered
    {
        public int Id { get; set; }
        public Item item { get; set; }
        public int Quantatiy { get; set; }
    }
}
