using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Models.UserModels
{
    public class UserEdit
    {
        [Required]
        public string Id { get; set; }

        [Required, MaxLength(100, ErrorMessage ="Your first name is too long! It must be less than 100 characters"), MinLength(2, ErrorMessage ="Your first name is too short! We need at least 2 characters.")]
        public string FirstName { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Your last name is too long! It must be less than 100 characters"), MinLength(2, ErrorMessage = "Your lasat name is too short! We need at least 2 characters.")]
        public string LastName { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Your address is too long! It must be less than 100 characters"), MinLength(2, ErrorMessage = "Your address is too short! We need at least 10 characters.")]
        public string Address { get; set; }

        [Required, MaxLength(12, ErrorMessage = "Your phone number is too long! It should only be 10 characters \"xxx-xxx-xxxx\""), MinLength(10, ErrorMessage = "Your phone number is too long! It should only be 10 characters \"xxx-xxx-xxxx\"")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
