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
    public class ItemController : Controller
    {
        private ICashRegisterDataService _ICashRegisterDataService;
        public ItemController(ICashRegisterDataService iCashRegisterDataService)
        {
            _ICashRegisterDataService = iCashRegisterDataService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _ICashRegisterDataService.GetItems();
        }
        

       
    }
}
