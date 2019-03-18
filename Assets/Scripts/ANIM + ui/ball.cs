using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public Animator Anim;
    public Rigidbody Rigid;
    public bool go = false;
    public bool starttimer = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        go = GameObject.Find("UIManager").GetComponent<UiManagerAccueil>().go;

        if (Anim.GetBool("shake") == false && go == true)
        {
            Rigid.constraints &= ~RigidbodyConstraints.FreezePositionY;
            starttimer = true;
        }
    }
}
