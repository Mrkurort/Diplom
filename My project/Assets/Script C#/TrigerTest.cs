using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class TrigerTest : MonoBehaviour
{
    public void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;        
    }


}
