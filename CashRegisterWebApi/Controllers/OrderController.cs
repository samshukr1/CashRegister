using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashRegisterWebApi.Models;
using CashRegisterWebApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CashRegisterWebApi.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private ICashRegisterDataService _ICashRegisterDataService;
        private IOrderDiscountService _OrderDiscountService;
        public OrderController(ICashRegisterDataService iCashRegisterDataService, IOrderDiscountService orderDiscountService)
        {
            _ICashRegisterDataService = iCashRegisterDataService;
            _OrderDiscountService = orderDiscountService;
        }
       

      

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Order order)
        {
            _OrderDiscountService.ApplyDiscount(order);
            _ICashRegisterDataService.AddOrder(order);
        }

       
    }
}
