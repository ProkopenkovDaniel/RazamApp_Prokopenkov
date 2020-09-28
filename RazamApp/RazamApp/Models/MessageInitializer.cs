using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Design;
namespace RazamApp.Models
{
    public class MessageInitializer : DropCreateDatabaseAlways<MessageContext>
    {
        protected override void Seed(MessageContext db)
        {

        }
    }
}