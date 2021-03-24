using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift1.Models
{
    public class Event
    {
        public int eventID { get; set; }
        public Organizer organizer { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string adress { get; set; }
        public int date { get; set; }
        public int spots_available { get; set; }
    }
}
