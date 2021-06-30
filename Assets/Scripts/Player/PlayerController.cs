using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Rigidbody2D rb;

    private float topScore = 0.0f;

    public Text scoreText;

    private float moveX;
    private float accX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if(rb.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

        //moveX = Input.GetAxis("Horizontal") * moveSpeed;
        accX = Input.acceleration.x * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = accX;
        //velocity.x = moveX;
        rb.velocity = velocity;
    }
}
