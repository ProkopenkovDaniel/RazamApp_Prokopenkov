using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazamApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
    }
}