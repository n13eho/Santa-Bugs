using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testofrandommove : MonoBehaviour {
    

    float atimer = 0;
    public float movespeed = 5f;
    public float changespeed = 40f;

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        atimer += Time.time;
        if (atimer >= changespeed)
        {
            randommove();
            atimer = 0;
        }
        transform.Translate(Vector3.forward * Time.deltaTime*movespeed);
    }

    private void randommove()
    {
        float direction = Random.Range(0f, 360f);//在0--360之间随机生成一个单精度小数)
        transform.rotation = Quaternion.Euler(0, direction, 0);//旋转指定度数 先转一个角度 再向这个方向直走即forword
        //transform.Translate(Vector3.forward * Time.deltaTime);//向前移动     但是这个移动速度过快 需要用获取rigidbidy的方法来控制速度 如下
        //Debug.Log(transform.rotation);
        //Debug.Log(transform.position);
        //Rigidbody rgd = gameObject.GetComponent<Rigidbody>();
        //rgd.velocity = transform.forward * Time.deltaTime;
    }
}
