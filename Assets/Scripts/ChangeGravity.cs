using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour {

    public Vector3 vectorgravity;

    // Use this for initialization
    void Start () {
        Physics.gravity = new Vector3(0, -10f, 0);
        vectorgravity = Physics.gravity;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vectorgravity = vectorgravity + new Vector3(0,2f,0);
            Physics.gravity = vectorgravity;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vectorgravity = vectorgravity + new Vector3(0, -2f, 0);
            Physics.gravity = vectorgravity;
        }
    }

    void Gravity ()
    {
        Physics.gravity = vectorgravity;
    }
}
