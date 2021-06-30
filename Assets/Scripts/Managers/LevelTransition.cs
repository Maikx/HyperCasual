using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public static LevelTransition self;

    private void Start()
    {
        self = this;
    }

    /// <summary>
    /// This is used to reload the level when the player wants to replay
    /// </summary>
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// This is used to exit the game when the player clicks on the quit button
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
