using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeSlider : MonoBehaviour {
	public GameObject slider;
    private RectTransform rtransform;
    public GameObject character;
	// Use this for initialization
	public void WidthChanging()
	{
		float currentValue=slider.GetComponent<Slider>().value;
		//character.rtransform.sizeDelta=new Vector2(currentValue,0,2);
		character.transform.localScale = new Vector2(1F*currentValue,1);
	}
}
