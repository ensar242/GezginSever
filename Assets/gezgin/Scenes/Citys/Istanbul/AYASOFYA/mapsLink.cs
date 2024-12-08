using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapsLink : MonoBehaviour
{
    public string mapsURL = "https://maps.app.goo.gl/uoTjZhgF7kzSfr9m9"; // Örneğin Sultanahmet'in koordinatları

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
