using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exitthegame : MonoBehaviour {

    public Button Bye;

    void Start()
    {
        Bye.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        Application.Quit();
        Debug.Log("点上了");
    }
}
