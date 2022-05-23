

namespace GamesShopBlazor.Client.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly HttpClient _http;

        public GameService(HttpClient http)
        {
            _http = http;
        }
        public List<Game> Games { get; set ; } = new List<Game> ();

        public async Task<ServiceResponse<Game>> GetGameAsync(int gameId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Game>>($"api/game/{gameId}");
            return result;
        }

        public async Task GetGames()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Game>>>("api/game");
            if (result != null && result.Data != null)
            {
                Games = result.Data;
            }
        }
    }
}
