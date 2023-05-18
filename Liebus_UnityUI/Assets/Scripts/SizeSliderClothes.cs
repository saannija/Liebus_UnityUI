using UnityEngine;using UnityEngine.UI;public class SizeSliderClothes : MonoBehaviour{    public Slider sliderW;    public Slider sliderH;    private float initialYPos;    public float maxHeight = 700f;    public float maxWidth = 650f;
    private Image image;    void Start()    {        sliderW.onValueChanged.AddListener(WidthChanging);        sliderH.onValueChanged.AddListener(HeightChanging);        image = GetComponent<Image>();        initialYPos = image.rectTransform.anchoredPosition.y;
    }    public void WidthChanging(float value)    {        float targetWidth = value * maxWidth;        float aspectRatio = image.rectTransform.sizeDelta.x / image.rectTransform.sizeDelta.y;        float targetHeight = targetWidth / aspectRatio; 
        image.rectTransform.sizeDelta = new Vector2(targetWidth, image.rectTransform.sizeDelta.y);    }    public void HeightChanging(float value)
    {
        float newHeight = value * maxHeight;
        float currentWidth = image.rectTransform.sizeDelta.x;

        image.rectTransform.sizeDelta = new Vector2(currentWidth, newHeight);
    }
}