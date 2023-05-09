using UnityEngine;
using UnityEngine.UI;

public class SizeSliderClothes : MonoBehaviour
{
    public Slider sliderW;
    public Slider sliderH;
    public Image[] images;
    private float initialYPos;
    public float maxHeight = 200f;
    public float maxWidth = 200f;
    private float width;

    void Start()
    {
        sliderW.onValueChanged.AddListener(WidthChanging);
        sliderH.onValueChanged.AddListener(HeightChanging);
        initialYPos = images[0].rectTransform.anchoredPosition.y;
    }

    public void WidthChanging(float value)
    {
        width = value * maxWidth;
        float H = images[0].rectTransform.sizeDelta.y;
        float scale = width / images[0].rectTransform.sizeDelta.x;
        foreach (Image image in images)
        {
            image.transform.localScale = new Vector2(scale, H / maxHeight);
        }
    }

    public void HeightChanging(float value)
    {
        float newHeight = value * maxHeight;
        float scale = newHeight / images[0].rectTransform.sizeDelta.y;
        float newWidth = images[0].rectTransform.sizeDelta.x * scale;
        foreach (Image image in images)
        {
            image.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);

            // Move the image up within the frame
            float newYPos = initialYPos + (newHeight - maxHeight) / 2;
            image.rectTransform.anchoredPosition = new Vector2(image.rectTransform.anchoredPosition.x, newYPos);
        }
    }
}
