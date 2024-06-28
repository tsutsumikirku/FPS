using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonbicontrol : MonoBehaviour
{
    
   [SerializeField] float scaleSpeed = 0.1f;
   [SerializeField] Vector3 maxScale = new Vector3(2.0f, 2.0f, 2.0f);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentScale = transform.localScale;
        currentScale += Vector3.one * scaleSpeed * Time.deltaTime;
        transform.localScale = currentScale;
        if (currentScale.x >= maxScale.x || currentScale.y >= maxScale.y || currentScale.z >= maxScale.z)
        {
            Destroy(gameObject);
        }
    }
}
