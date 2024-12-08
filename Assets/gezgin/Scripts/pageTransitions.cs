using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pageTransitions : MonoBehaviour
{
    public void StartScreen()
    {
        SceneManager.LoadScene("StartScreen");

    }

    public void MainScreen ()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void Istanbul()
    {
        SceneManager.LoadScene("Istanbul");
    }


}
