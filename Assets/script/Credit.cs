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
    // �V�[����؂�ւ���L�[
    public KeyCode switchKey = KeyCode.S;

    // �؂�ւ���V�[���̖��O
    public string sceneName;

    bool push;
    void Start()
    {
        text = GetComponent<Text>();
        oneP.enabled = false;
        PressStart.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
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
            
        }
        if(coin == 1)
        {
            // S�L�[�������ꂽ��
            if (Input.GetKeyDown(switchKey))
            {
                // �V�[����؂�ւ���
                SceneManager.LoadScene(sceneName);
            }
        }

    }
    
}
