using BuddySystem.Models.CampusUserModels;
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
    public class CampusUserController : ApiController
    {
        public IHttpActionResult Post(CampusUserCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCampusUserService();

            if (!service.CreateCampusUser(model))
                return InternalServerError();

            return Ok();
        }

        private CampusUserService CreateCampusUserService()
        {
            return new CampusUserService();
        }
    }
}
