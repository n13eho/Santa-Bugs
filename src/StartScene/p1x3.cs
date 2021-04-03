using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class p1x3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
#if UNITY_EDITOR
        EditorUtility.DisplayDialog("ATTENTION", "Merry Christmas！", "Yeah!");
#endif
    }
}
