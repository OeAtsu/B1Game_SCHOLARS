using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{

    private Animator myAnim;
    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myAnim.SetBool("Activated", true);
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            myAnim.SetBool("Activated", false);
            myAnim.ResetTrigger("Push");
        }

        if (myAnim.GetBool("open"))
        {
           
        }

    }
}
