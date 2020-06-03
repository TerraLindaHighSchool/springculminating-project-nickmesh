using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private int score;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 5)
        {
            playerControllerScript.gameOver = true;
            Debug.Log("You Win!");
        }
    }

    public void OnMouseDown()
    {
        if (gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("Coin"))
        {
            Destroy(gameObject);
            score++;
        }
    }
}
