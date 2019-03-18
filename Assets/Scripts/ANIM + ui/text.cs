using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public Animator Anim;
    public Rigidbody Rigid;
    public bool endtext = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        endtext = GameObject.Find("UIManager").GetComponent<UiManagerAccueil>().go;
        if (Anim.GetBool("shake") == false && endtext == true)
        {
            Rigid.constraints &= ~RigidbodyConstraints.FreezePositionY;
        }
    }
}
