using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Vector3 vectorgravity;

    public Slider mainSlider;


    // Use this for initialization
    void Start () {
        Physics.gravity = new Vector3(0, -10f, 0);
        vectorgravity = Physics.gravity;


        

    }

    // Update is called once per frame
    void Update () {


        if (Input.GetAxis("analogr")>0 && vectorgravity.y < -1)
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



        if (Input.GetAxis("analogl")>0 && vectorgravity.y > -20)
        {
            vectorgravity = vectorgravity + new Vector3(0, -0.5f* Input.GetAxis("analogl"), 0);
            Physics.gravity = vectorgravity;
        }
        //retour a -10
        if (vectorgravity.y > -10 && Input.GetAxis("analogl") == 0 && Input.GetAxis("analogr") == 0)
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
