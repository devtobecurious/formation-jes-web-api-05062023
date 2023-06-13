using Microsoft.AspNetCore.Mvc;
using Starwarsgame.Core.Games.Models;

namespace StarwarsGame.Web.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GamesController : ControllerBase
    {
        [HttpGet(Name = "GetAllWith")]
        //[ApiConventionMethod(typeof(DefaultApiConventions),
        //                     nameof(DefaultApiConventions.Get))]
        //[ProducesDefaultResponseType()]
        [ProducesResponseType(typeof(Game), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return this.Ok(new List<Game>());
        }
    }
}
