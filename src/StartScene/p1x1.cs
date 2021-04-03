using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class p1x1: MonoBehaviour {

    public GameObject stone;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButton(0))
        //{
        //    GameObject go = GameObject.Instantiate(stone, transform.position, transform.rotation);
        //}
	}
    private void OnMouseDown()
    {//这两个地方最开始的时候 没有勾选rigidbody中的is kinematic就一直没法成功
#if UNITY_EDITOR
        EditorUtility.DisplayDialog("乱点什么！","这儿没什么好看的","对不起！");
#endif
    }

}
