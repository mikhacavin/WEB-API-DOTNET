using Microsoft.EntityFrameworkCore;
using WEB_API.Model;

namespace WEB_API.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options ) : base(options) { 
        
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
