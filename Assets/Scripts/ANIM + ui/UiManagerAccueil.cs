using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManagerAccueil : MonoBehaviour {

    public Animator text;
    public Animator YourAnimator;
    public float analogr = 0f;
    public float analogl = 0f;
    public bool go = false;
    public Text TimerText;
    public string timer;


    // Use this for initialization
    void Start () {
        YourAnimator.SetBool("open", false);
        text.SetBool("shaketext", false);

    }

    // Update is called once per frame
    void Update()
    {

        timer = GameObject.Find("GameManager").GetComponent<GameManager>().timerFormatted;
        TimerText.text = timer;
        analogr = (Input.GetAxis("analogr"));
        analogl = (Input.GetAxis("analogl"));
        if (analogr > 0 && analogl > 0)
        {
            YourAnimator.SetBool("shake", true);
            text.SetBool("shaketext", true);
            go = true;
        }


        if (analogr == 0 && analogl == 0)
        {
            YourAnimator.SetBool("shake", false);
            text.SetBool("shaketext", false);
        }
    }


public void QuitGame()
    {
        Application.Quit();
    }
}
