using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class p1x2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.Log(Physics.queriesHitTriggers);//是TRUE啊！！！咋点不动了呢
    }
	
	// Update is called once per frame
	void Update () {

	}
    private void OnMouseDown()
    {
        Debug.Log("点上了");
#if UNITY_EDITOR
        EditorUtility.DisplayDialog("鳖点了！", "Nothing left,and nothing right.", "对不起！");
#endif
    }
}
