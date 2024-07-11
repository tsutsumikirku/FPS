using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameDirecter : MonoBehaviour
{
    // Ø‚è‘Ö‚¦‚éƒV[ƒ“‚Ì–¼‘O
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

       
        var gamepad = Gamepad.current;
        if (hp == 2)
        {
            hp3.SetActive(false);

        }
        if(hp == 1)
        {
            hp2.SetActive(false);
        }
        if(hp == 0)
        {
            hp1.SetActive(false);

            if (gamepad is DualSenseGamepadHID dualSense)
            {
                dualSense.SetMotorSpeeds(0f, 0f);
              
            }

            SceneManager.LoadScene(sceneName);
        }
        if(hp == 3)
        {
            hp3.SetActive(true);
            hp2.SetActive(true);
        }
        if(hp == 2)
        {
            hp2.SetActive(true);
        }




        if (hp > 3)
        {
            hp = 3;
        }

    }
    public void Hpc(int s)
    {
        hp = hp - s;
        Instantiate(damage);
    }

    public void chengehp(int chengeHp)
    {
        hp += chengeHp;
    }

   
   
}
