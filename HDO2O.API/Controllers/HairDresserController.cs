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
        private IHairDresserService _servHairDress;
        public HairDresserController(IHairDresserService servHairDress)
        {
            _servHairDress = servHairDress;
        }
        [HttpGet]
        [Route("getById")]
        public IHttpActionResult GetById(string hairDresserId)
        {
            return Ok(_servHairDress.GetById(hairDresserId));
        }

        [HttpGet]
        [Route("getMany")]
        public IHttpActionResult GetMany(int barbershopId)
        {
            return Ok(_servHairDress.GetHairDresserByBarbershopId(barbershopId));
        }

        [HttpPost]
        [Route("join")]
        [Authorize]
        public IHttpActionResult ApplyToJoin(int barbershopId)
        {
            string userId = User.Identity.GetUserId();
            return Ok(_servHairDress.ApplyToJoin(barbershopId, userId));
        }
        [HttpPut]
        [Route("verifyPass")]
        [Authorize]
        public IHttpActionResult VerifyPass(int settledId)
        {

            return Ok(_servHairDress.UpdateHairDressState(settledId, BarbershopHairDresserVerifyState.Pass));
        }
        [HttpPut]
        [Route("verifyUnPass")]
        [Authorize]
        public IHttpActionResult VerifyUnPass(int settledId)
        {

            return Ok(_servHairDress.UpdateHairDressState(settledId, BarbershopHairDresserVerifyState.UnPass));
        }
        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DelHairDress(int settledId)
        {
            return Ok(_servHairDress.Delete(settledId));
        }
    }
}
