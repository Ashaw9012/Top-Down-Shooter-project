using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void menu()
    {
        SceneManager.LoadScene(0); 
    }
}
