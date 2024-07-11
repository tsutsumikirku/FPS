using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] items;
    [SerializeField] float spawnInterval = 2.0f; 
    [SerializeField] Vector2 spawnAreaMin; 
    [SerializeField] Vector2 spawnAreaMax; 

    void Start()
    {
        StartCoroutine(SpawnItems());
    }

   
    IEnumerator SpawnItems()
    {
        while (true)
        {
         
            int randomIndex = Random.Range(0, items.Length);
            GameObject itemToSpawn = items[randomIndex];
            float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float randomY = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
            Vector2 randomPosition = new Vector2(randomX, randomY);
            Instantiate(itemToSpawn, randomPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}