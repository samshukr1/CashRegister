

namespace CashRegisterWebApi.Services.Discount
{
    public interface IDiscountStrategyLocator
    {
        IDiscountStrategy GetDicountStrategy(string type);
    }
}
