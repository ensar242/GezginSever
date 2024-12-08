using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageTransition : MonoBehaviour
{
    public Image displayImage; // Görüntülenecek resim alaný
    public Sprite[] images; // Resim dizisi
    private int currentIndex = 0;

    void Start()
    {
        UpdateImage();
    }

    public void NextImage()
    {
        if (images.Length == 0) return;
        currentIndex = (currentIndex + 1) % images.Length; // Sonraki resmi göster
        UpdateImage();
    }

    public void PreviousImage()
    {
        if (images.Length == 0) return;
        currentIndex = (currentIndex - 1 + images.Length) % images.Length; // Önceki resmi göster
        UpdateImage();
    }

    private void UpdateImage()
    {
        displayImage.sprite = images[currentIndex]; // Resmi güncelle
    }
}
