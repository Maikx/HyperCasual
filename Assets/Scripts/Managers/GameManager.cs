using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager self;
    public GameObject platformPrefab;
    public GameObject retryButton;
    public GameObject exitButton;
    public GameObject music;

    public int startingPlatformsCount = 10;

    private void Start()
    {
        self = this;
        SpawnInitialPlatforms();
    }

    /// <summary>
    /// This is used to spawn the platform randomly at the start of the game
    /// </summary>
    private void SpawnInitialPlatforms()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < startingPlatformsCount; i++)
        {
            spawnPosition.y += Random.Range(0.5f, 2f);
            spawnPosition.x = Random.Range(-2.5f, 2.5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    /// <summary>
    /// This is used to stop the music.. could have done it better..
    /// </summary>
    public void StopMusic()
    {
        music.GetComponent<Music>().StopMusic();
    }

    /// <summary>
    /// Those buttons appear when the player dies.
    /// </summary>
    public void DeathButtons()
    {
        retryButton.SetActive(true);
        exitButton.SetActive(true);
    }
}
