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
    [RoutePrefix("rest/hairDresser")]
    public class HairDresserController : ApiController
    {
        private IHairDresserService _serHairDress;
        public HairDresserController(IHairDresserService serHairDress)
        {
            _serHairDress = serHairDress;
        }
        [HttpGet]
        [Route("getMany")]
        public IHttpActionResult GetMany(int barbershopId)
        {
            return Ok(_serHairDress.GetHairDresserByBarbershopId(barbershopId));
        }

        [HttpPost]
        [Route("join")]
        [Authorize]
        public IHttpActionResult ApplyToJoin(int barbershopId)
        {
            string userId = User.Identity.GetUserId();
            return Ok(_serHairDress.ApplyToJoin(barbershopId, userId));
        }
        [HttpPut]
        [Route("verifyPass")]
        [Authorize]
        public IHttpActionResult VerifyPass(int settledId)
        {

            return Ok(_serHairDress.UpdateHairDressState(settledId, BarbershopHairDresserVerifyState.Pass));
        }
        [HttpPut]
        [Route("verifyUnPass")]
        [Authorize]
        public IHttpActionResult VerifyUnPass(int settledId)
        {

            return Ok(_serHairDress.UpdateHairDressState(settledId, BarbershopHairDresserVerifyState.UnPass));
        }
        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DelHairDress(int settledId)
        {
            return Ok(_serHairDress.Delete(settledId));
        }
    }
}
