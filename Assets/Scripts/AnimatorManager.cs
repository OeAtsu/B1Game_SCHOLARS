using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {
    public Animator trapleft;
    bool trapleftbool = false;
    public Animator trapright;
    bool traprightbool = false;
    bool MarbleLaunch = false;
    public float timeranim = 0;
    public GameObject MarbleScript;
    public Rigidbody Marble;
    public SphereCollider Capsule;
    public float thrust;
    bool transformmarble = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        //if (PlayerManager.instance.myState == PlayerManager.StatesOfGrav.Free)
        if (trapleftbool == true)
        {
            timeranim += Time.deltaTime;
            if (timeranim > 2 && timeranim<2.2)
            {
                Marble.AddForce(0,thrust,0,ForceMode.Impulse );
            }
            if (timeranim > 2.3)
            {
                MarbleScript.GetComponent<PlayerManager>().enabled = true;
                Capsule.GetComponent<SphereCollider>().enabled = true;
            }
        }



        if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
            if (trapleftbool == false && traprightbool == false)
            {
                trapleft.SetBool("trapleft", true);
                trapleftbool = true;
                trapright.SetBool("trapright", true);
                traprightbool = true;
            }
        }
	}
}
