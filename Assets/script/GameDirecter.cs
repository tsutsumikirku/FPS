using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirecter : MonoBehaviour
{
    // êÿÇËë÷Ç¶ÇÈÉVÅ[ÉìÇÃñºëO
    public string sceneName;
    int hp = 3;
    [SerializeField] GameObject hp1;
    [SerializeField] GameObject hp2;
    [SerializeField] GameObject hp3;
    [SerializeField] GameObject damage;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(hp == 2)
        {
            Destroy(hp3);
      
        }
        if(hp == 1)
        {
            Destroy (hp2);
        }
        if(hp == 0)
        {
            Destroy (hp1);
            SceneManager.LoadScene(sceneName);
        }
    }
    public void Hpc(int s)
    {
        hp = hp - s;
        Instantiate(damage);
    }

   
   
}
