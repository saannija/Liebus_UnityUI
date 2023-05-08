using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    public GameObject button;
    public GameObject image;

    public void Show(bool i)
    {
        image.SetActive(i);
    }
    void Start()
    {
        button.GetComponent<Toggle>().isOn = false;
        image.SetActive(false);
    }

}