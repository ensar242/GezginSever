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
    public void Adana()
    {
        SceneManager.LoadScene("ADANA");
    }
    public void Adiyaman()
    {
        SceneManager.LoadScene("ADIYAMAN");
    }
    public void AFYON()
    {
        SceneManager.LoadScene("AFYONKARAHISAR");
    }

    public void Ankara()
    {
        SceneManager.LoadScene("Ankara");
    }
    public void Istanbul()
    {
        SceneManager.LoadScene("Istanbul");
    }



}
