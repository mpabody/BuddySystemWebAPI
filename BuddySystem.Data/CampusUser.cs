using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Data
{
    public class CampusUser
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof (Campus))]
        public int CampusId { get; set; }
        public virtual Campus Campus { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
