using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private int x;
    public void RightR(){
        transform.Rotate(0, 45, 0);
        x--;
    }

    public void LeftR(){
        transform.Rotate(0, -45, 0);
        x++;
    }

    public void DefPos(){
        transform.Rotate(0, x*45, 0);
        x =0;
    }
}
