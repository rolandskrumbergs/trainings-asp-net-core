using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Training.AspNetCore.Database;
using Training.AspNetCore.Database.Models;

namespace Training.AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ContactRequestDbContext _context;

        public OrderController(ContactRequestDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Order> SendOrder(Order order)
        {
            order.TimeReceived = DateTime.Now;

            _context.Add(order);
            _context.SaveChanges();

            return Ok("Order received");
        }
    }
}
