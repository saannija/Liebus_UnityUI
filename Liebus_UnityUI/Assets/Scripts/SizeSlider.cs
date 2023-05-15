using UnityEngine;
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
    public float maxHeight = 450f;
    public float maxWidth = 550f;

    private float initialWidth;
    private float initialHeight;

    void Start()
    {
        sliderW.onValueChanged.AddListener(WidthChanging);
        sliderH.onValueChanged.AddListener(HeightChanging);
        initialYPos = character.rectTransform.anchoredPosition.y;
        initialWidth = character.rectTransform.sizeDelta.x;
        initialHeight = character.rectTransform.sizeDelta.y;
    }

    public void WidthChanging(float value)
    {
        float newWidth = value * maxWidth;
        float currentHeight = character.rectTransform.sizeDelta.y;

        character.rectTransform.sizeDelta = new Vector2(newWidth, currentHeight);
        eyes.rectTransform.sizeDelta = new Vector2(newWidth, currentHeight);
        mouth.rectTransform.sizeDelta = new Vector2(newWidth, currentHeight);
        eyebrows.rectTransform.sizeDelta = new Vector2(newWidth, currentHeight);

        // Move the image up within the frame
        float newYPos = initialYPos + (currentHeight - maxHeight) / 2;
        character.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        eyes.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        mouth.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        eyebrows.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
    }


    public void HeightChanging(float value)
    {
        float newHeight = value * maxHeight;
        float aspectRatio = character.rectTransform.sizeDelta.x / character.rectTransform.sizeDelta.y;
        float newWidth = newHeight * aspectRatio;

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
