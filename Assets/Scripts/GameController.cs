using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Canvas pauseCanvas;

    private void Start()
    {
        pauseCanvas.gameObject.SetActive(false);
    }

    public void PauseGame()
    {
        pauseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pauseCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
