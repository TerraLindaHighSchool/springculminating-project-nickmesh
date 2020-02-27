using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 15.0f;
    private float xSpawnRange = 14.5f;

    private float powerupSpawnTime = 8.0f;
    private float enemySpawnTime = 2.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, 1.0f, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, 1.0f, 10.0f);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);

    }
}
