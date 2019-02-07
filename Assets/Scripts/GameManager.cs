using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Vector3 vectorgravity;

    public Slider mainSlider;

    public Text Current_Gravity; // assign it from inspector



    // Use this for initialization
    void Start () {
        Physics.gravity = new Vector3(0, -10f, 0);
        vectorgravity = Physics.gravity;


        

    }

    // Update is called once per frame
    void Update () {

        float CurrentGravity = vectorgravity[1];
        
        Current_Gravity.text = CurrentGravity.ToString();

        if (Input.GetKey(KeyCode.UpArrow) && vectorgravity.y < -1)
        {
            vectorgravity = vectorgravity + new Vector3(0, 0.1f, 0);
            Physics.gravity = vectorgravity;
        }
        //retour a -10
        if (vectorgravity.y < -10 && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            vectorgravity = vectorgravity + new Vector3(0, +0.2f, 0);
            Physics.gravity = vectorgravity;
        }






        if (Input.GetKey(KeyCode.DownArrow) && vectorgravity.y > -14)
        {
            vectorgravity = vectorgravity + new Vector3(0, -0.1f, 0);
            Physics.gravity = vectorgravity;
        }
        //retour a -10
        if (vectorgravity.y > -10 && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            vectorgravity = vectorgravity + new Vector3(0, -0.2f, 0);
            Physics.gravity = vectorgravity;
        }

        mainSlider.value = vectorgravity.y;

    }

    void Gravity()
    {
        Physics.gravity = vectorgravity;
    }
}
