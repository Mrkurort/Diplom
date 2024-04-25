using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class TrigerTest2 : MonoBehaviour
{
    public GameObject Triger;
    public GameObject Triger2;

    public Text[] Res;
    public Text b;
    public Text num;

    public void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;        
    }

    public void BtnSelected()
    {
        if (num.text != "")
        {
            switch (Convert.ToInt32(num.text))
            {
                case 1:
                    b.text = Res[0].text;
                    break;
                case 2:
                    b.text = Res[1].text;
                    break;
                case 3:
                    b.text = Res[2].text;
                    break;
                case 4:
                    b.text = Res[3].text;
                    break;
                case 5:
                    b.text = Res[4].text;
                    break;
                case 6:
                    b.text = Res[5].text;
                    break;
                case 7:
                    b.text = Res[6].text;
                    break;
                case 8:
                    b.text = Res[7].text;
                    break;
                case 9:
                    b.text = Res[8].text;
                    break;
                case 10:
                    b.text = Res[9].text;
                    break;
                case 11:
                    b.text = Res[10].text;
                    break;
                case 12:
                    b.text = Res[11].text;
                    break;
                case 13:
                    b.text = Res[12].text;
                    break;
                case 14:
                    b.text = Res[13].text;
                    break;
                case 15:
                    b.text = Res[14].text;
                    break;
            }
        }        
    }

    public void OnMouseDown()
    {
        try
        {
            if (b.text == Triger.name)
            {
                Triger.SetActive(true);
                Triger2.SetActive(false);
                b.text = "";
                QutionsTwoCO.ball += 1;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.red;
                QutionsTwoCO.er += 1;
            }
        }
        catch
        {
            print($"Œÿ¡ ¿!!!!");
        }
    }
    public void OnMouseUp()
    {
        if(GetComponent<Renderer>().material.color == Color.red)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
