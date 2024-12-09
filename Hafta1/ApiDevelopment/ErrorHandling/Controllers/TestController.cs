using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ErrorHandling.Exceptions;

namespace ErrorHandling.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        // GET: api/test/notfound
        [HttpGet("notfound")]
        public IActionResult GetNotFound()
        {
            throw new NotFoundException("This resource was not found.");
        }

        // GET: api/test/badrequest
        [HttpGet("badrequest")]
        public IActionResult GetBadRequest()
        {
            throw new BadRequestException("Invalid request.");
        }

        // GET: api/test/error
        [HttpGet("error")]
        public IActionResult GetError()
        {
            throw new Exception("An unexpected error occurred.");
        }
    }
}
