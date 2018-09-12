using CashRegisterWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterWebApi.Services
{
   public  interface ICashRegisterDataService
    {
        IList<Item> GetItems();
        Order AddOrder(Order order);
    }
}
