using BuddySystem.Data;
using BuddySystem.Models.CampusModels;
using BuddySystem.Models.LocationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddySystem.Services
{
    public class LocationService
    {
        public bool CreateLocation(LocationCreate model)
        {
            var entity =
                new Location()
                {
                    CampusId = model.CampusId,
                    LocationName = model.LocationName,
                    Address = model.Address,
                    LocationNotes = model.LocationNotes
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Locations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LocationListItem> GetLocations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Locations
                    .Select(
                        e =>
                        new LocationListItem()
                        {
                            LocationId = e.LocationId,
                            LocationName = e.LocationName
                        });

                return query.ToArray();
            }
        }

        public LocationDetail GetLocationById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Locations
                    .Single(e => e.LocationId == id);

                return new LocationDetail
                {
                    LocationId = entity.LocationId,
                    CampusId = entity.CampusId,
                    CampusName = entity.Campus.Name,
                    //Campus = new CampusListItem() { CampusId = entity.Campus.CampusId, Address = entity.Campus.Address, Name = entity.Campus.Name },
                    LocationName = entity.LocationName,
                    Address = entity.Address,
                    LocationNotes = entity.LocationNotes
                };
            }
        }

        public bool UpdateLocation(LocationEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Locations
                    .Single(e => e.LocationId == model.LocationId);

                entity.CampusId = model.CampusId;
                entity.LocationName = model.LocationName;
                entity.Address = model.Address;
                entity.LocationNotes = model.LocationNotes;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteLocation(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Locations
                    .Single(e => e.LocationId == id);

                ctx.Locations.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
