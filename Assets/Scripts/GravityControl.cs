using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
float a;





    // Use this for initialization
    void Start()
    {
        a = -9.8f;
    }

    // Update is called once per frame
    void Update()
    {
        print(a);

        if (Input.GetKeyDown("up") && a < 0)
        {
            a++;

            if (a > -9.8 && Input.GetKeyDown("up"))
            {
                a--;
            }
        }

        /*if (Input.GetKeyDown("down") && a > -9.8)
        {
            a--;
        }*/



        Physics.gravity = new Vector3(0, a, 0);
    }

}
