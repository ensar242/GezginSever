using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapsLink : MonoBehaviour
{
    public string mapsURL = "https://maps.app.goo.gl/uoTjZhgF7kzSfr9m9"; // �rne�in Sultanahmet'in koordinatlar�

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
