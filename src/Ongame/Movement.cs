using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movespeed = 7f;
    //public AudioClip soundofmove;   我本来想着给走路配上音的但是还是有问题
    //private bool ismoving = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float f = Input.GetAxis("Vertical");
        //if (h != 0 || f != 0) ismoving = true;

        transform.Translate(new Vector3(h, 0, f) * movespeed * Time.deltaTime);

        //if(ismoving)
        //{
        //    AudioSource.PlayClipAtPoint(soundofmove, transform.position);
        //    ismoving = false;
        //}
	}
}
