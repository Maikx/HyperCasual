using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    bool isEnabled = true;
    public GameObject musicButton;
    public AudioClip music;

    /// <summary>
    /// This is used to start the ingame music
    /// </summary>
    public void StartMusic()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    /// <summary>
    /// This is used to stop the ingame music
    /// </summary>
    public void StopMusic()
    {
        gameObject.GetComponent<AudioSource>().Stop();
    }

    /// <summary>
    /// This is a way to tell if the button is already on or off
    /// </summary>
    public void OnButtonClick()
    {
        if (isEnabled)
        {
            ButtonDisabled();
            isEnabled = false;
        }
        else
        {
            ButtonEnabled();
            isEnabled = true;
        }
    }

    /// <summary>
    /// This is when the button should disable the music, becomes red
    /// </summary>
    void ButtonDisabled()
    {
        StopMusic();
        musicButton.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
    }

    /// <summary>
    /// This is when the button should enable the music, becomes green
    /// </summary>
    void ButtonEnabled()
    {
        StartMusic();
        musicButton.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
    }
}
