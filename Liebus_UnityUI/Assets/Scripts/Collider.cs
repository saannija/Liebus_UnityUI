using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collider : MonoBehaviour {
    public GameObject sliderW, sliderH;
    private RectTransform rtransform;
    public GameObject character;
    float W, H;
    // Use this for initialization
    public void WidthChanging()
    {
        float currentValue = sliderW.GetComponent<Slider>().value;
        W = currentValue;
        character.transform.localScale = new Vector2(1F * currentValue, H);
    }
    public void HeightChanging()
    {
        float currentValue = sliderH.GetComponent<Slider>().value;
        H = currentValue;
        character.transform.localScale = new Vector2(W, 1F * currentValue);
    }
}
