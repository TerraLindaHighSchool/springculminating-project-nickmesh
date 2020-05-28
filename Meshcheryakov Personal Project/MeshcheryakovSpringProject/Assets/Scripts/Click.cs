using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
