using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour {

    public GameObject imageS;
    public GameObject imageM;
    public GameObject imageE;
    public Sprite[] imgs;
    public Sprite[] imgm;
    public Sprite[] imge;

    public void DropdownSkin(int i)
    {
        imageS.GetComponent<Image>().sprite = imgs[i];
    }
    public void DropdownMouth(int i)
    {
        imageM.GetComponent<Image>().sprite = imgm[i];
    }
    public void DropdownEyes(int i)
    {
        imageE.GetComponent<Image>().sprite = imge[i];
    }
}
