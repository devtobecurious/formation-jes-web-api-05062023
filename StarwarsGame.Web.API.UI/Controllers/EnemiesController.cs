using Microsoft.AspNetCore.Mvc;
using Starwarsgame.Core.Enemies.Application;
using StarwarsGame.Core.Models.Enemies;

namespace StarwarsGame.Web.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnemiesController : ControllerBase
    {
        private readonly IEnemyService service;

        public EnemiesController(IEnemyService service)
        {
            this.service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Enemy>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return this.Ok(this.service.GetAll());
        }
    }
}
