using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8.0f;
    private Rigidbody playerRb;
    private float xBound = 15.0f;
    private float zBound = 15.0f;
    private float buffer = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walls();
        MovePlayer();
    }
    
    void MovePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");
        //moves player based on arrow key input
        playerRb.AddForce(Vector3.right * speed * verticalInput);    }

    //makes walls
    void Walls()
    {
        //Keeps player on screen z axis
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound - buffer);
        }
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound + buffer);
        }
        //Keeps player on screen x axis
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound - buffer, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound + buffer, transform.position.y, transform.position.z);
        }
    }
}
