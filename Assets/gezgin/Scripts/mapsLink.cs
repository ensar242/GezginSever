using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapsLink: MonoBehaviour
{
    public string mapsURL = ""; // �rne�in Sultanahmet'in koordinatlar�

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
