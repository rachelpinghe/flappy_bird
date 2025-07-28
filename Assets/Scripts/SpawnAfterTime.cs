using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAfterTime : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float timeToSpawn = 2f;
    public float xPosition = 2f; // X position where the prefab will be spawned

    public float yMin = -7.55f; // Minimum Y position for spawning
    public float yMax = -0.44f; // Maximum Y position for spawning

    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeToSpawn; // Initialize the timer to the spawn time
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            // Low: -7.55, High: -0.44
            timer = timeToSpawn; // Reset the timer
            float randomY = Random.Range(yMin, yMax);
            Vector3 spawnPosition = new Vector3(xPosition, randomY, 0);
            GameObject.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}