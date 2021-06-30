using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;
    private GameObject newPlatform;

    /// <summary>
    /// This is used to kill the player & destroy and respawn the platforms
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            GameManager.self.GetComponent<Animator>().SetTrigger("Death");
        else
            newPlatform = (GameObject)Instantiate(platform, new Vector3(Random.Range(-2.0f, 2.0f), player.transform.position.y + (8 + Random.Range(0.5f, 0.1f))), Quaternion.identity);
       
        Destroy(collision.gameObject);
    }
}
