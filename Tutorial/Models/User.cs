using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display (Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

       
        [Required]
        public string Password { get; set; }

    }
}
