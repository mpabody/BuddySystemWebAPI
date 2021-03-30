using BuddySystem.Models.CampusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Models.LocationModels
{
    public class LocationDetail
    {
        public int LocationId { get; set; }
        public int CampusId { get; set; }
        public virtual CampusListItem Campus { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string LocationNotes { get; set; }
    }
}
