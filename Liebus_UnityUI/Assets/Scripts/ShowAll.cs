using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAll : MonoBehaviour
{

    public GameObject[] images;
    public GameObject imagesToggleGroup;

    private bool isShowing = true;

    public void HideShow()
    {
        isShowing = !isShowing;
        foreach (GameObject image in images)
        {
            image.SetActive(isShowing);
        }
        Toggle[] imagesToggle = imagesToggleGroup.GetComponentsInChildren<Toggle>();
        foreach (Toggle toggle in imagesToggle)
        {
            toggle.isOn = isShowing;
        }
    }
}
