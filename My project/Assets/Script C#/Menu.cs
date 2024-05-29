using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public static int x = 0;
    public GameObject fg;
    public GameObject one;
    public GameObject two;
    public GameObject thre;
    public GameObject four;

    public void exit(){
        Application.Quit();
    }

    private void Awake()
    {
        if (x == 1)
        {
            fg.SetActive(true);
            one.SetActive(false);
            two.SetActive(false);
            thre.SetActive(false);
            four.SetActive(false);

        }
        else
        {
            x++;
        }
    }

    void Start(){
        
    }
}
