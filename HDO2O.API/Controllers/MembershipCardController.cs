using HDO2O.DTO;
using HDO2O.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HDO2O.API.Controllers
{
    [RoutePrefix("rest/membershipcard")]
    public class MembershipCardController : ApiController
    {
       private IMembershipCardService _servMembershipCard;

       public MembershipCardController(IMembershipCardService servMembershipCard)
        {
            _servMembershipCard = servMembershipCard;

        }

        [HttpGet]
        [Route("getMany")]
        public IHttpActionResult GetMany() 
        {
            return Ok(_servMembershipCard.GetMany(1));
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add([FromBody] MembershipCardDTO entity) 
        {
            return Ok(_servMembershipCard.Add(entity));
        }
    }
}
