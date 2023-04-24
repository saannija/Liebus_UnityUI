using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{
    private string txt;
    private string[] var = {"Sveiks ", "Jauku dienu ",
        "Prieks Tevi redzēt ", "Uzredzéśanos "};
    int rand;
    public GameObject inputField;
    public GameObject txtShow;


    public void UzglabatTekstu()
    {
        rand = Random.Range(0, var.Length);
        txt = inputField.GetComponent<Text>().text;
        txtShow.GetComponent<Text>().text =
            var[rand] + txt.ToUpper() + "!";
    }
}
