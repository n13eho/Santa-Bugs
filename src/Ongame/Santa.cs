using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour {

    public Transform santa;
    public Rigidbody rb;

    public AudioClip soundofjump;
    
    void Start () {

	}
	
	void Update (){
        //santa.Translate(Vector3.forward * Time.deltaTime*movespeed);
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);

        //transform.Translate(0.5f*Time.deltaTime, Time.deltaTime, 0, Space.World);//x,y,z

        //位置改变
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(h, v, 0) * Time.deltaTime);

        //可以用来转动头部
        //float h = movespeed * Input.GetAxis("Mouse X");
        //float v = movespeed * Input.GetAxis("Mouse Y");
        //transform.Rotate(v, h, 0);

        //按下鼠标左键，复制一个（模板，位置，角度）
        //if (Input.GetButtonDown("Fire1"))
        //    Instantiate(santa, new Vector3(5,0,0), transform.rotation);


        //向上跳
        if (Input.GetButtonDown("Jump"))
        {
            AudioSource.PlayClipAtPoint(soundofjump, transform.position);
            // the cube is going to move upwards in 10 units per second
            rb.velocity = new Vector3(0, 5, 0);
        }
    }
}
