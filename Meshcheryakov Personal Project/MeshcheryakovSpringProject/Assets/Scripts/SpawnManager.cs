using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bombPrefab;
    public GameObject hurdlePrefab;
    public GameObject coinPrefab;
    private Vector3 hurdleSpawnPos = new Vector3(25, 0, 0);
    private Vector3 bombSpawnPos = new Vector3(25, 2, 0);
    private float startDelay = 2.0f;
    private float repeatRate = 2.2f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(hurdlePrefab, hurdleSpawnPos, hurdlePrefab.transform.rotation);
            Instantiate(bombPrefab, bombSpawnPos, bombPrefab.transform.rotation);
        }
    }
}

