using SmallGiantGames.Core;
using UnityEngine;

/// <summary>
/// Controls lifecycle of actual game progress.
/// </summary>
interface ProgressManager
{
    void Update();
}


/// <summary>
/// Example of a typical component: all dependencies are required, and published automatically as soon as those are injected.
/// </summary>
class ProgressManagerScript : MonoBehaviour, ProgressManager
{

    private ServerConnector serverConnector;
    private AuthenticationState authenticationState;

    void Start()
    {
        Core.Register<ProgressManager>(this, PublishingType.Automatic, new[]
            {
                Dependency.Required<ServerConnector>(v => serverConnector = v),
                Dependency.Required<AuthenticationState>(v => authenticationState = v)
            },
            init: () => Debug.Log("Ready, connected = " + authenticationState.IsConnected)
        );
    }

    public void Update()
    {
        if (!authenticationState.IsConnected)
        {
            return;
        }
        throw new System.NotImplementedException();
    }
}
