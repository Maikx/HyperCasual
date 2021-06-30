using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager self;
    public GameObject platformPrefab;

    public int startingPlatformsCount = 15;

    private void Start()
    {
        self = this;
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < startingPlatformsCount; i++)
        {
            spawnPosition.y += Random.Range(0.5f, 2f);
            spawnPosition.x = Random.Range(-2.5f, 2.5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
