using BuddySystem.Data;
using BuddySystem.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Services
{
    public class UserService
    {
        public bool UpdateUser(UserEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Users
                    .Single(e => e.Id == model.Id);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Address = model.Address;
                entity.PhoneNumber = model.PhoneNumber;
                entity.Email = model.Email;
                entity.UserName = model.Email;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
