using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapsLink: MonoBehaviour
{
    public string mapsURL = ""; // Örneğin Sultanahmet'in koordinatları

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
