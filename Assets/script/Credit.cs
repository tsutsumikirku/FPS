using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

   bool push;
    void Start()
    {
        text = GetComponent<Text>();
        oneP.enabled = false;
        twoP.enabled = false;
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
        if(coin >= 2)
        {
            twoP.enabled = true;
        }
        if (push && coin < 2)
        {
            coin += 1;
            
        }

    }
    
}
