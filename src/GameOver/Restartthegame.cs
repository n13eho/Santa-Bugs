using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restartthegame : MonoBehaviour {

    public Button Restart;
    public Text babyonemouretime;
    private float timer = 0;
    public float pinlv = 4;

    void Start()
    {
        Restart.onClick.AddListener(TaskOnClick);
    }

    private void Update()
    {
        timer += Time.deltaTime*pinlv;
        if (timer % 2 > 1f) babyonemouretime.text = "";
        else babyonemouretime.text = "One more time!";
    }

    public void TaskOnClick()
    {//这两个都可以
        SceneManager.LoadScene("Ongame");
        Debug.Log("Let's get start!");
        //Application.LoadLevel("Ongame"); 
    }
}
