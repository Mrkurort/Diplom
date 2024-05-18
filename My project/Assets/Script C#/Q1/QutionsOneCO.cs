using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class QutionsOneCO : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject[] trig;
    public GameObject[] Buttons;
    public GameObject LC;
    public Text TB;
    
    public Text Res1;
    public Text Res2;
    public Text Res3;
    public Text Res4;
    public Text Res5;
    public Text Res6;

    int randCount;
    public static int ball = 0;
    public static int er = 0;
    public List<int> generatedNumbers = new List<int>();

    private void Awake()
    {
        mark2 = 0;
        ball = 0;
        er= 0;
        Mail.restart1++;


        for (int i = 0; i < 8; i++) {
            randCount = Random.Range(0, obj.Length);

            while (generatedNumbers.Contains(randCount))
            {
                randCount = Random.Range(1, obj.Length);
            }

            generatedNumbers.Add(randCount);

            obj[randCount].SetActive(false);

            switch (i)
            {
                case 0:
                    Res1.text = obj[randCount].name;
                    break;
                case 1:
                    Res2.text = obj[randCount].name;
                    break;
                case 2:
                    Res3.text = obj[randCount].name;
                    break;
                case 3:
                    Res4.text = obj[randCount].name;
                    break;
                case 4:
                    Res5.text = obj[randCount].name;
                    break;
                case 5:
                    Res6.text = obj[randCount].name;
                    break;
            }
        }                
    }

    private void Update()
    {
        for (int i = 0; i < generatedNumbers.Count; i++)
        {
            if (obj[generatedNumbers[i]].activeSelf)
            {
                Buttons[i].SetActive(false);
            }
            if (TB.text == "")
            {
                trig[generatedNumbers[i]].SetActive(false);
            }
        }
        if (er>=4)
        {
            LC.SetActive(true);
            
        }
        
    }

    public void Active()
    {
        for (int i = 0; i < generatedNumbers.Count; i++)
        {
            if (obj[generatedNumbers[i]].activeSelf)
            {
                Buttons[i].SetActive(false);
            }
            else
            {
                trig[generatedNumbers[i]].SetActive(true);
            }               
        }       
        


    }

    public void Disable()
    {
        for (int i = 0; i < generatedNumbers.Count; i++)
        {
            trig[generatedNumbers[i]].SetActive(false);
        }
    }


    public Animator anim;
    public Text Error;
    public Text GJ;
    public Text Mark;
    static public int mark2 = 0;

    public void Continie()
    {        
        
        switch (ball)
        {
            case 0 or 1 or 2:
                mark2 = 2;
                break;
            case 3:
                mark2 = 3;
                break;
            case 4 or 5:
                mark2 = 4;
                break;
            case 6:
                mark2 = 5;
                break;
        }

        Error.text = $"Количество ошибочных ответов: {er}";
        GJ.text = $"Количество верных ответов: {ball}";
        Mark.text = $"Ваша оценка: {Convert.ToString(mark2)}";

        anim.SetTrigger("isTrigger");
        
    }

    public void ToMailForm()
    {
        anim.SetTrigger("isTrigger");
    }
}
