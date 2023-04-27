using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour {

	public Slider red;
    public Slider green;
    public Slider blue;
    public Renderer rend;

	void Update () {
		rend.material.color=new Color(red.value, green.value, blue.value);
	}
}
