
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    public GameObject Skintones, Hair;
    public Sprite[] images;
    public void Dropdown(int i)
    {
            Skintones.GetComponent<Image>().sprite = images[i];
    }
}
