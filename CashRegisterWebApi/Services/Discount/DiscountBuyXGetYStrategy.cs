using CashRegisterWebApi.Models;

namespace CashRegisterWebApi.Services.Discount
{
    public class DiscountBuyXGetYStrategy : IDiscountStrategy
    {
        private DiscountBuyXGetYOtions _Options;
        public DiscountBuyXGetYStrategy(DiscountBuyXGetYOtions options)
        {
            _Options = options;
        }
        public void CalculateDiscount(Order order)
        {
            foreach(ItemOrdered item in order.items)
            {
                if (item.Quantatiy > _Options.X)
                {
                    item.Quantatiy += _Options.Y;
                }
            }
            
             
        }
    }
}
