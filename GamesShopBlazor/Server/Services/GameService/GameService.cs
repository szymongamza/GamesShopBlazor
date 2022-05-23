namespace GamesShopBlazor.Server.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Game>> GetGameAsync(int gameId)
        {
            var respone = new ServiceResponse<Game>();
            var game = await _context.Games.FindAsync(gameId);
            if (game == null)
            {
                respone.Success = false;
                respone.Message = "Sorry, but this product does not exist";
            }
            else
            {
                respone.Data = game;
            }
            return respone;
        }

        public async Task<ServiceResponse<List<Game>>> GetGamesAsync()
        {
            var response = new ServiceResponse<List<Game>>
            {
                Data = await _context.Games.ToListAsync()
            };
            return response;
        }
    }
}
