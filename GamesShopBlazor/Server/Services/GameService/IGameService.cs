namespace GamesShopBlazor.Server.Services.GameService
{
    public interface IGameService
    {
        Task<ServiceResponse<List<Game>>> GetGamesAsync();
    }
}
