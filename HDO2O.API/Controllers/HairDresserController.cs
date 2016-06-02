using HDO2O.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HDO2O.API.Controllers
{
    [RoutePrefix("rest/hairDresser")]
    public class HairDresserController : ApiController
    {
        private IHairDresserServices _serHairDress;
        public HairDresserController(IHairDresserServices serHairDress)
        {
            _serHairDress = serHairDress;
        }
        [HttpGet]
        [Route("getMany")]
        public IHttpActionResult GetMany(int barbershopId)
        {
            return Ok(_serHairDress.GetHairDresserByBarbershopId(barbershopId));
        }

        public IHttpActionResult ApplyToJoin(int barbershopId)
        {
            throw new NotImplementedException();
        }
    }
}
