﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Prefab for the obstacle to spawn
    public GameObject obstaclePrefab;
    //Spawn Position
    private Vector3 spawnPos = new Vector3(25.0f, 0.0f, 0.0f);

    //Spawn delay
    private float spawnDelay = 2.0f;
    //Spawn Rate
    private float spawnRate = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}