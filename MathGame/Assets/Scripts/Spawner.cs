﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4;

    public float spawnRate = 1f;

    float nextSpawn = 0f;

    int whatToSpawn;

    void Update () {
        if (Time.time > nextSpawn) //Generate random numbers between 1 and 4 (add, subtract, multiply, divide), then spawn them.
        {
            whatToSpawn = Random.Range (1,5);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
             case 1:
             Instantiate (prefab1, transform.position, Quaternion.identity);
              break;
             case 2:
              Instantiate (prefab2, transform.position, Quaternion.identity);
              break; 
             case 3:
              Instantiate (prefab3, transform.position, Quaternion.identity);
              break; 
             case 4:
              Instantiate (prefab4, transform.position, Quaternion.identity);
              break;
            }
            nextSpawn = Time.time + spawnRate;
        }
        
    }
}
