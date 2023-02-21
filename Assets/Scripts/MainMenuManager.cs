using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public void onPlay()
    {
        Invoke(nameof(StartGame), 0.2f);
    }

    public void onExit()
    {
        Application.Quit();
        Debug.Log("Quitting the app");
    }

    void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    public void onClick()
    {
        Debug.Log("Play button Clicked");
    }
}
