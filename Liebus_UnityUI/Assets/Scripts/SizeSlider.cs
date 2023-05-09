﻿using UnityEngine;
using UnityEngine.UI;

public class SizeSlider : MonoBehaviour
{
    public Slider sliderW;
    public Slider sliderH;
    public Image character;
    public Image eyes;
    public Image mouth;
    public Image eyebrows;
    private float initialYPos;
    public float maxHeight = 550f;
    public float maxWidth = 550f;
    private float width;

    void Start()
    {
        sliderW.onValueChanged.AddListener(WidthChanging);
        sliderH.onValueChanged.AddListener(HeightChanging);
        initialYPos = character.rectTransform.anchoredPosition.y;
    }

    public void WidthChanging(float value)
    {
       // w=sliderW.GetComponent<Slider>().value;
        width = value * maxWidth;
        float H = character.rectTransform.sizeDelta.y;
        float scale = width / character.rectTransform.sizeDelta.x;
        character.transform.localScale = new Vector2(scale, H / maxHeight);
        eyes.transform.localScale = new Vector2(scale, H / maxHeight);
        mouth.transform.localScale = new Vector2(scale, H / maxHeight);
        eyebrows.transform.localScale = new Vector2(scale, H / maxHeight);

        // eyes.transform.localScale = new Vector2(scale, H / maxHeight);
    }

    public void HeightChanging(float value)
    {
        float newHeight = value * maxHeight;
        float scale = newHeight / character.rectTransform.sizeDelta.y;
        float newWidth = character.rectTransform.sizeDelta.x * scale;
        character.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);
        eyes.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);
        mouth.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);
        eyebrows.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);

        // Move the image up within the frame
        float newYPos = initialYPos + (newHeight - maxHeight) / 2;
        character.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        eyes.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        mouth.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        eyebrows.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);

    }
}
