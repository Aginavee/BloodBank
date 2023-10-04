using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bloodbankapp.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string BankName { get; set; }

        [Required(ErrorMessage ="Please provide your mailid")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Enter city")]
        public string City { get; set; }
    }
    
}