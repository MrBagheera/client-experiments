using SmallGiantGames.Core;
using UnityEngine;

interface ConfigurationManager
{
    void Refresh();
}


/// <summary>
/// Example of a component that after getting all required depndencies does some extra work berfore manualy publishing self.
/// </summary>
class ConfigurationManagerScript : MonoBehaviour, ConfigurationManager
{

    private ServerConnector serverConnector;

    void Start()
    {
        Core.Register<AuthenticationManager>(this, PublishingType.Manual, new []
            {
                Dependency.Required<ServerConnector>(v => serverConnector = v)
            },
            init: InitialRefresh
        );
    }

    private void InitialRefresh()
    {
        serverConnector.GetClientConfig(abSeed: 0, onSuccess: (json) =>
        {
            // parse and store config
            Core.Publish(this);
        },
        onFailure: (error) =>
        {
            // set default config
            Core.Publish(this);
        });
    }

    public void Refresh()
    {
        throw new System.NotImplementedException();
    }

}
