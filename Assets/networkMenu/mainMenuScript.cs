using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class mainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button hostBtn;
    [SerializeField] private Button clientBtn;

    private void Awake()
    {
        string[] args = System.Environment.GetCommandLineArgs();

        for(int i = 0; i < args.Length; i++)
        {
            if (args[i] == "launch-as-server")
            {
                staticValue.valueToKeep = 2;
                NetworkManager.Singleton.Shutdown();
                SceneManager.LoadScene(sceneName: "test scene");
            }
        }

        hostBtn.onClick.AddListener(() => {
            staticValue.valueToKeep = 0;
            NetworkManager.Singleton.Shutdown();
            SceneManager.LoadScene(sceneName: "test scene");
        });
        clientBtn.onClick.AddListener(() => {
            staticValue.valueToKeep = 1;
            NetworkManager.Singleton.Shutdown();
            SceneManager.LoadScene(sceneName: "test scene");
        });
    }
}
