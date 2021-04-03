using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class EndTheGame : MonoBehaviour {


    private Camera mainCamera;
    public float speed = 3;

    // Use this for initialization
    void Start () {
        mainCamera = Camera.main;//还非得要把main camer的标签设置成main camera才行 不然又会说NULL
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "SantaClaus")
        {//如果BUG碰到了SANTA，则显示会话框或者结束界面，然后再加点艺术效果（条件允许的话）
         //EditorUtility.DisplayDialog("哦豁", "YOU'VE LOST IT", "？？？");//这个地方应该不是这样处理的
         //先冻结
            StartCoroutine(GameOverAnimation());
        }
    }



    IEnumerator GameOverAnimation()
    {//协同还是没弄好
        while (true)
        {
            mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor, Color.red, speed * Time.deltaTime);
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, 3, speed * Time.deltaTime);
            if (Mathf.Abs(mainCamera.orthographicSize - 3) < 0.01f)
            {
                break;
            }
            yield return 0;
        }
        //yield return new WaitForSeconds(0.5f);//等了这几秒时间之后，下一句才执行。//看博客园的文章  协同程序
#if UNITY_EDITOR
        EditorUtility.DisplayDialog("哎呀", "YOU'VE LOST IT", "哦豁");
#endif
        
        SceneManager.LoadScene("Offgame");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//重新加载当前场景，让游戏重新开始
    }
}
