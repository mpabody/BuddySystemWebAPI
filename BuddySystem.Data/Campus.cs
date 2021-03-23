using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Data
{
    public class Campus
    {
        [Key]
        public int CampusId { get; set; }

        [Required]
        public string Name { get; set; }

        // vir list<location>
    }
}
