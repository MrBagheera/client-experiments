using SmallGiantGames.Core;
using UnityEngine;


/// <summary>
/// Most of other components are really intersted in just authentication state, 
/// which is always available - hence the separation of interfaces.
/// </summary>
interface AuthenticationState
{
    bool IsConnected { get; }
    bool IsAuthenticated { get; }
}


/// <summary>
/// This is for actually controlling authentication state
/// </summary>
interface AuthenticationManager : AuthenticationState
{

    void RestartAuthentication();
}


/// <summary>
/// Example of a component that publishes a few different aspects of self.
/// </summary>
class AuthenticationManagerScript : MonoBehaviour, AuthenticationManager
{

    private ServerConnector serverConnector;
    private ProgressManager progressManager;

    void Start()
    {
        // state is available immediately
        Core.Register<AuthenticationState>(this, PublishingType.Automatic);
        // actual management requires dependencies
        Core.Register<AuthenticationManager>(this, PublishingType.Automatic, new []
            {
                Dependency.Required<ServerConnector>(v => serverConnector = v),
                Dependency.Required<ProgressManager>(v => progressManager = v),
            },
            init: () => Debug.Log("AccMan: ready")
        );
    }

    public bool IsConnected
    {
        get { return false; }
    }

    public bool IsAuthenticated
    {
        get { return false; }
    }

    public void RestartAuthentication()
    {
        throw new System.NotImplementedException();
    }
}
