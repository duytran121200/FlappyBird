using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    private void Start()
    {
        instance = this;
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }

    //public void PlayGame()
    //{
    //    SceneManager.LoadScene(0);
    //}

    public void Exit()
    {
        Application.Quit(); 
    }

    void play()
    {
        // diem(); 
        // an nut ();
        // coin bay ();
        // coi hoan ();
        
    }
}
