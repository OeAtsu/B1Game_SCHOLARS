using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Vector3 vectorgravity;

    public Slider mainSlider;
    public static float timer = 120;
    public string timerFormatted;
    public bool timeStarted = false;



    // Use this for initialization
    void Start()
    {
        Physics.gravity = new Vector3(0, -10f, 0);
        vectorgravity = Physics.gravity;

    }

    // Update is called once per frame
    void Update()
    {


        //TIMER
        timeStarted = GameObject.Find("Marbble").GetComponent<ball>().starttimer;

        if (timeStarted == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            GameOver();
        }

        float minutes = Mathf.Floor(timer / 60);
        float seconds = timer % 60;

        minutes = Mathf.FloorToInt(timer / 60F);
        seconds = Mathf.FloorToInt(timer - minutes * 60);
        System.TimeSpan t = System.TimeSpan.FromSeconds(timer);
        timerFormatted = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        //END TIMER


        // CONTROL GRAVITY
        if (Input.GetAxis("analogr") > 0 && vectorgravity.y < -1)
        {
            vectorgravity = vectorgravity + new Vector3(0, 0.5f * Input.GetAxis("analogr"), 0);
            Physics.gravity = vectorgravity;
        }
        //retour a -10
        if (vectorgravity.y < -10 && Input.GetAxis("analogr") == 0 && Input.GetAxis("analogl") == 0)
        {
            vectorgravity = vectorgravity + new Vector3(0, +0.2f, 0);
            Physics.gravity = vectorgravity;
        }



        if (Input.GetAxis("analogl") > 0 && vectorgravity.y > -20)
        {
            vectorgravity = vectorgravity + new Vector3(0, -0.5f * Input.GetAxis("analogl"), 0);
            Physics.gravity = vectorgravity;
        }
        //retour a -10
        if (vectorgravity.y > -10 && Input.GetAxis("analogl") == 0 && Input.GetAxis("analogr") == 0)
        {
            vectorgravity = vectorgravity + new Vector3(0, -0.2f, 0);
            Physics.gravity = vectorgravity;
        }

        mainSlider.value = vectorgravity.y;

        //END CONTROL GRAVITY

    }

    void GameOver()
    {

    }

}