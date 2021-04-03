using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRock : MonoBehaviour {

    public GameObject stone;
    public GameObject tree;
    public float throwspeed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {//左键扔石头
            GameObject go = GameObject.Instantiate(stone, transform.position, Random.rotationUniform);
            Rigidbody rgd = go.GetComponent<Rigidbody>();
            rgd.velocity = transform.forward * throwspeed;//(0,0,1)方向扔
        }
        if (Input.GetMouseButtonDown(1))
        {//右键扔树
            GameObject got = GameObject.Instantiate(tree, transform.position, Random.rotationUniform);
            Rigidbody rgdt = got.GetComponent<Rigidbody>();
            rgdt.velocity = transform.forward * throwspeed;
        }
    }
}
