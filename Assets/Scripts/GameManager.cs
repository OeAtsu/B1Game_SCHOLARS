﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public static GameManager instance = null; //Singleton

    public GameObject Drone;
    public OrbitCenterPlayer orbitCenterPlayer;

    public float G = 9f;
    public GameObject gameOver;

    public float timer = 300;
    public string timerFormatted;
    public bool timeStarted = false;
    public bool isFinish = false;


    public int Score;
    public int AmountBonusPoint = 20;




    //Awake is always called before any Start functions for Singleton
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);


    }

    // Use this for initialization
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //TIMER
        // ATTTENTION A MODIF 

        if (timeStarted)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0 && timeStarted)
        {
            timer = 0;
            timeStarted = false;
            GameOver();
            isFinish = true;
            PlayerManager.instance.myState = PlayerManager.StatesOfGrav.OnGravCenter;
            Debug.Log("end");
        }

        if (Input.GetKeyDown(KeyCode.A) && !timeStarted)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        float minutes = Mathf.Floor(timer / 60);
        float seconds = timer % 60;

        minutes = Mathf.FloorToInt(timer / 60F);
        seconds = Mathf.FloorToInt(timer - minutes * 60);
        System.TimeSpan t = System.TimeSpan.FromSeconds(timer);
        timerFormatted = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        //END TIMER

    }

    public void GameOver()
    {
        gameOver.SetActive(!gameOver.activeSelf);
    }
}