using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapsLink: MonoBehaviour
{
    public string mapsURL = ""; // Örneðin Sultanahmet'in koordinatlarý

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
