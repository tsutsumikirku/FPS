using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject reticle = default;
    Vector2 posi = Vector2.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posi = reticle.transform.position - transform.position;
        gameObject.transform.up = posi;
    }
}
