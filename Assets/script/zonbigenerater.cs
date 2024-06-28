using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonbiGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] zonbi;
    [SerializeField] float interbal;
    [SerializeField] float interbalSpeed;
    float time;
  
    

    Queue<int> lastIndices = new Queue<int>();

    void Start()
    {
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > interbal && interbal > 0.3)
        {
            interbal -= interbalSpeed;
            GenerateZonbi();
            time = 0;
        }
        if(time > interbal && interbal < 0.3)
        {
            GenerateZonbi();
            time = 0;
        }
    }

    void GenerateZonbi()
    {
    
        int randomIndex;

        do
        {
            randomIndex = Random.Range(0, zonbi.Length);
        } while (lastIndices.Contains(randomIndex) && lastIndices.Count >= 3);

        GameObject newZonbi = Instantiate(zonbi[randomIndex]);
       
        

        lastIndices.Enqueue(randomIndex);
        if (lastIndices.Count > 3)
        {
            lastIndices.Dequeue();
        }
    }

}
