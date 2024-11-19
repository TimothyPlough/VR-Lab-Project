using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class networkStartScript : MonoBehaviour
{
    private int bttnPress = staticValue.valueToKeep;

    private void Start()
    {
        switch (bttnPress)
        {
            case 0:
                NetworkManager.Singleton.StartHost();
                break;
            case 1:
                NetworkManager.Singleton.StartClient();
                break;
            case 2:
                NetworkManager.Singleton.StartServer();
                break;
        }
    }
}
