using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidesController : MonoBehaviour
{
    [SerializeField] int currentSlide;
    [SerializeField] List<Texture> slides;
    [SerializeField] RawImage image;

    private void Update()
    {
        image.texture = slides[currentSlide];
    }

    public void Next()
    {
        currentSlide++;
    }
    public void Previous()
    {
        currentSlide--;
    }
}
