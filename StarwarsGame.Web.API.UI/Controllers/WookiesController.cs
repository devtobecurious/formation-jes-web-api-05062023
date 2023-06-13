using Microsoft.AspNetCore.Mvc;
using Starwarsgame.Core.Wookiees.Application;

namespace StarwarsGame.Web.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WookiesController : ControllerBase
    {
        private readonly IWookieeService service;
        private readonly ILogger<WookiesController> logger;

        public WookiesController(IWookieeService service,
            ILogger<WookiesController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            this.logger.LogInformation("WTF ?");
            this.logger.LogCritical("Au secours !");
            return this.Ok(this.service.GetAll());
        }
    }
}
