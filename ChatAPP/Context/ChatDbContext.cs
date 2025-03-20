using ChatAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatAPP.Context
{
    public class ChatDbContext:DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options):base(options) 
        {
            
        }

        public DbSet<Message> Messages { get; set; }
    }
}
  