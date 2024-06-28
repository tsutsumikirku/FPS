using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score");
        text= GetComponent<Text>();
        text.text = "Score " + score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
