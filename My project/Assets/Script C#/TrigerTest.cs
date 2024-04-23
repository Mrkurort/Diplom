using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class TrigerTest : MonoBehaviour
{
    public GameObject Triger;
    public GameObject Triger2;

    public Text Res1;
    public Text Res2;
    public Text Res3;
    public Text Res4;
    public Text Res5;
    public Text Res6;

    public Text b;

    public void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;        
    }

    public void BtnSelect1()
    {
        b.text = Res1.text;
    }

    public void BtnSelect2()
    {
        b.text = Res2.text;
    }

    public void BtnSelect3()
    {
        b.text = Res3.text;
    }

    public void BtnSelect4()
    {
        b.text = Res4.text;
    }

    public void BtnSelect5()
    {
        b.text = Res5.text;
    }

    public void BtnSelect6()
    {
        b.text = Res6.text;
    }

    public string GetText()
    {
        return Res1.text;
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
                QutionsOneCO.ball += 1;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.red;
                QutionsOneCO.ball -= 1;
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
