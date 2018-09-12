using CashRegisterWebApi.Models;

namespace CashRegisterWebApi.Services.Discount
{
    public interface IDiscountStrategy
    {
        void CalculateDiscount(Order order);
    }
}
