using System.Collections.Generic;
using System.Linq;
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
            var newContactRequest = new ContactRequest
            {
                Name = contactRequest.Name,
                Email = contactRequest.Email,
                Content = contactRequest.Content,
                Subject = contactRequest.Subject
            };

            _dbContext.Add(newContactRequest);
            _dbContext.SaveChanges();

            return newContactRequest;
        }

        public ContactRequest DeleteContactRequest(int id)
        {
            var contactRequestToDelete = _dbContext.ContactRequests.FirstOrDefault(x => x.Id == id);

            if (contactRequestToDelete != null)
            {
                _dbContext.Remove(contactRequestToDelete);
                _dbContext.SaveChanges();

                return contactRequestToDelete;
            }

            return null;
        }

        public ContactRequest GetContactRequest(int id)
        {
            var contactRequestToFind = _dbContext.ContactRequests.FirstOrDefault(x => x.Id == id);

            if (contactRequestToFind != null)
            {
                return contactRequestToFind;
            }

            return null;
        }

        public List<ContactRequest> GetContactRequests()
        {
            return _dbContext.ContactRequests.ToList();
        }

        public ContactRequest UpdateContactRequest(ContactRequest contactRequest)
        {
            var contactRequestToUpdate = _dbContext.ContactRequests.FirstOrDefault(x => x.Id == contactRequest.Id);

            if (contactRequestToUpdate == null)
            {
                return null;
            }

            contactRequestToUpdate.Name = contactRequest.Name;
            contactRequestToUpdate.Email = contactRequest.Email;
            contactRequestToUpdate.Subject = contactRequest.Subject;
            contactRequestToUpdate.Content = contactRequest.Content;

            _dbContext.SaveChanges();

            return contactRequestToUpdate;
        }
    }
}
