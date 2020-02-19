using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public GameObject mainCamera;
    private float verticalSpeed = 10.0f;
    private float horizontalSpeed = 5.0f;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, verticalSpeed * (Time.fixedDeltaTime * 1000));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, -verticalSpeed * (Time.fixedDeltaTime * 1000));
        }
        else
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.velocity = new Vector2(horizontalSpeed * (Time.fixedDeltaTime * 1000), rigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidBody.velocity = new Vector2(-horizontalSpeed * (Time.fixedDeltaTime * 1000), rigidBody.velocity.y);
        }
        else 
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
    }
}
