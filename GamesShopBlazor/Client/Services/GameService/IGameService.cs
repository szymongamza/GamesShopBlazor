namespace GamesShopBlazor.Client.Services.GameService
{
    public interface IGameService
    {
        List<Game> Games { get; set; }
        Task GetGames();
    }
}
