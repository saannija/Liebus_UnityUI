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

        // Only update the width, keep the height unchanged
        character.rectTransform.sizeDelta = new Vector2(newWidth, character.rectTransform.sizeDelta.y);
        eyes.rectTransform.sizeDelta = new Vector2(newWidth, eyes.rectTransform.sizeDelta.y);
        mouth.rectTransform.sizeDelta = new Vector2(newWidth, mouth.rectTransform.sizeDelta.y);
        eyebrows.rectTransform.sizeDelta = new Vector2(newWidth, eyebrows.rectTransform.sizeDelta.y);
    }



    public void HeightChanging(float value)
    {
        float newHeight = value * maxHeight;

        // Only update the height, keep the width unchanged
        character.rectTransform.sizeDelta = new Vector2(character.rectTransform.sizeDelta.x, newHeight);
        eyes.rectTransform.sizeDelta = new Vector2(eyes.rectTransform.sizeDelta.x, newHeight);
        mouth.rectTransform.sizeDelta = new Vector2(mouth.rectTransform.sizeDelta.x, newHeight);
        eyebrows.rectTransform.sizeDelta = new Vector2(eyebrows.rectTransform.sizeDelta.x, newHeight);

        // Move the image up within the frame
        float newYPos = initialYPos + (newHeight - maxHeight) / 2;
        character.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        eyes.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        mouth.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
        eyebrows.rectTransform.anchoredPosition = new Vector2(character.rectTransform.anchoredPosition.x, newYPos);
    }

}
