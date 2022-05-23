using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary2
{
    internal class CurrentEvent
    {
        public string EventName { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Date { get; set; } // PK
        public string Time { get; set; } // PK
        public string UserName { get; set; } // User PK
        //public User User { get; set; } // User reference
    }
}
