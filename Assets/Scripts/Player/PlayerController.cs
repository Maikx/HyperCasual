using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool testingOnPc;
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
        Inputs();
        Score();
    }

    private void FixedUpdate()
    {
        FixedInputs();
    }

    /// <summary>
    /// Those are the inputs used ingame, from the inspector you can switch if you want to test from pc
    /// </summary>
    private void Inputs()
    {
        if (testingOnPc)
            moveX = Input.GetAxis("Horizontal") * moveSpeed;
        else
            accX = Input.acceleration.x * moveSpeed;
    }

    /// <summary>
    /// Those are the values given to the rigid body
    /// </summary>
    private void FixedInputs()
    {
        Vector2 velocity = rb.velocity;
        if (testingOnPc)
            velocity.x = moveX;
        else
            velocity.x = accX;
        rb.velocity = velocity;
    }

    /// <summary>
    /// This shouldn't be here.. it's used to count the score
    /// </summary>
    private void Score()
    {
        if (rb.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        scoreText.text = "" + Mathf.Round(topScore).ToString();
    }
}
