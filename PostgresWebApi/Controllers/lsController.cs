using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> getall()
        {
            return Ok(new { success = true, message = "" });
        }
    }
}
