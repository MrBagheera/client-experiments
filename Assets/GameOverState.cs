using SmallGiantGames.Core;


/// <summary>
/// Example of a class that is not registered, but is just interested in dependency injection.
/// </summary>
class GameOverState
{

    private ProgressManager progressManager;

    public GameOverState()
    {
        Core.Inject(new []
        {
            Dependency.Required<ProgressManager>(v => progressManager = v)
        });
    }
}
