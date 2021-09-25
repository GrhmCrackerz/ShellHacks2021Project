using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemyPreFab;
    public float timeBetweenSpawn = 0.5f;
    float nextSpawnTime;

    Vector2 screenHalfSize;
    // Start is called before the first frame update
    void Start()
    {
        screenHalfSize = new Vector2(Camera.main.aspect, Camera.main.orthographicsize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = timeBetweenSpawn.time + timeBetweenSpawn;
            Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSize.x, screenHalfSize.x), screenHalfSize.y);
            Instantiate(enemyPreFab, spawnPosition);
        }
    }
}