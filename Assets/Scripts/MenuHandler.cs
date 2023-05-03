using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

[DefaultExecutionOrder(1000)]
public class MenuHandler : MonoBehaviour
{
    public static MenuHandler Instance;
    [SerializeField]
    public InputField PlayerName;
    private void Awake()
    {
        if(Instance != null) {;
            return;
        }
        Instance = this;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

}