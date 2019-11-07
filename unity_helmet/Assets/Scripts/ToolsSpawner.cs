using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject toolsPrefab;

    float lastSpawnTime;

    [Range(0, 20)]
    public float spawnDelay = 3.0f;
    [Range(0, 8)]
    public float deltaRandomSpawn = 0.5f;


    private float randomSpawnDelay;


    private void Start()
    {
        if (toolsPrefab == null)
            return;

        //randomSpawnDelay = spawnDelay;
        //SpawnJumper();
    }

    private void Update()
    {
        if (Time.time > lastSpawnTime + randomSpawnDelay)
        {
            SpawnTools();
        }
    }

    private void SpawnTools()
    {
        lastSpawnTime = Time.time;
        randomSpawnDelay = Random.Range(spawnDelay - deltaRandomSpawn, spawnDelay + deltaRandomSpawn);
        Instantiate(toolsPrefab);
    }
}
