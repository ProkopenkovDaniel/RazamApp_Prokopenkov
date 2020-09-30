using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace RazamApp.Models
{
    public class MessageInitializer : DropCreateDatabaseAlways<MessageContext>
    {
        protected override void Seed(MessageContext db)
        {
            db.Messages.Add(new Message { Id = "0001", Content = "Hello" });
           // db.Persons.Add(new Person { Id = "0001", Name = "Daniel" });
            base.Seed(db);
        }
    }
}