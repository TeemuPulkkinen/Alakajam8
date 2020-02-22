using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    { 
        Scene scene = SceneManager.GetActiveScene();
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        Application.Quit();
    }

}