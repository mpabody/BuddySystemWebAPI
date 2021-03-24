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
    }
}
