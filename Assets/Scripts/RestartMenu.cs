using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public void onRestart()
    {
        //Time.timeScale = 1;
        Invoke("Restart", 0.5f);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void goToMainMenu()
    {
        //Time.timeScale = 1;
        Invoke("Menu", 0.5f);
    }

    void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
