using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
  public int coin = 0;
    [SerializeField] GameObject inse;
    [SerializeField]Text oneP;
    [SerializeField]Text twoP;
    [SerializeField]Text PressStart;
   
    // シーンを切り替えるキー
    public KeyCode switchKey = KeyCode.S;

    // 切り替えるシーンの名前
    public string sceneName;

    bool push;
    [SerializeField] GameObject coinin;
    [SerializeField] GameObject start;
    float time;
    void Start()
    {
        Cursor.visible = false;
        text = GetComponent<Text>();
        oneP.enabled = false;
        PressStart.enabled = false;
        time = 100;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text.text = "Credit (s) " + coin;
        push = Input.GetKeyDown("c"); 
        
        if(coin >= 1)
        {
            Destroy(inse);
            oneP.enabled = true;
            PressStart.enabled=true;
        }
       
        if (push && coin < 1)
        {
            coin += 1;
            Instantiate(coinin);

            
        }
        if (time > 1 && time < 99)
        {
         
            // シーンを切り替える
            SceneManager.LoadScene(sceneName);
        }
        if(coin == 1)
        {
            // Sキーが押されたら
            if (Input.GetKeyDown(switchKey))
            {
                Instantiate(start);
                time = 0;
            }
        }

    }
    
}
