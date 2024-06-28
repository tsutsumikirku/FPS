using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float ti;
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > ti)
        {
            Destroy(gameObject);
        }
        
    }
}
