using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restart : MonoBehaviour
{
    // �V�[����؂�ւ���L�[
    public KeyCode switchKey = KeyCode.S;

    // �؂�ւ���V�[���̖��O
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // S�L�[�������ꂽ��
        if (Input.GetKeyDown(switchKey)||Input.GetButtonDown("Fire1"))
        {
            // �V�[����؂�ւ���
            SceneManager.LoadScene(sceneName);
        }
    }
}
