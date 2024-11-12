using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStartScript : MonoBehaviour
{
    private void Awake()
    {
        NetworkManager.Singleton.StartHost();
    }
}
