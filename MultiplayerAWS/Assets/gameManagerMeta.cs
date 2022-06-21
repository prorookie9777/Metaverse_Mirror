using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerMeta : MonoBehaviour
{
    public bool isServer;
    public GameObject Moralis;
    
    public void Start()
    {
        if (isServer)
        {
            Moralis.SetActive(false);
        }
        else
        {
            Moralis.SetActive(true);
        }
    }
}
