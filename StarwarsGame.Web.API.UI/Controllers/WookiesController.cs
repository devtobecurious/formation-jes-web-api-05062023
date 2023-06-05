using Microsoft.AspNetCore.Mvc;
using Starwarsgame.Core.Wookiees.Application;

namespace StarwarsGame.Web.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WookiesController : ControllerBase
    {
        private readonly IWookieeService service;

        public WookiesController(IWookieeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(this.service.GetAll());
        }
    }
}
