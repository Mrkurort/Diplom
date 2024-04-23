using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanged : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;
    
    private void Start() {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel(){
        anim.SetTrigger("Fade");
    }

    public void OnFadeCompleate(){
        SceneManager.LoadScene(levelToLoad);
    }


}
