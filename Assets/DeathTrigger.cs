using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;
    private GameObject newPlatform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        newPlatform = (GameObject)Instantiate(platform, new Vector3(Random.Range(-2.5f, 2.5f), player.transform.position.y + (14 + Random.Range(0.5f, 2f))), Quaternion.identity);
        Destroy(collision.gameObject);
        GameManager.self.GetComponent<Animator>().SetTrigger("Death");
    }
}
