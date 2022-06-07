using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class myNetworkmanager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("Server Started");
    }

    public override void OnStopServer()
    {
        Debug.Log("Server Stoped");
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client connected");

    }
    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Client Disconnected");
    }
}
