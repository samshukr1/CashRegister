using System;

namespace CashRegisterWebApi.Services.Discount
{
    public class DiscountStrategyLocator : IDiscountStrategyLocator
    {
        public IDiscountStrategy GetDicountStrategy(string type)
        {
            switch (type)
            {
                case "30Percent":
                    return new DiscountPercentageStrategy(new DiscountPercentageOptions { Percent = 0.3 });
                case "Buy3Get1":
                    return new DiscountBuyXGetYStrategy(new DiscountBuyXGetYOtions { X = 3, Y = 1 });
                default:
                    throw new NotSupportedException("the discount type is not supported");
            }
        }
    }
}
