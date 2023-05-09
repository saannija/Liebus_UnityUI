using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour {

	public Slider red;
    public Slider green;
    public Slider blue;
    public Image[] images;

	private void Start()
    {
        red.onValueChanged.AddListener(RedSlider);
        blue.onValueChanged.AddListener(BlueSlider);
        green.onValueChanged.AddListener(GreenSlider);
    }

    public void RedSlider(float value)
    {
        foreach(Image image in images)
        {
            Color color = image.color;
            color.r = value;
            image.color = color;
        }
        
    }
    public void BlueSlider(float value)
    {
        foreach (Image image in images)
        {
            Color color = image.color;
            color.b = value;
            image.color = color;
        }
    }
    public void GreenSlider(float value)
    {
        foreach (Image image in images)
        {
            Color color = image.color;
            color.g = value;
            image.color = color;
        }
    }
}
