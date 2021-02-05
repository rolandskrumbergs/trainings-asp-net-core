using System.Collections.Generic;
using Training.AspNetCore.Database.Models;

namespace Training.AspNetCore.Database.Services
{
    public interface IContactRequestService
    {
        List<ContactRequest> GetContactRequests();
        ContactRequest GetContactRequest(int id);
        ContactRequest AddContactRequest(ContactRequest contactRequest);
        ContactRequest UpdateContactRequest(ContactRequest contactRequest);
        ContactRequest DeleteContactRequest(int id);
    }
}