using BuddySystem.Models.CampusModels;
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
    public class CampusController : ApiController
    {
        private CampusService _campusService = new CampusService();

        public IHttpActionResult Post(CampusCreate campus)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_campusService.CreateCampus(campus))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get()
        {
            var campuses = _campusService.GetAllCampuses();
            if (campuses.Any())
            {
                return Ok(campuses);
            }
            return BadRequest("There are no campuses in the database.");
        }

        public IHttpActionResult Get(int id)
        {
            var campus = _campusService.GetCampusById(id);
            if (campus != null)
            {
                return Ok(campus);
            }
            return BadRequest("There is no campus with that Id");
        }

        public IHttpActionResult Put(CampusEdit campus)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_campusService.UpdateCampus(campus))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if (!_campusService.DeleteCampus(id))
                return InternalServerError();

            return Ok("This campus was deleted");
        }
    }
}
