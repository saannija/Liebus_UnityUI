using UnityEngine;
using UnityEngine.UI;

public class SizeSlider : MonoBehaviour
{
    public Slider sliderW;
    public Slider sliderH;
    public Image character;
    private float initialYPos;
    public float maxHeight = 550f;
    public float maxWidth = 550f;
    private float height, width;
    private Vector2 originalSize;

    void Start()
    {
        sliderW.onValueChanged.AddListener(WidthChanging);
        sliderH.onValueChanged.AddListener(HeightChanging);
        // Set the image's initial Y position
        initialYPos = character.rectTransform.anchoredPosition.y;
        // Store the original size of the image
        originalSize = character.rectTransform.sizeDelta;
    }

    public void WidthChanging(float value)
    {
        width = value * maxWidth;
        float H = character.rectTransform.sizeDelta.y;
        float scale = width / character.rectTransform.sizeDelta.x;
        character.transform.localScale = new Vector2(scale, H / maxHeight);
    }

    public void HeightChanging(float value)
    {
        float newHeight = value * maxHeight;
        height = newHeight;
        float scale = newHeight / character.rectTransform.sizeDelta.y;
        float newWidth = character.rectTransform.sizeDelta.x * scale;
        character.rectTransform.sizeDelta = new Vector2(newWidth, newHeight);

        // Move the image up within the frame
        float newYPos = initialYPos + (newHeight - maxHeight) / 2;
        character.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
    }

    public void ResetSize()
    {
        // Reset the size of the image to the original size
        character.rectTransform.sizeDelta = originalSize;
        character.transform.localScale = Vector2.one;
        // Reset the slider values
        sliderW.value = 1f;
        sliderH.value = 1f;
    }
}
