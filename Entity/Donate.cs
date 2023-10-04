using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloodb.Entity
{
    public class Donate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Dob { get; set; }

        public string Mobile { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string Bloodgroup { get; set; }
        public string Lastdate { get; set; }
    }
}