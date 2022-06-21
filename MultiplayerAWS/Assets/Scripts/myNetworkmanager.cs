using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
[RequireComponent(typeof(NetworkManager))]
public class myNetworkmanager : NetworkManager
{
   
    NetworkManager manager;
    public void Start()
    {
       
       
        manager = GetComponent<NetworkManager>();
       // manager.networkAddress = "ec2-3-87-199-198.compute-1.amazonaws.com";
    }
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
        if (NetworkClient.isConnected && !NetworkClient.ready)
        {

            NetworkClient.Ready();
            if (NetworkClient.localPlayer == null)
            {
                NetworkClient.AddPlayer();
            }

        }
    }
    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Client Disconnected");
    }

    public void OnConnectedToServer()
    {
        if (NetworkServer.active)
        {
            manager.StartClient();
        }
       
       
    }
}
