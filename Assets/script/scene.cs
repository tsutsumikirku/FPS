using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
   // �V�[����؂�ւ���L�[
    public KeyCode switchKey = KeyCode.S;
    
    // �؂�ւ���V�[���̖��O
    public string sceneName;

    void Update()
    {
        // S�L�[�������ꂽ��
        if (Input.GetKeyDown(switchKey))
        {
            // �V�[����؂�ւ���
            SceneManager.LoadScene(sceneName);
        }
    }
}
