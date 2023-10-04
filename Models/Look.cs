using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bloodbankapp.Models
{
    public class Look
    {
        [Key]
        public string Blood {  get; set; }
    }
}