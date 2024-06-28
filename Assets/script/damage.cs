using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
   [SerializeField] float delete;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > delete)
        {
            Destroy(gameObject);
        }
    }
}
