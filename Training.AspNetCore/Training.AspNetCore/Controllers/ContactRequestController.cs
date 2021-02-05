using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.AspNetCore.Database.Models;
using Training.AspNetCore.Database.Services;

namespace Training.AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactRequestController : ControllerBase
    {
        private readonly IContactRequestService _contactRequestService;

        public ContactRequestController(IContactRequestService contactRequestService)
        {
            _contactRequestService = contactRequestService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ContactRequest>))]
        public ActionResult<List<ContactRequest>> GetAll()
        {
            var result = _contactRequestService.GetContactRequests();

            return Ok(result);
        }
    }
}
