using BuddySystem.Data;
using BuddySystem.Models.CampusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Services
{
    public class CampusService
    {
        public bool CreateCampus(CampusCreate model)
        {
            var entity =
                new Campus()
                {
                    Name = model.Name,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Campuses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CampusListItem> GetAllCampuses()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Campuses
                    .Select(
                        e =>
                        new CampusListItem
                        {
                            CampusId = e.CampusId,
                            Name = e.Name,
                            Address = e.Address
                        });
                return query.ToList();
            }
        }

        public CampusDetail GetCampusById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Campuses
                    .Single(e => e.CampusId == id);

                return new CampusDetail
                {
                    CampusId = entity.CampusId,
                    Name = entity.Name,
                    Address = entity.Address,
                    PhoneNumber = entity.PhoneNumber
                };
            }
        }

        public bool UpdateCampus(CampusEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Campuses
                    .Single(e => e.CampusId == model.CampusId);

                entity.Name = model.Name;
                entity.Address = model.Address;
                entity.PhoneNumber = model.PhoneNumber;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCampus(int campusId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Campuses
                    .Single(e => e.CampusId == campusId);

                ctx.Campuses.Remove(entity); // soft delete - entity.isDeactiviated = true;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
