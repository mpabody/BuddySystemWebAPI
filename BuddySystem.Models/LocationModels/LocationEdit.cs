using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Models.LocationModels
{
    public class LocationEdit
    {
        public int LocationId { get; set; }

        [Required]
        public int CampusId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(40, ErrorMessage = "There are too many characters in this field. Please enter no more than 40 characters")]
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Your address is too short! We need at least 10 characters.")]
        [MaxLength(100, ErrorMessage = "Your address is too long! It must be less than 100 characters")]
        public string Address { get; set; }

        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(200, ErrorMessage = "There are too many characters in this field. Please enter no more than 200 characters")]
        [Display(Name = "Location Notes")]
        public string LocationNotes { get; set; }
    }
}
