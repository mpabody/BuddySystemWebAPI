using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Data
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [ForeignKey(nameof(Campus))]
        public int CampusId { get; set; }
        public virtual Campus Campus { get; set; }

        [Required]
        public string LocationName { get; set; }

        [Required]
        public string Address { get; set; }

        public string LocationNotes { get; set; }
    }
}
