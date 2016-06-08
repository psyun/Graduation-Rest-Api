using HDO2O.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using HDO2O.Models;

namespace HDO2O.API.Controllers
{
     [RoutePrefix("rest/myHairDressLibrary")]
    public class MyHairDressLibraryController : ApiController
    {
        //get all
        [HttpGet]
        [Route("getAll")]
        [Authorize]
        public IHttpActionResult GetAllHairDressLibrary() 
        {
            string userId = User.Identity.GetUserId();
            return Ok();
        }

        //fork other hairdreess  
        [HttpPost]
        [Route("forkOthers")]
        public IHttpActionResult ForkOthersHairDress() 
        {
            return Ok();
        }
        //delete
        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DelOthersHairDress() 
        {
            return Ok();
        }
    }
}
