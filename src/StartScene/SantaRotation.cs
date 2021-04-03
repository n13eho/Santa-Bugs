using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(0, 1, 0));//图片绕着y轴转动
    }
}
