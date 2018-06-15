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
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(250)]
        public string Message { get; set; }
       
        
    }
}
