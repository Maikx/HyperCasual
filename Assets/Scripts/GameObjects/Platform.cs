using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 12f;

    /// <summary>
    /// This is used to give the player a jump force when it touches the platform
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }
}
