using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour {

    bool spawning = true; 

    float radius = 2.3f;
    float spawnPosX;
    float spawnPosY = 5f;
    float spawnRate = 2;
    float timer = 0;

    public GameObject rock1Prefab;
    public GameObject rock2Prefab;
    
    GameObject rockToSpawn;
    Vector3 spawnPos;


    private void Update()
    {
        if (spawning)
        {
            if (timer <= 0)
            {
                if (Random.Range((int)0, 2) == 0)
                {
                    rockToSpawn = rock1Prefab;
                }
                else rockToSpawn = rock2Prefab;
                spawnPosX = Random.Range(-radius, radius);
                spawnPos = new Vector3(spawnPosX, spawnPosY, 0);
                Instantiate(rockToSpawn, spawnPos, Quaternion.identity, transform);
                timer = spawnRate;  
            }
        }
        timer -= Time.deltaTime; 
    }
}
