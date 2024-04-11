using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ыв : MonoBehaviour
{
    public Vector3 turn;
    

    void  Update() {
        turn.x = Input.GetAxis("");
        turn.y = Input.GetAxis("");
        turn.z = Input.GetAxis("");
        transform.localRotation = Quaternion.Euler(turn.x, turn.y, turn.z);
    }
}
