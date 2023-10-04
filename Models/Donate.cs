using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bloodb.Models
{
    public class Donate
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Bloodgroup { get; set; }
        [Required]
        public string Lastdate { get; set; }    
        //public string Consumer { get; set; }
    }
}