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

public class QutionsTwoCO : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject[] trig;
    public GameObject[] Buttons;
    public GameObject LC;
    public Text TB;

    public Animator Dis;

    public Text[] Res;
    
    int randCount;
    public static int ball = 0;
    public static int er = 0;
    public List<int> generatedNumbers = new List<int>();

    private void Awake()
    {
        mark2 = 2;
        ball = 0;
        er = 0;


        Mail.restart2++;

        for (int i = 0; i < obj.Length; i++) 
        {
            randCount = Random.Range(0, obj.Length);

            while (generatedNumbers.Contains(randCount))
            {
                randCount = Random.Range(0, obj.Length);
            }

            generatedNumbers.Add(randCount);

            obj[randCount].SetActive(false);

            Res[i].text = obj[randCount].name;
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
        if (er>=6)
        {
            LC.SetActive(true);
        }
       }
    private void Start()
    {
        Dis.SetTrigger("isTrigger");
    }

    public void Active()
     
    {
        for (int i = 0; i < generatedNumbers.Count; i++)
        {
            if (obj[generatedNumbers[i]].activeSelf)
            {
                Buttons[i].SetActive(false);
                trig[generatedNumbers[i]].SetActive(true);
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
            case 0 or 1 or 2 or 3 or 4 or 5 or 6:
                mark2 = 2;
                break;
            case 7 or 9:
                mark2 = 3;
                break;
            case 10 or 13 or 11 or 12:
                mark2 = 4;
                break;
            case 14 or 15:
                mark2 = 5;
                break;
        }

        Error.text = $"Количество ошибочных ответов: {er}";
        GJ.text = $"Количество верных ответов: {ball}";
        Mark.text = $"Ваша оценка: {Convert.ToString(mark2)}";
    }

    public void CloseDis()
    {
        Dis.SetTrigger("isTrigger");
    }
}