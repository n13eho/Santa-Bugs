using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetGift : MonoBehaviour {

    public AudioClip soundofscore;
    public Text Bonustext;
    private int Bonus = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Candy(Clone)") || (collision.gameObject.name == "Santa-Hat(Clone)")||(collision.gameObject.name== "Star(Clone)"))
        {
            Destroy(collision.gameObject);

            //score++
            Bonus++;
            Bonustext.text = Bonus.ToString();

            //播放音效
            AudioSource.PlayClipAtPoint(soundofscore, transform.position);
            
        }
    }
}
