using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LineZyAPI.Controllers.admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize (Policy = "RequireAdmin")]
    public class AdminTestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Admin test successful");
        }
    }
}
