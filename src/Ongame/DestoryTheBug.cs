using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestoryTheBug : MonoBehaviour
{
    
    public GameObject[] gameObjects=null;//掉落出来的物品
    public AudioClip[] soundofdeath = null;//音效的不同
    

    // Use this for initialization
    void Start()
    {
        //    GameObject thiscamera;
        //    thiscamera=GameObject.Find("Main Camera");
        //    CameraPosition = thiscamera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.name == "Cube")
        //{

        //    Destroy(collision.gameObject, 0.5f);
        //    GameObject.Destroy(gameObject);
        //    for(int i=0;i<5;i++)
        //    {
        //        GameObject go = GameObject.Instantiate(Astar, transform.position, transform.rotation);
        //        Rigidbody rgd = go.GetComponent<Rigidbody>();
        //        rgd.velocity = new Vector3(0, 1, 0) * Time.deltaTime*0.1f;
        //    }
        //}
        if ((collision.gameObject.name == "RockforThrow(Clone)")||(collision.gameObject.name == "TreeforThrow(Clone)"))
        {
            Vector3 position = transform.position;
            Quaternion rotation = Random.rotationUniform;
            Debug.Log("did i hit you?");
            GameObject.Destroy(gameObject,0.2f);

            //播放音效
            //AudioSource.PlayClipAtPoint(lazersound, CameraPosition.position);      max:
            AudioSource.PlayClipAtPoint(soundofdeath[Random.Range(0, 13)],transform.position);
            

            Destroy(collision.gameObject, 2f);
            for (int i = 0; i < Random.Range(1,5); i++)
            {
                GameObject go = GameObject.Instantiate(gameObjects[Random.Range(0, 3)], position, rotation);
                Rigidbody rgd = go.GetComponent<Rigidbody>();
                rgd.velocity = transform.forward * Time.deltaTime*0.7f;
            }
        }
    }
}
