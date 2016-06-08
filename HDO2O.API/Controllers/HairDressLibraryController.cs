using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HDO2O.API.Controllers
{
         [RoutePrefix("rest/hairDressLibrary")]
    public class HairDressLibraryController : ApiController
    {
        //  getAll search
        [HttpGet]
        [Route("getAll")]
        public IHttpActionResult GetAllHairDressLibrary()
        {
            return Ok();
        }
        //  add and add to myHairLibrary
        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddHairDressLibrary() 
        {
            return Ok();
        }
        //  update
        [HttpPost]
        [Route("edit")]
        public IHttpActionResult EditHairDressLibrary()
        {
            return Ok();
        }
    }
}
