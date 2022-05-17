namespace GamesShopBlazor.Server.Services.GameService
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
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
