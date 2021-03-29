using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Models.CampusUserModels
{
    public class CampusUserCreate
    {
        [Required]
        public int CampusId { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
