using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class QutionsOneCO : MonoBehaviour
{
    public GameObject[] obj;
    public Text Res1;
    public Text Res2;
    public Text Res3;
    public Text Res4;
    public Text Res5;
    public Text Res6;


    int randCount;
    List<int> generatedNumbers = new List<int>();
    

    private void Awake() {
        
        for (int i = 0; i < 6; i++) {
            randCount = Random.Range(0, obj.Length);

            while (generatedNumbers.Contains(randCount))
            {
                randCount = Random.Range(1, 10);
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

        //print(nameM1);
    }

    public static void Rand()
    {
        
        

        for (int i = 0; i < 10; i++)
        {
            int number = Random.Range(1, 10);

            
            Console.WriteLine(number);
        }
    }

}
