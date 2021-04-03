using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatetheBugs : MonoBehaviour {

    public GameObject mydearbug;
    public int MaxBugsnumber = 100;

    bool stillneedthebug = true;
    bool starttocount = false;
    private int count = 0;

    ////随即移动定义的变量
    //float atimer = 0;
    //public float movespeed = 5f;
    //public float changespeed = 40f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (stillneedthebug)
        {
            //先随机产生一个新的方向
            float direction = Random.Range(0f, 360f);//在0--360之间随机生成一个单精度小数)
             
            //将bug拥有不同朝向 实例化出来，然后让他们随机运动(这个随机运动的脚本放在了他自己身上，写不来了)                          //旋转指定度数 先转一个角度 再向这个方向直走即forword
            GameObject.Instantiate(mydearbug, new Vector3(Random.Range(-170.2f, 161f), 0.001f, Random.Range(-134.5f, 102f)),Quaternion.Euler(0, direction, 0));
            count++;

            ////运动走起GameObject go =
            //Transform transform1 = go.GetComponent<Transform>();
            //transform1.Translate(Vector3.forward * Time.deltaTime* movespeed);
            //Debug.Log("???");

            //Bug数量够了，不要再生成了
            if (count > MaxBugsnumber)
            {
                stillneedthebug = false;
                starttocount = true;
            }
        }
        //Debug.Log("生成完毕！"+Time.deltaTime);
        else if(starttocount)
        {
            GameObject.Find("createthebugs").GetComponent<Countthebugs>().enabled = true;
            starttocount = false;
        }
    }
}
