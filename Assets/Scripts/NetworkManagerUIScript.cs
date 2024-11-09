using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void Start()
    {
        NetworkManager.Singleton.StartHost();

        if (Input.GetKey(KeyCode.S))
        {
            NetworkManager.Singleton.StartServer();
        };

        if (Input.GetKey(KeyCode.H))
        {
            NetworkManager.Singleton.StartHost();
        };
        if (Input.GetKey(KeyCode.C))
        {
            NetworkManager.Singleton.StartClient();
        };
    }
}
