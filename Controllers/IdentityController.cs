using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthNewApi.Controllers {

    [Route("identity")]
    [Authorize(Policy="ApiScope")]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
            return Ok("lol");
        }
    }
}