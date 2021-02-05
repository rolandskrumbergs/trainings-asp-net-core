using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.AspNetCore.Database.Models;

namespace Training.AspNetCore.Database.Services
{
    public class ContactRequestService : IContactRequestService
    {
        private readonly ContactRequestDbContext _dbContext;

        public ContactRequestService(ContactRequestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ContactRequest AddContactRequest(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }

        public ContactRequest DeleteContactRequest(int id)
        {
            throw new NotImplementedException();
        }

        public ContactRequest GetContactRequest(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactRequest> GetContactRequests()
        {
            return _dbContext.ContactRequests.ToList();
        }

        public ContactRequest UpdateContactRequest(ContactRequest contactRequest)
        {
            throw new NotImplementedException();
        }
    }
}
