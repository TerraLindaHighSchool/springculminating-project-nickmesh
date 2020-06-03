using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        score += 1;
        Debug.Log("Score = " + score);
        if (score == 5)
        {
            playerControllerScript.gameOver = true;
            Debug.Log("You Win!");
        }
    }
}
