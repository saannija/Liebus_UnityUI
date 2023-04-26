
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    public GameObject base1, base2, base3, base4, base5;
    public GameObject Skintones;
    public Sprite[] images;
    /*
    public GameObject IzmeraSlaideris;
    public GameObject RotacijasSlaideris;
    */
   /* public void BinaAttels(bool vertiba)
    {
        bins.SetActive(vertiba);
        paKreisi.GetComponent<Toggle>().interactable = vertiba;
        paLabi.GetComponent<Toggle>().interactable = vertiba;
    }
   *//*
    public void Base1(bool img)
    {
        base1.SetActive(img);
    }

    public void Base2(bool img)
    {
        base2.SetActive(img);
    }

    public void Base3(bool img)
    {
        base3.SetActive(img);
    }

    public void Base4(bool img)
    {
        base4.SetActive(img);
    }

    public void Base5(bool img)
    {
        base5.SetActive(img);
    }
    /*
    public void PaKreisiBins()
    {
        bins.transform.localScale = new Vector2(1, 1);
    }

    public void PaLabiBins()
    {
        bins.transform.localScale = new Vector2(-1, 1);
    }
    */
    public void Dropdown(int i)
    {
            Skintones.GetComponent<Image>().sprite = images[i];
    }
    /*
    public void mainitLielumu()
    {
        float pasreizejaisIzmers =
        IzmeraSlaideris.GetComponent<Slider>().value;
        skinTones.transform.localScale =
        new Vector2(1f * pasreizejaisIzmers,
                                     1f * pasreizejaisIzmers);
    }

    public void MainitRotaciju()
    {
        float pasreizejaVertiba =
            RotacijasSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localRotation =
            Quaternion.Euler(0, 0, pasreizejaVertiba * 360);
    }
    */
}
