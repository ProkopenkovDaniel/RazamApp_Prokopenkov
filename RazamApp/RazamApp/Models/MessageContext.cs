using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RazamApp.Models
{
    public class MessageContext : DbContext
    {
        public MessageContext() { }
        public DbSet<Message> Messages { get; set; }
    }
}