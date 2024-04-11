using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QutionsOneCO : MonoBehaviour
{
    public GameObject[] obj;

    int randCount;
    

    private void Start() {
        
        for (int i = 0; i < 6; i++) {
            randCount = Random.Range(0, obj.Length);

            obj[randCount].SetActive(false);

            

            
        }
        


    }
}
