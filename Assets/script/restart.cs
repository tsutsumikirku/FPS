using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restart : MonoBehaviour
{
    // シーンを切り替えるキー
    public KeyCode switchKey = KeyCode.S;

    // 切り替えるシーンの名前
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Sキーが押されたら
        if (Input.GetKeyDown(switchKey)||Input.GetButtonDown("Fire1"))
        {
            // シーンを切り替える
            SceneManager.LoadScene(sceneName);
        }
    }
}
