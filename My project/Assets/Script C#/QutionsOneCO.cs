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

    public Text Res1;
    public Text Res2;
    public Text Res3;
    public Text Res4;
    public Text Res5;
    public Text Res6;

    private int Button1;
    private int Button2;
    private int Button3;
    private int Button4;
    private int Button5;
    private int Button6;

    
    int randCount;
    List<int> generatedNumbers = new List<int>();
    

    private void Awake() {
        
        for (int i = 0; i < 6; i++) {
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
                    Button1 = randCount;
                    //print(Button1);
                    break;
                case 1:
                    Res2.text = obj[randCount].name;
                    Button2 = randCount;
                    //print(Button2);
                    break;
                case 2:
                    Res3.text = obj[randCount].name;
                    Button3 = randCount;
                    //print(Button3);
                    break;
                case 3:
                    Res4.text = obj[randCount].name;
                    Button4 = randCount;
                    //print(Button4);
                    break;
                case 4:
                    Res5.text = obj[randCount].name;
                    Button5 = randCount;
                    //print(Button5);
                    break;
                case 5:
                    Res6.text = obj[randCount].name;
                    Button6 = randCount;
                    /*print(Button6);*/
                    break;
            }
        }                
    }

    public void Active(){
        for (int i = 0; i < generatedNumbers.Count; i++)
        {
            trig[generatedNumbers[i]].SetActive(true);
        }
        
    }

    public void Disable()
    {
        for (int i = 0; i < generatedNumbers.Count; i++)
        {
            trig[generatedNumbers[i]].SetActive(false);
        }
    }

    public void Checking()
    {
        
    }


}
