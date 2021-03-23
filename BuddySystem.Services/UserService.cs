using BuddySystem.Data;
using BuddySystem.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace BuddySystem.Services
{
    public class UserService
    {
        private readonly string _userId;

        public UserService(string id)
        {
            _userId = id;
        }
        public IEnumerable<UserListItem> GetAllUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Users
                    .Select(
                        e =>
                        new UserListItem
                        {
                            FullName = e.FullName,
                            UserName = e.UserName
                        });
                return query.ToList();
            }
        }

        public UserDetail GetUserDetails() // "See Profile"... for current user only
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Users
                    .Single(e => e.Id == _userId);
                return new UserDetail
                {
                    Id = entity.Id,
                    FullName = entity.FullName,
                    Address = entity.Address,
                    PhoneNumber = entity.PhoneNumber,
                    Email = entity.Email
                };
            }
        }

        public UserDetail GetUserById(string id) // Any user given an Id - for Admin use
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Users
                    .Single(e => e.Id == id);
                return new UserDetail
                {
                    Id = entity.Id,
                    FullName = entity.FullName,
                    Address = entity.Address,
                    PhoneNumber = entity.PhoneNumber,
                    Email = entity.Email
                };
            }
        }

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

        public bool DeleteUser(string id) //Admin only
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Users
                    .Single(e => e.Id == id);

                ctx.Users.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
