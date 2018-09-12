using CashRegisterWebApi.Models;

namespace CashRegisterWebApi.Services.Discount
{
    public class DiscountPercentageStrategy : IDiscountStrategy
    {
        private DiscountPercentageOptions _Options;
        public DiscountPercentageStrategy(DiscountPercentageOptions options)
        {
            _Options = options;
        }
        public void CalculateDiscount(Order order)
        {
             order.Total *= (decimal)_Options.Percent;
        }
    }
}
