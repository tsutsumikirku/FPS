using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunsound : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 1)
        {
            Destroy(gameObject);
        }
        
    }
}
