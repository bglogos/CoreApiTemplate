using Microsoft.AspNetCore.Mvc;

namespace CoreApiTemplate.Api.Controllers
{
    /// <summary>
    /// The Probes controller.
    /// </summary>
    /// <seealso cref="Controller" />
    [ApiVersion("1")]
    [Route("~/api/v{version:apiVersion}/[controller]")]
    public class ProbesController : Controller
    {
        /// <summary>
        /// Check if application is alive.
        /// </summary>
        /// <returns>200 OK.</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}