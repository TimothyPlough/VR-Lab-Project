using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button hostBtn;
    [SerializeField] private Button clientBtn;

    private void Awake()
    {
        hostBtn.onClick.AddListener(() => {
            staticValue.valueToKeep = 0;
            SceneManager.LoadScene(sceneName: "test scene");
        });
        clientBtn.onClick.AddListener(() => {
            staticValue.valueToKeep = 1;
            SceneManager.LoadScene(sceneName: "test scene");
        });
    }
}
