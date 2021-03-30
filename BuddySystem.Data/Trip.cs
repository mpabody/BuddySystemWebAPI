using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Data
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [ForeignKey(nameof(StartingLocation))]
        public int StartLocationId { get; set; }
        public virtual Location StartingLocation { get; set; }

        [ForeignKey(nameof(ProjectedEndLocation))]
        public int ProjectedEndLocationId { get; set; }
        public virtual Location ProjectedEndLocation { get; set; }

        [ForeignKey(nameof(ActualEndLocation))]
        public int ActualEndLocationId { get; set; }
        public virtual Location ActualEndLocation { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [ForeignKey(nameof(Buddy))]
        public string BuddyId { get; set; }
        public virtual ApplicationUser Buddy { get; set; }

        public string UserNotes { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }
    }
}
