using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dev2.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MaxLength(12)]
        public string name { get; set; }
        [Required]
        public string user { get; set; }
        [Required]
        public string pass { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        
    }
}
