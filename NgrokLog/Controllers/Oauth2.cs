using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRick.Controllers
{
    [Route("[controller]/api/v1/")]
    [ApiController]
    public class Oauth2 : ControllerBase
    {
        [HttpPost("token")]
        public IActionResult GetToken(string grant_type)
        {
            return Ok(new OuthResponse { GrantType = grant_type, Result = "Success" });
        }

        [HttpGet("token")]
        public IActionResult GetToken2(string grant_type)
        {
            return Ok(new OuthResponse { GrantType = grant_type, Result = "Success" });
        }
    }
}
