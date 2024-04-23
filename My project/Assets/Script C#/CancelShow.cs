using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelShow : MonoBehaviour
{
    public Text TB;
    public GameObject BC;

    void Update()
    {
        if ( TB.text == "")
        {
            BC.SetActive(false);
        }
    }
}
