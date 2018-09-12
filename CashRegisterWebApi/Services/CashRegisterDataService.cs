using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegisterWebApi.Models;
using CashRegisterWebApi.Data;

namespace CashRegisterWebApi.Services
{
    public class CashRegisterDataService : ICashRegisterDataService
    {
        private CashRegisterDbContext _CashRegisterDbContext;
        public CashRegisterDataService(CashRegisterDbContext cashRegisterDbContext)
        {
            _CashRegisterDbContext = cashRegisterDbContext;
        }
        public Order AddOrder(Order order)
        {
            _CashRegisterDbContext.orders.Add(order);
            var id = _CashRegisterDbContext.SaveChanges();

            return order;
        }

        public IList<Item> GetItems()
        {
            return _CashRegisterDbContext.items.ToList();
        }
    }
}
