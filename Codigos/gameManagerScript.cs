using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public void pauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void playButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
