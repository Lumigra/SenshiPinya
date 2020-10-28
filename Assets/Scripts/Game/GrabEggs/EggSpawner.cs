﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    [Header("Variables")]
    [Tooltip("It counts how many items will be spawned")]
    [SerializeField] private int spawnCount;

    public List<GameObject> eggPrefabs = new List<GameObject>();
    [SerializeField] Transform[] spawnArea;
    public List<GameObject> spawnedItems = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        SpawnItem();
    }

    public void SpawnItem()
    {
        // Instantiates prefabs into spawnedItems list
        foreach (GameObject go in eggPrefabs)
        {
            int spawnX = Random.Range(-8, 8);
            int spawnY = Random.Range(-4, 4);
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);

            GameObject newItems = Instantiate(go, transform.position, Quaternion.identity);
            spawnedItems.Add(newItems);
            spawnCount = spawnedItems.Count;
        }
    }
}
