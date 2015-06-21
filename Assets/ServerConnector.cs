using System;
using UnityEngine;
using System.Collections;
using SmallGiantGames.Core;


public interface ServerConnector
{
    void GetClientConfig(int abSeed, Action<JSONObject> onSuccess, Action<string> onFailure);
}

/// <summary>
/// Example of a component that has no dependencies and just provides services.
/// </summary>
public class ServerConnectorScript : MonoBehaviour, ServerConnector {

	void Start () {
        Core.Register<ServerConnector>(this, PublishingType.Automatic);
	}

    public void GetClientConfig(int abSeed, Action<JSONObject> onSuccess, Action<string> onFailure)
    {
        throw new System.NotImplementedException();
    }
	
}
