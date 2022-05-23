using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Data.Models
{
    public class Event
    {
        public string EventName { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Date { get; set; } // PK
        public string Time { get; set; } // PK
        public string UserName { get; set; } // User PK
        public User User { get; set; } // User reference
    }
}
