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
        if (currentSlide >= slides.Count)
        {
            currentSlide = slides.Count - 1;
        }
    }
    public void Previous()
    {
        currentSlide--;
        if (currentSlide < 0)
        {
            currentSlide = 0;
        }
    }
}
