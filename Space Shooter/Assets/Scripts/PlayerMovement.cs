using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float maxSpeed = 2f;
    Rigidbody2D rb;
    float directionX;
    float directionY; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
        directionX = Input.GetAxis("Horizontal") *2;
        directionY = Input.GetAxis("Vertical") *2;

        //Vector2 direction = new Vector2(directionX, directionY);
        //transform.Translate(direction * maxSpeed * Time.deltaTime);

        if (transform.position.x <= -2.5f) transform.position = new Vector3(-2.5f, transform.position.y, transform.position.z);
        if (transform.position.x >= 2.5f) transform.position = new Vector3(2.5f, transform.position.y, transform.position.z);
        if (transform.position.y >= 4f) transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
        if (transform.position.y <= -4f) transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(directionX * maxSpeed, directionY * maxSpeed);
    }

}
