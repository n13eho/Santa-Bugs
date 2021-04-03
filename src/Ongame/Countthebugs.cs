using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI中，文字要用

public class Countthebugs : MonoBehaviour {

    public Text thedeadbugtext;
    public int thedeadbug = 0;

    private GameObject[] rBugs;
    private GameObject[] nBugs;
    


    // Use this for initialization
    void Start () {
        //GameObject got = GameObject.Find("Canvas/thedeadbugs");
        //thedeadbugtext = got.GetComponent<Text>();
        rBugs = GameObject.FindGameObjectsWithTag("Bug");

    }
	
	// Update is called once per frame
	void Update () {

        nBugs = GameObject.FindGameObjectsWithTag("Bug");
        //分数加一
        thedeadbug=rBugs.Length - nBugs.Length;
        //Debug.Log(thedeadbug);
        thedeadbugtext.text = thedeadbug.ToString();
        //Debug.Log("i just did it");
        

    }
}
