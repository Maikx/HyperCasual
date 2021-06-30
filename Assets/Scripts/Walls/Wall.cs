using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.transform.position.x > 0)
            collision.gameObject.transform.position = new Vector3(-2.8f, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
        else
            collision.gameObject.transform.position = new Vector3(2.8f, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
    }
}
