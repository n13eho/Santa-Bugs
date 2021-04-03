using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followmousey : MonoBehaviour {

    public float moveSpeed = 2f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 获得鼠标当前位置的X和Y
        //float mouseX = Input.GetAxis("Mouse X") * moveSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * moveSpeed;
        //即是绕着X轴反向旋转
        //鼠标在X轴上的移动转为主角左右的移动
        transform.localRotation = transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
    }
}
