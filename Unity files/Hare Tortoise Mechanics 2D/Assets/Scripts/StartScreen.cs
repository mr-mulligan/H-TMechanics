using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScreen : MonoBehaviour {

    //Any button on UI can use this to go to level
    public void GoToGame()
    {
        SceneManager.LoadScene("Debug 2D Scene");
    }
    
    public void GoToMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
