using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        FollowPlayer();
    }

    /// <summary>
    /// This is used To follow the player and stop if the player altitude is less than the cameras
    /// </summary>
    private void FollowPlayer()
    {
        if (player != null)
        {
            if (player.position.y > transform.position.y)
            {
                Vector3 newPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
                transform.position = newPosition;
            }
        }
    }
}
