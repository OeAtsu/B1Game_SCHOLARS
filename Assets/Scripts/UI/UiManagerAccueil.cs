using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManagerAccueil : MonoBehaviour
{

    public Animator text;
    public Animator YourAnimator;
    public float analogr = 0f;
    public float analogl = 0f;
    public bool go = false;

    public GameObject pauseMenu;

    public Text TimerText;
    public string timer;

    public Text ScoreText;
    public string Score;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer = GameManager.instance.timerFormatted;
        TimerText.text = timer;
        analogr = (Input.GetAxis("analogr"));
        analogl = (Input.GetAxis("analogl"));

        Score = GameManager.instance.Score.ToString();
        ScoreText.text = ("SCORE : " + Score);

        if (analogr > 0 && analogl > 0)
        {

            go = true;
        }


        if (analogr == 0 && analogl == 0)
        {

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }

    }

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else if (!pauseMenu.activeSelf)
        {
            Time.timeScale = 1f;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("bye");
    }

}
