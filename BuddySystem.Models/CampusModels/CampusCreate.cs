using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Models.CampusModels
{
    public class CampusCreate
    {
        [Required, MinLength(4, ErrorMessage ="Campus Name must be more than 3 characters."), MaxLength(60, ErrorMessage ="Campus name must be less than 60 characters")]
        public string Name { get; set; }
    }
}
