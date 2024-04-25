using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnSelectBtn : MonoBehaviour
{
    public Sprite USB;
    public Button[] button;
    public Text Text;

    public void UnSelectButton()
    {
        for (int i = 0; i < button.Length; i++)
        {
            button[i].image.sprite = USB;
        }
    }
    public void UnSelectButtons2()
    {
        for (int i = 0; i < button.Length; i++)
        {
            button[i].image.sprite = USB;
        }
        Text.text = "";
    }
}
