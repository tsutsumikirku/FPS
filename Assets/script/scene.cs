using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
   // シーンを切り替えるキー
    public KeyCode switchKey = KeyCode.S;
    
    // 切り替えるシーンの名前
    public string sceneName;

    void Update()
    {
        // Sキーが押されたら
        if (Input.GetKeyDown(switchKey))
        {
            // シーンを切り替える
            SceneManager.LoadScene(sceneName);
        }
    }
}
