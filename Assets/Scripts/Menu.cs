using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // start game 
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // load options
    public void ShowOptions()
    {
        Debug.Log("Loading options");
    }

    // quit games
    public void QuitGame()
    {
        Application.Quit();
    }


}