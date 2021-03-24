using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Models.CampusModels
{
    public class CampusEdit
    {
        [Required]
        public int CampusId { get; set; }

        [Required, MinLength(4, ErrorMessage = "Campus Name must be more than 3 characters."), MaxLength(60, ErrorMessage = "Campus name must be less than 60 characters")]
        public string Name { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Your address is too long! It must be less than 100 characters"), MinLength(2, ErrorMessage = "Your address is too short! We need at least 10 characters.")]
        public string Address { get; set; }

        [Required, MaxLength(12, ErrorMessage = "Your phone number is too long! It should only be 10 characters \"xxx-xxx-xxxx\""), MinLength(10, ErrorMessage = "Your phone number is too long! It should only be 10 characters \"xxx-xxx-xxxx\"")]
        public string PhoneNumber { get; set; }
    }
}
