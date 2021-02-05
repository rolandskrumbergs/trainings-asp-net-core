using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ContactRequest))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ContactRequest> GetById(int id)
        {
            var result = _contactRequestService.GetContactRequest(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ContactRequest> AddNew(ContactRequest contactRequest)
        {
            var result = _contactRequestService.AddContactRequest(contactRequest);

            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ContactRequest> Update(ContactRequest contactRequest)
        {
            var result = _contactRequestService.UpdateContactRequest(contactRequest);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ContactRequest> Delete(int id)
        {
            var result = _contactRequestService.DeleteContactRequest(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
