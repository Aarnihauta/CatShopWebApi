using CatShopWebApi.Exceptions;
using CatShopWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace CatShopWebApi.Controllers
{
    [Route("api/[controller]")]
    public class CatBuyController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public CatBuyController(IOrderService order)
        {
            _orderService = order;
        }
        public IActionResult Order()
        {
            try
            {
                if (_orderService.Cat.Order)
                    throw new CatOrderedException(CultureInfo.CurrentCulture);

                if(_orderService.Cat.Bought)
                    throw new CatBoughtedException(CultureInfo.CurrentCulture);

                return Ok(_orderService.Cat);
            }
            catch (CatOrderedException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (CatBoughtedException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
