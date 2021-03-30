using BuddySystem.Models.LocationModels;
using BuddySystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuddySystem.WebAPI.Controllers
{
    [Authorize]
    public class LocationController : ApiController
    {
        private readonly LocationService _locationService = new LocationService();

        public IHttpActionResult Post(LocationCreate location)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_locationService.CreateLocation(location))
                return InternalServerError();

            return Ok("The location was successfully created");
        }

        public IHttpActionResult Get()
        {
            var locations = _locationService.GetLocations();
            return Ok(locations);
        }

        public IHttpActionResult Get(int id)
        {
            var location = _locationService.GetLocationById(id);
            return Ok(location);
        }

        public IHttpActionResult Put(LocationEdit location)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_locationService.UpdateLocation(location))
            {
                return InternalServerError();
            }

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if (!_locationService.DeleteLocation(id))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}
