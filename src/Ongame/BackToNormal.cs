using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToNormal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("b"))
        {
            transform.rotation = Quaternion.Euler(0, Random.Range(0, 180), 0);
        }
	}
}
