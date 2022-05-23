using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesShopBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Game>>>> GetGames()
        {
            var result = await _gameService.GetGamesAsync();
            return Ok(result);
        }
        [HttpGet("{gameId}")]
        public async Task<ActionResult<ServiceResponse<Game>>> GetGame(int gameId)
        {
            var result = await _gameService.GetGameAsync(gameId);
            return Ok(result);
        }
    }
}
