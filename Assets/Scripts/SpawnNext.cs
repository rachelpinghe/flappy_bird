using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNext : MonoBehaviour
{
    public float x_trigger = -5.328205f;
    public float x_spawn = 15.04f;
    public float y_spawn = 1.65f; // Y position where the prefab will be spawned
    public GameObject prefabToSpawn;
    bool hasSpawned = false;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < x_trigger && !hasSpawned)
        {
            hasSpawned = true;
            Vector3 spawnPosition = new Vector3(x_spawn, y_spawn, 0);
            GameObject.Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
