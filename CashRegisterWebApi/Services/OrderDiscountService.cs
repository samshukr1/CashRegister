
using CashRegisterWebApi.Models;
using CashRegisterWebApi.Services.Discount;

namespace CashRegisterWebApi.Services
{
    public class OrderDiscountService : IOrderDiscountService
    {
        private IDiscountStrategyLocator _DiscountStrategyLocator;
        public OrderDiscountService(IDiscountStrategyLocator discountStrategyLocator)
        {
            _DiscountStrategyLocator = discountStrategyLocator;
        }
        public void ApplyDiscount(Order order)
        {
            _DiscountStrategyLocator.GetDicountStrategy(order.DiscountType).CalculateDiscount(order);
        }
    }
}
