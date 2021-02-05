using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.AspNetCore.Database.Models;

namespace Training.AspNetCore.Database
{
    public class ContactRequestDbContext : DbContext
    {
        public ContactRequestDbContext(DbContextOptions<ContactRequestDbContext> options) : base(options)
        {

        }

        public DbSet<ContactRequest> ContactRequests { get; set; }
    }
}
