using BuddySystem.Data;
using BuddySystem.Models.CampusUserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Services
{
    public class CampusUserService
    {
        public bool CreateCampusUser(CampusUserCreate model)
        {
            var entity = new CampusUser()
            {
                CampusId = model.CampusId,
                UserId = model.UserId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.CampusUsers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
