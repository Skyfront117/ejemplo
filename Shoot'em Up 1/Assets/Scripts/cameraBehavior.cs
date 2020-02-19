using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehavior : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rigidBody;
    public float speed = 2.0f;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(speed * (Time.deltaTime * 1000), 0);
    }
}
