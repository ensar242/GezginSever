using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kızkulesiLink : MonoBehaviour
{
    public string mapsURL = "https://maps.app.goo.gl/fZCKqx1zaPTvMWRh7"; // Örneğin Sultanahmet'in koordinatları

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
