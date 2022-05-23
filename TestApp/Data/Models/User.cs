using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Data.Models
{
    public class User
    {
        public string UserName { get; set; } // PK
        public string Password { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
