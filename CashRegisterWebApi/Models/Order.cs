using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashRegisterWebApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer Customer { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Taxes { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        public IList<ItemOrdered> items { get; set; }
        public string DiscountType { get; set; }
    }
}
